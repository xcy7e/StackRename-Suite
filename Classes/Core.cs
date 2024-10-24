using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SRSuite.Properties;

namespace SRSuite.Classes
{
    /// <summary>
    /// Core functionality
    /// </summary>
    public class Core
    {

        public static readonly DriveType[] IllegalDriveTypes = { DriveType.CDRom, DriveType.Unknown, DriveType.Ram };

        public const int TYPE_FOLDER = 0;
        public const int TYPE_FILES = 1;
        public const int VIEW_MODE_SIMPLE = 1;
        public const int VIEW_MODE_COMPLEX = 2;

        public readonly Dictionary<string, string> AvailableRuleTypes = new Dictionary<string, string>()
        {
            { "rule_type.replace", "Suchen & Ersetzen" },
            { "rule_type.numbering", "Nummerieren" },
            { "rule_type.append", "Hinten anfügen" },
            { "rule_type.prepend", "Vorne anfügen" },
            { "rule_type.reg_replace", "Ersetzen (Regulärer Ausdruck)" },
            { "rule_type.reg_remove", "Entfernen (Regulärer Ausdruck)" },
        };

        public DriveInfo[] driveList;
        public bool VisibleFolder = true;
        public bool VisibleFiles = true;
        public DriveInfo currentDrive;
        public DirectoryInfo currentDir;
        public int viewMode = VIEW_MODE_COMPLEX;

        public Dictionary<int,RuleSet> ruleSets;
        private Dictionary<int,Rule> allRules;
        public int activeRules = 0;
        public bool individualElementSelection = false;
        public bool renameFileExt = false;

        private MainFrm mainFrm;
        public DirectoryController dirController;

        public Core(MainFrm Sender)
        {
            this.mainFrm = Sender;
            this.dirController = new DirectoryController(Sender);

            this.ruleSets = new Dictionary<int, RuleSet>();
            this.allRules = new Dictionary<int, Rule>();
        }

        /// <summary>
        /// Load drives and directory-list
        /// </summary>
        public void initialize()
        {
            this.initMainToolbar();
        }

        public void initMainToolbar()
        {
            this.loadDrives();
        }

        /// <summary>
        /// (Re)load drives and partitions
        /// </summary>
        public void loadDrives()
        {
            this.driveList = DriveInfo.GetDrives();
            int preselectIndex = Math.Max(0, this.mainFrm.toolbar_main_driveList.SelectedIndex);
            this.mainFrm.toolbar_main_driveList.ComboBox.Items.Clear();

            int i = 0;
            foreach (DriveInfo d in this.driveList)
            {
                if (false == Core.IllegalDriveTypes.Contains(d.DriveType))
                {
                    // DriveType allowed.. add to dropdown
                    string driveName = d.Name.TrimEnd('\\');
                    driveName = driveName + " " + d.VolumeLabel + "";
                    this.mainFrm.toolbar_main_driveList.ComboBox.Items.Insert(i, driveName);
                }
                i++;
            }

            this.mainFrm.toolbar_main_driveList.SelectedIndex = preselectIndex;
        }

        public DriveInfo getSelectedDrive()
        {
            int driveIndex = this.mainFrm.toolbar_main_driveList.SelectedIndex;

            return this.driveList[driveIndex];
        }

        /// <summary>
        /// Drive selection changed, reload directory list
        /// </summary>
        public void driveChanged()
        {
            this.currentDrive = this.getSelectedDrive();
            this.currentDir = this.currentDrive.RootDirectory;

            this.dirController.updateDirectoryLists(this.currentDir);
        }

        public void changePath(string path)
        {
            DirectoryInfo newDir = new DirectoryInfo(path);

            if(newDir.Exists)
            {
                this.dirController.updateDirectoryLists(newDir);
            }
            else
            {
                MessageBox.Show("Dieser Pfad existiert nicht.", "Pfad ungültig", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Change visibility of items by type (folder/files)
        /// </summary>
        /// <param name="type">type of items to change visibility of</param>
        /// <param name="refreshList">False=do not refresh list items</param>
        /// <param name="forceState">True=force visible, false=force invisible</param>
        public void toggleVisibility(int type, bool refreshList = true, bool? forceState = null)
        {
            if(type == Core.TYPE_FOLDER)
            {
                if((this.VisibleFolder || forceState == false) && forceState != true)
                {
                    this.VisibleFolder = false;
                    this.mainFrm.filterBtnFolderVisibility.Image = Resources.gray_folder_disabled;
                    this.mainFrm.filterBtnFolderVisibility.ToolTipText = "Ordner anzeigen";
                } else
                {
                    this.VisibleFolder = true;
                    this.mainFrm.filterBtnFolderVisibility.Image = Resources.yellow_folder_enabled;
                    this.mainFrm.filterBtnFolderVisibility.ToolTipText = "Ordner ausblenden";
                }
            }
            if(type == Core.TYPE_FILES)
            {
                if((this.VisibleFiles || forceState == false) && forceState != true)
                {
                    this.VisibleFiles = false;
                    this.mainFrm.filterBtnFileVisibility.Image = Resources.gray_file_disabled;
                    this.mainFrm.filterBtnFileVisibility.ToolTipText = "Dateien anzeigen";
                } else
                {
                    this.VisibleFiles = true;
                    this.mainFrm.filterBtnFileVisibility.Image = Resources.blue_file_enabled;
                    this.mainFrm.filterBtnFileVisibility.ToolTipText = "Dateien ausblenden";
                }
            }

            if(refreshList)
            {
                this.dirController.updateDirectoryLists(this.currentDir);
            }
        }

        /// <summary>
        /// Update path information (path labels) on drive/path change
        /// </summary>
        public void refreshPathInfo()
        {
            this.mainFrm.txtDirListLeftPath.Text = this.currentDir.FullName;
            this.mainFrm.txtDirListRightPath.Text = this.currentDir.FullName;
        }

        /// <summary>
        /// Navigate through the directory listview folder dblClick
        /// </summary>
        /// <param name="clickedItem"></param>
        public void navigateDirectoryList(ListViewItem clickedItem)
        {
            if (clickedItem.SubItems[2].Text == "")
            {
                // Traverse up, to..
                if (clickedItem.SubItems[1].Text == ".")
                {
                    // ..root
                    string newPath = this.currentDrive.RootDirectory.FullName;
                    this.changePath(newPath);
                }
                else if (clickedItem.SubItems[1].Text == "..")
                {
                    // ..parent
                    string currentPath = this.currentDir.FullName.TrimEnd('\\');
                    string newPath = currentPath.Substring(0, currentPath.LastIndexOf(@"\")) + @"\";
                    this.changePath(newPath);
                }
            }
            else if (clickedItem.SubItems[2].Text == "Ordner")
            {
                // Traverse down, into clicked folder
                string newPath = this.currentDir + @"\" + clickedItem.SubItems[1].Text;
                this.changePath(newPath);
            }

            this.applyRulesPreview();
        }

        /// <summary>
        /// Load all initial rules
        /// </summary>
        public void loadInitialRules()
        {
            if(Settings.Default.setting_initrule_searchreplace)
            {
                this.addRule(RuleTypeReplace.Alias);
            }
            if(Settings.Default.setting_initrule_numbering)
            {
                this.addRule(RuleTypeNumbering.Alias);
            }
            if(Settings.Default.setting_initrule_prepend)
            {
                this.addRule(RuleTypePrepend.Alias);
            }
            if(Settings.Default.setting_initrule_append)
            {
                this.addRule(RuleTypeAppend.Alias);
            }
            if(Settings.Default.setting_initrule_regreplace)
            {
                this.addRule(RuleTypeRegReplace.Alias);
            }
            if(Settings.Default.setting_initrule_regremove)
            {
                this.addRule(RuleTypeRegRemove.Alias);
            }
        }

        /// <summary>
        /// Adds a new Rule of type ruleTypeAlias to active RuleSet
        /// </summary>
        /// <param name="ruleTypeAlias"></param>
        public void addRule(string ruleTypeAlias)
        {
            int newRuleOrder = 1;   // @todo dynamisieren

            int ruleSetIndex = this.getActiveRuleSetIndex();
            RuleSet activeRuleSet = this.addOrGetRuleSet(ruleSetIndex);

            Rule basicRule = new Rule(this, ruleSetIndex, this.getNextRuleIndex(), ruleTypeAlias, true, newRuleOrder);

            TabPage ruleSetPage = this.mainFrm.getActiveRulesetTabpage();

            activeRuleSet.addRule(basicRule);
            this.allRules.Add(basicRule.index, basicRule);
            this.activeRules = (basicRule.enabled) ? this.activeRules + 1 : this.activeRules;

            this.mainFrm.SuspendLayout();
            this.mainFrm.flowLayoutPanel_rules.Controls.Add(basicRule.control);
            this.mainFrm.flowLayoutPanel_rules.Controls.SetChildIndex(this.mainFrm.btn_addRule, this.mainFrm.flowLayoutPanel_rules.Controls.Count);
            this.mainFrm.ResumeLayout(false);

            this.mainFrm.toolStripStatusLabel_lblRulesCounter.Text = this.allRules.Count.ToString();
        }

        /// <summary>
        /// Drop any Rule by its absolute index; Refreshes the Preview
        /// </summary>
        /// <param name="ruleIndex"></param>
        public void dropRule(int ruleIndex)
        {
            // Remove rule element in mainFrm
            this.allRules[ruleIndex].control.Dispose();
            // Remove rule from ruleSet
            this.ruleSets[this.allRules[ruleIndex].ruleSetIndex].rules.Remove(ruleIndex);
            // Remove rule from global stack
            this.allRules.Remove(ruleIndex);

            // Apply rule preview
            this.applyRulesPreview();
        }

        /// <summary>
        /// Get index of current ruleSet
        /// </summary>
        /// <returns></returns>
        public int getActiveRuleSetIndex()
        {
            return this.mainFrm.ruleSetTabs.SelectedIndex;
        }

        /// <summary>
        /// Add or return RuleSet by it's index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public RuleSet addOrGetRuleSet(int index = 0)
        {
            RuleSet ruleSet;
            
            if (!this.ruleSets.TryGetValue(index, out ruleSet))
            {
                // new RuleSet
                ruleSet = new RuleSet(index);
                this.ruleSets.Add(index, ruleSet);
            }

            this.ruleSets.TryGetValue(index, out ruleSet);
            return ruleSet;
        }

        /// <summary>
        /// Returns the next has-to-be (absolute) index for a new Rule over the set of all rules
        /// </summary>
        /// <returns>int</returns>
        public int getNextRuleIndex()
        {
            if (this.allRules.Count == 0)
            {
                return 0;
            } else
            {
                return this.allRules.Last().Key + 1;
            }
        }

        public bool changeViewMode(int viewMode)
        {
            this.viewMode = viewMode;

            return false;
        }

        /// <summary>
        /// Apply all enabled rules to update the renaming preview list
        /// </summary>
        public void applyRulesPreview()
        {
            ListView.ListViewItemCollection leftListItems = this.mainFrm.directoryListViewLeft.Items;

            foreach(ListViewItem lvitem in this.mainFrm.directoryListViewRight.Items)
            {
                this.applyRulesOnListViewItem(lvitem, leftListItems);
            }

            this.mainFrm.directoryListViewRight.Refresh();
        }

        /// <summary>
        /// Apply all enabled rules on a listViewItem
        /// </summary>
        /// <param name="lvitem"></param>
        /// <param name="leftListItems"></param>
        public void applyRulesOnListViewItem(ListViewItem lvitem, ListView.ListViewItemCollection leftListItems)
        {
            if (lvitem.SubItems.Count < 2 || lvitem.Index < 2)
            {
                return;   // skip invalid and traversal items
            }
            if (!lvitem.Checked)
            {
                return;   // skip unchecked items
            }

            bool itemIsFolder = leftListItems[lvitem.Index].SubItems[2].Text == "Ordner";
            ListViewItem.ListViewSubItem txtSubItem = leftListItems[lvitem.Index].SubItems[1];
            string itemStr = txtSubItem.Text;
            string prevStr = itemStr;

            prevStr = this.applyRulesOnStr(prevStr, lvitem.Index, itemIsFolder);

            // Highlight affected items
            if (prevStr != itemStr)
            {
                leftListItems[lvitem.Index].ForeColor = this.mainFrm.highlightColor1;
                leftListItems[lvitem.Index].BackColor = this.mainFrm.highlightColor2;
                lvitem.ForeColor = this.mainFrm.highlightColor1;
                lvitem.BackColor = this.mainFrm.highlightColor2;
            }
            else
            {
                leftListItems[lvitem.Index].ForeColor = SystemColors.WindowText;
                leftListItems[lvitem.Index].BackColor = SystemColors.Window;
                lvitem.ForeColor = SystemColors.WindowText;
                lvitem.BackColor = SystemColors.Window;
            }
            // Update list item
            this.mainFrm.directoryListViewRight.Items[lvitem.Index].SubItems[1].Text = prevStr;
        }

        /// <summary>
        /// Apply all enabled rules on str
        /// </summary>
        /// <param name="str">Elements name to wich to apply the rule to</param>
        /// <param name="lvitemIndex">Elements index in directoryList</param>
        /// <param name="itemIsFolder">If element to rename is of type directory</param>
        /// <returns></returns>
        public string applyRulesOnStr(string str, int lvitemIndex, bool itemIsFolder = false)
        {
            foreach (KeyValuePair<int, RuleSet> ruleSet in this.ruleSets)
            {
                foreach (KeyValuePair<int, Rule> rule in ruleSet.Value.rules)
                {
                    if (rule.Value.enabled)  // rule enabled?
                    {
                        str = rule.Value.ApplyRule(str, lvitemIndex, itemIsFolder, this.renameFileExt);
                    }
                }
            }
            return str;
        }

        public int getRulePanelWidth()
        {
            return this.mainFrm.flowLayoutPanel_rules.Width;
        }

        /// <summary>
        /// Perform renaming operation
        /// </summary>
        public void actionRename()
        {
            // @todo
        }

        /// <summary>
        /// Revert renaming operation
        /// </summary>
        public void actionRevert()
        {
            // @todo
        }

    }
}

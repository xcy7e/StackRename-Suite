using SRSuite.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using SRSuite.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace SRSuite
{
    public partial class MainFrm : Form
    {
        
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        const short SWP_NOMOVE = 0X2;
        const short SWP_NOSIZE = 1;
        const short SWP_NOZORDER = 0X4;
        const int SWP_SHOWWINDOW = 0x0040;

        const int FRM_INIT_SCREEN_DIST_X = 200;
        const int FRM_INIT_SCREEN_DIST_Y = 100;

        public Core core;
        public readonly Color highlightColor1 = Color.Blue;
        public readonly Color highlightColor2 = Color.AliceBlue;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initializeMainFrm();
        }

        private void initializeMainFrm()
        {
            this.setMainFrmSize();
            this.progressBarInit();
            
            this.core = new Core(this);

            this.core.initialize();

            this.initializeToolbar();
            this.core.loadInitialRules();

            // Show content area
            this.SuspendLayout();
            panelProcessbar.Visible = false;
            tableLayoutPanelContentWrapper.Width = this.Width;
            tableLayoutPanelContentWrapper.Height = this.Height;
            tableLayoutPanelContentWrapper.Visible = true;
            this.ResumeLayout(true);
        }

        /// <summary>
        /// Set initial form size with great distance from screen borders and center the form
        /// </summary>
        private void setMainFrmSize()
        {
            int sizeW = Screen.PrimaryScreen.WorkingArea.Width - FRM_INIT_SCREEN_DIST_X;
            int sizeH = Screen.PrimaryScreen.WorkingArea.Height - FRM_INIT_SCREEN_DIST_Y;

            this.Size = new Size(sizeW, sizeH);

            IntPtr handle = this.Handle;
            if (handle != IntPtr.Zero)
            {
                int posX = Screen.PrimaryScreen.WorkingArea.Width / 2 - sizeW / 2;
                int posY = Screen.PrimaryScreen.WorkingArea.Height / 2 - sizeH / 2;
                SetWindowPos(handle, 0, posX, posY, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
            }
        }

        /// <summary>
        /// Load toolbar state from settings
        /// </summary>
        private void initializeToolbar()
        {
            // General
            // - Defaults
            // - - Rename file extensions
            this.setFilterRenameFileExt(Properties.Settings.Default.setting_rename_fileext);

            // View
            // - Defaults
            // - - Folders show
            this.core.toggleVisibility(Core.TYPE_FOLDER, false, Properties.Settings.Default.setting_folders_show);
            // - - Files show
            this.core.toggleVisibility(Core.TYPE_FILES, true, Properties.Settings.Default.setting_files_show);
            // - - Dirlist checkboxes show
            this.setFilterDirListCheckbox(Properties.Settings.Default.setting_dirlist_cb_enable);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolbar_main_driveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.core.driveChanged();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.Show();
        }

        private void mainPanelTablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aktivesRegelsetZurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reloadDrives(object sender, EventArgs e)
        {
            this.core.loadDrives();
        }

        private void openSettingsFrm(object sender, EventArgs e)
        {
            SettingsFrm settingsFrm = new SettingsFrm();
            settingsFrm.Show();
        }

        private void filterBtnFolderVisibility_Click(object sender, EventArgs e)
        {
            this.core.toggleVisibility(Core.TYPE_FOLDER, true);
        }

        private void filterBtnFileVisibility_Click(object sender, EventArgs e)
        {
            this.core.toggleVisibility(Core.TYPE_FILES, true);
        }

        private void txtDirListLeftPath_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                this.core.changePath(txtDirListLeftPath.Text.Trim());
            }
        }

        private void directoryListViewLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo nfo = directoryListViewLeft.HitTest(e.X, e.Y);
            ListViewItem clickedItem = nfo.Item;

            this.core.navigateDirectoryList(clickedItem);
        }

        private void directoryListViewLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection c = directoryListViewLeft.SelectedItems;
            if(c.Count > 0)
            {
                directoryListViewRight.Items[c[0].Index].Selected = true;
            }
        }

        private void directoryListViewRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection c = directoryListViewRight.SelectedItems;
            if (c.Count > 0)
            {
                directoryListViewLeft.Items[c[0].Index].Selected = true;
            }
        }

        public TabPage getActiveRulesetTabpage()
        {
            return this.ruleSetTabs.SelectedTab;
        }

        /*
         * Splitter Double-Click - center 50:50 
         */
        private void splitContainerDirectoryLists_DoubleClick(object sender, EventArgs e)
        {
            double splitterHalfWidth = this.splitContainerDirectoryLists.Width / 2;
            this.splitContainerDirectoryLists.SplitterDistance = (int) Math.Round(splitterHalfWidth, 0);
        }

        public void openAddRuleDialog()
        {
            AddRuleFrm addRuleForm = new AddRuleFrm(this.core);
            addRuleForm.Show();
        }

        public void changeViewSimple(object sender, EventArgs e)
        {
            if(this.core.viewMode == Core.VIEW_MODE_SIMPLE) {
                return; // Nothing to do
            }

            this.core.changeViewMode(Core.VIEW_MODE_SIMPLE);

            this.mainMenu_View_Mode_complexView.Checked = false;
            this.mainMenu_View_Mode_simpleView.Checked = true;
        }

        public void changeViewComplex(object sender, EventArgs e)
        {
            if (this.core.viewMode == Core.VIEW_MODE_COMPLEX)
            {
                return; // Nothing to do
            }

            this.core.changeViewMode(Core.VIEW_MODE_COMPLEX);

            this.mainMenu_View_Mode_simpleView.Checked = false;
            this.mainMenu_View_Mode_complexView.Checked = true;
        }

        /**
         * Update the enabled/disabled states of control elements
         */
        public void updateControlState()
        {

        }

        public void actionRename(object sender, EventArgs eventArgs)
        {
            this.core.actionRename();
        }

        public void actionRevertRenaming(object sender, EventArgs e)
        {
            this.core.actionRevert();
        }

        public void addRuleDialog(object sender, EventArgs e)
        {
            this.openAddRuleDialog();
        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                this.openAddRuleDialog();
            }
        }

        private void filterBtnDirListCheckboxEnable_Click(object sender, EventArgs e)
        {
            this.setFilterDirListCheckbox(true);
        }

        private void filterBtnDirListCheckboxDisable_Click(object sender, EventArgs e)
        {
            this.setFilterDirListCheckbox(false);
        }

        private void filterBtnRenameFileExtEnable_Click(object sender, EventArgs e)
        {
            this.setFilterRenameFileExt(true);
            this.core.applyRulesPreview();
        }

        private void filterBtnRenameFileExtDisable_Click(object sender, EventArgs e)
        {
            this.setFilterRenameFileExt(false);
            this.core.applyRulesPreview();
        }

        private void setFilterDirListCheckbox(bool filterStatus = true)
        {
            if(filterStatus)
            {
                // enable filter
                this.filterBtnDirListCheckboxEnable.Visible = false;
                this.filterBtnDirListCheckboxDisable.Visible = true;

                this.directoryListViewLeft.CheckBoxes = true;
                this.directoryListViewRight.CheckBoxes = true;

                this.core.individualElementSelection = true;
            }
            else
            {
                // disable filter
                this.filterBtnDirListCheckboxDisable.Visible = false;
                this.filterBtnDirListCheckboxEnable.Visible = true;

                this.checkAllListItems(this.directoryListViewLeft);
                this.checkAllListItems(this.directoryListViewRight);

                this.directoryListViewLeft.CheckBoxes = false;
                this.directoryListViewRight.CheckBoxes = false;

                this.core.individualElementSelection = false;
            }
        }

        private void setFilterRenameFileExt(bool filterStatus = true)
        {
            if(filterStatus)
            {
                // enable filter
                filterBtnRenameFileExtEnable.Enabled = false;
                filterBtnRenameFileExtEnable.Visible = false;
                filterBtnRenameFileExtDisable.Visible = true;
                filterBtnRenameFileExtDisable.Enabled = true;

                this.core.renameFileExt = true;
            } else
            {
                // disable filter
                filterBtnRenameFileExtDisable.Visible = false;
                filterBtnRenameFileExtDisable.Enabled = false;
                filterBtnRenameFileExtEnable.Enabled = true;
                filterBtnRenameFileExtEnable.Visible = true;

                this.core.renameFileExt = false;
            }
        }

        private void checkAllListItems(ListView listView)
        {
            this.dirListItemCheckStateChangedInternally = true;
            
            foreach (ListViewItem lvitem in listView.Items)
            {
                if (lvitem.Index <= 1)
                {
                    continue;   // skip traversal items
                }
                lvitem.Checked = true;
            }

            this.dirListItemCheckStateChangedInternally = false;

            this.directoryListViewRight.Refresh();
        }

        // avoid loop when checked internally
        private bool dirListItemCheckStateChangedInternally = false;
        private void directoryListViewLeft_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // avoid checking traversal items
            if(e.Item.Index <= 1 && !this.dirListItemCheckStateChangedInternally)
            {
                e.Item.Checked = false;
                return;
            }

            // (un)check opposite list item
            if (!this.dirListItemCheckStateChangedInternally)
            {
                this.dirListItemCheckStateChangedInternally = true;
                this.directoryListViewRight.Items[e.Item.Index].Checked = e.Item.Checked;
                this.dirListItemCheckStateChangedInternally = false;
            }
        }

        private void directoryListViewRight_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // avoid checking traversal items
            if (e.Item.Index <= 1 && !this.dirListItemCheckStateChangedInternally)
            {
                e.Item.Checked = false;
                return;
            }

            // (un)check opposite list item
            if(!this.dirListItemCheckStateChangedInternally)
            {
                this.dirListItemCheckStateChangedInternally = true;
                this.directoryListViewLeft.Items[e.Item.Index].Checked = e.Item.Checked;
                this.dirListItemCheckStateChangedInternally = false;
            }

            // Apply rules if item was checked
            if (e.Item.Checked)
            {
                ListView.ListViewItemCollection leftListItems = this.directoryListViewLeft.Items;

                this.core.applyRulesOnListViewItem(e.Item, leftListItems);
                
                if(!this.dirListItemCheckStateChangedInternally)
                {
                    e.Item.ListView.Refresh();
                }
            }
        }

        /// <summary>Reset Filter settings</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetFilterSettings(object sender, EventArgs e)
        {
            // Filter: Apply rules to file extensions
            this.setFilterRenameFileExt(false);

            // Filter: DirList - Individual item selection
            this.setFilterDirListCheckbox(false);

            // Filter: Hide spec. file types
            this.filterTxtFileEndingHide.Text = "";

            // Filter: Folder/Files visibility
            this.core.toggleVisibility(Core.TYPE_FOLDER, false, true);
            this.core.toggleVisibility(Core.TYPE_FILES, false, true);

            // Update preview
            this.core.dirController.updateDirectoryLists(this.core.currentDir);
            this.core.applyRulesPreview();
        }

        private void progressBarInit()
        {
            Random rnd = new Random();
            panelProcessbar.Location = new Point(
                (this.Width / 2) - (panelProcessbar.Width / 2),
                (this.Height / 2) - (panelProcessbar.Height / 2)
            );
        }
    }
}

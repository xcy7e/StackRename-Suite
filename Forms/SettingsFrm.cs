using System;
using System.Windows.Forms;
using SRSuite.Properties;

namespace SRSuite.Forms
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            this.loadSettings();
        }

        /// <summary>
        /// Load application properties into the form control states
        /// </summary>
        private void loadSettings()
        {
            // General
            // - Defaults
            // - - Rename file extensions
            cbRenameFileExt.Checked = Settings.Default.setting_rename_fileext;
            // - Initial Rules
            // - - Search & Replace
            cbInitRuleSearchReplace.Checked = Settings.Default.setting_initrule_searchreplace;
            // - - Numbering
            cbInitRuleNumbering.Checked = Settings.Default.setting_initrule_numbering;
            // - - Prepend
            cbInitRulePrepend.Checked = Settings.Default.setting_initrule_prepend;
            // - - Append
            cbInitRuleAppend.Checked = Settings.Default.setting_initrule_append;
            // - - Regex Replace
            cbInitRuleRegReplace.Checked = Settings.Default.setting_initrule_regreplace;
            // - - Regex Remove
            cbInitRuleRegRemove.Checked = Settings.Default.setting_initrule_regremove;

            // View
            // - Defaults
            // - - Folders show
            cbFilterFoldersVisibleEnabled.Checked = Settings.Default.setting_folders_show;
            // - - Files show
            cbFilterFilesVisibleEnabled.Checked = Settings.Default.setting_files_show;
            // - - Dirlist checkboxes show
            radioButtonFilterElementStateAll.Checked = !Settings.Default.setting_dirlist_cb_enable;
            radioButtonFilterElementStateIndividual.Checked = Settings.Default.setting_dirlist_cb_enable;

            // Advanced
            // - Windows Explorer Integration
            // - - Context Menu Integration
            cbExplorerContextMenuIntegrationEnabled.Checked = Settings.Default.setting_context_menu_integration_enabled;

        }

        private void saveSettings(Object sender, EventArgs e)
        {
            // General
            // - Defaults
            // - - Rename file extensions
            Settings.Default.setting_rename_fileext = cbRenameFileExt.Checked;
            // - Initial Rules
            // - - Search & Replace
            Settings.Default.setting_initrule_searchreplace = cbInitRuleSearchReplace.Checked;
            // - - Numbering
            Settings.Default.setting_initrule_numbering = cbInitRuleNumbering.Checked;
            // - - Prepend
            Settings.Default.setting_initrule_prepend = cbInitRulePrepend.Checked;
            // - - Append
            Settings.Default.setting_initrule_append = cbInitRuleAppend.Checked;
            // - - Regex Replace
            Settings.Default.setting_initrule_regreplace = cbInitRuleRegReplace.Checked;
            // - - Regex Remove
            Settings.Default.setting_initrule_regremove = cbInitRuleRegRemove.Checked;

            // View
            // - Defaults
            // - - Folders show
            Settings.Default.setting_folders_show = cbFilterFoldersVisibleEnabled.Checked;
            // - - Files show
            Settings.Default.setting_files_show = cbFilterFilesVisibleEnabled.Checked;
            // - - Dirlist checkboxes show
            Settings.Default.setting_dirlist_cb_enable = radioButtonFilterElementStateIndividual.Checked;

            // Advanced
            Classes.Registry r = new Classes.Registry(this);
            // - Windows Explorer Integration
            // - - Context Menu Integration
            if(cbExplorerContextMenuIntegrationEnabled.Checked != Settings.Default.setting_context_menu_integration_enabled)
            {
                if(r.contextMenuIntegration(cbExplorerContextMenuIntegrationEnabled.Checked))
                {
                    Settings.Default.setting_context_menu_integration_enabled = cbExplorerContextMenuIntegrationEnabled.Checked;
                }
            }


            Settings.Default.Save();
            this.Close();
        }

        private void cancel(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonFilterElementStateAll_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFilterElementStateIndividual.Checked = false;
        }

        private void radioButtonFilterElementStateIndividual_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFilterElementStateAll.Checked = false;
        }
    }
}

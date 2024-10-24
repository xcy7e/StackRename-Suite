using SRSuite.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace SRSuite.Controls
{
    public partial class RuleCtrl : UserControl
    {

        private Core core;
        public UserControl childControl;
        protected RuleType ruleType;
        protected Rule ruleClass;

        public RuleCtrl(Core core, Rule ruleClass, RuleType ruleType)
        {
            this.core = core;
            this.ruleClass = ruleClass;
            this.ruleType = ruleType;

            InitializeComponent();

            this.createChildControl(ruleType);

            this.SuspendLayout();
            this.Width = this.core.getRulePanelWidth();
            this.panelRuleControl.Controls.Add(this.childControl);
            this.panelRuleControl.Height = this.childControl.Height;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void createChildControl(RuleType ruleType)
        {
            switch(ruleType.getAlias())
            {
                case RuleTypeAppend.Alias:
                    this.childControl = new RuleAppend(this.core, (RuleTypeAppend) this.ruleType, this.ruleClass);
                    break;
                case RuleTypeNumbering.Alias:
                    this.childControl = new RuleNumbering(this.core, (RuleTypeNumbering)this.ruleType, this.ruleClass);
                    break;
                case RuleTypePrepend.Alias:
                    this.childControl = new RulePrepend(this.core, (RuleTypePrepend)this.ruleType, this.ruleClass);
                    break;
                case RuleTypeRegRemove.Alias:
                    // @todo build child control
                    break;
                case RuleTypeRegReplace.Alias:
                    // @todo build child control
                    break;
                case RuleTypeReplace.Alias:
                    this.childControl = new RuleReplace(this.core, (RuleTypeReplace) this.ruleType, this.ruleClass);
                    break;
            }
        }

        private void btn_RuleCtrl_settings_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                btn_RuleCtrl_settings.ContextMenuStrip.Show(btn_RuleCtrl_settings, new Point(e.X, e.Y));
            } else if(e.Button is MouseButtons.Right)
            {
                // Right click not open
            }
        }

        private void deaktivierenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.ruleClass.enabled = false;

            switch (ruleType.getAlias())
            {
                case RuleTypeAppend.Alias:
                    RuleAppend a = (RuleAppend) this.childControl;
                    a.disable();
                    break;
                case RuleTypeNumbering.Alias:
                    RuleNumbering b = (RuleNumbering)this.childControl;
                    b.disable();
                    break;
                case RuleTypePrepend.Alias:
                    RulePrepend c = (RulePrepend) this.childControl;
                    c.disable();
                    break;
                //case RuleTypeRegRemove.Alias:
                //    RuleReplace d = (RuleTypeRegRemove) this.childControl;
                //    d.disable();
                //    break;
                //case RuleTypeRegReplace.Alias:
                //    RuleReplace e = (RuleTypeRegReplace) this.childControl;
                //    e.disable();
                //    break;
                case RuleTypeReplace.Alias:
                    RuleReplace f = (RuleReplace) this.childControl;
                    f.disable();
                    break;
            }

            this.deaktivierenToolStripMenuItem.Visible = false;
            this.aktivierenToolStripMenuItem.Visible = true;

            this.core.applyRulesPreview();  // refresh preview
        }

        private void aktivierenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.ruleClass.enabled = true;

            switch (ruleType.getAlias())
            {
                case RuleTypeAppend.Alias:
                    RuleAppend a = (RuleAppend) this.childControl;
                    a.enable();
                    break;
                case RuleTypeNumbering.Alias:
                    RuleNumbering b = (RuleNumbering)this.childControl;
                    b.enable();
                    break;
                case RuleTypePrepend.Alias:
                    RulePrepend c = (RulePrepend)this.childControl;
                    c.enable();
                    break;
                //case RuleTypeRegRemove.Alias:
                //    RuleRegRemove d = (RuleRegRemove) this.childControl;
                //    d.enable();
                //    break;
                //case RuleTypeRegReplace.Alias:
                //    RuleRegReplace e = (RuleRegReplace) this.childControl;
                //    e.enable();
                //    break;
                case RuleTypeReplace.Alias:
                    RuleReplace f = (RuleReplace) this.childControl;
                    f.enable();
                    break;
            }

            this.deaktivierenToolStripMenuItem.Visible = true;
            this.aktivierenToolStripMenuItem.Visible = false;

            this.core.applyRulesPreview();  // refresh preview
        }

        private void löschenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.ruleClass.dropRule();
        }

        private void btn_RuleCtrl_remove_Click(object sender, System.EventArgs e)
        {
            this.ruleClass.dropRule();
        }

        private void fancyCheckboxRuleEnabled_MouseEnter(object sender, System.EventArgs e)
        {
            fancyCheckboxRuleEnabled.Image = (cbRuleEnabledState.Checked) ? Properties.Resources.checkbox_checked_hover : Properties.Resources.checkbox_hover;
        }

        private void fancyCheckboxRuleEnabled_MouseLeave(object sender, System.EventArgs e)
        {
            fancyCheckboxRuleEnabled.Image = (cbRuleEnabledState.Checked) ? Properties.Resources.checkbox_checked : Properties.Resources.checkbox_unchecked;
        }

        private void fancyCheckboxRuleEnabled_MouseDown(object sender, MouseEventArgs e)
        {
            fancyCheckboxRuleEnabled.Image = (cbRuleEnabledState.Checked) ? Properties.Resources.checkbox_checked_mousedown : Properties.Resources.checkbox_mousedown;
        }

        private void fancyCheckboxRuleEnabled_MouseUp(object sender, MouseEventArgs e)
        {
            fancyCheckboxRuleEnabled.Image = (cbRuleEnabledState.Checked) ? Properties.Resources.checkbox_checked : Properties.Resources.checkbox_unchecked;
        }

        private void fancyCheckboxRuleEnabled_Click(object sender, System.EventArgs e)
        {
            cbRuleEnabledState.Checked = !cbRuleEnabledState.Checked;
            fancyCheckboxRuleEnabled.Image = (cbRuleEnabledState.Checked) ? Properties.Resources.checkbox_checked : Properties.Resources.checkbox_unchecked;

            this.childControl.Enabled = cbRuleEnabledState.Checked;
            this.ruleClass.enabled = cbRuleEnabledState.Checked;
        }
    }
}

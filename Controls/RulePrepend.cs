using SRSuite.Classes;
using System.Windows.Forms;

namespace SRSuite.Controls
{

    public partial class RulePrepend : UserControl
    {

        private Core core;
        public Rule rule;
        public RuleTypePrepend ruleType;
        public bool enabled;
        private bool textChanged = false;
        private bool textBox_PrependTouched = false;

        public RulePrepend()
        {
            InitializeComponent();
        }
        public RulePrepend(Core core, RuleTypePrepend ruleType, Rule rule)
        {
            this.core = core;
            this.rule = rule;
            this.ruleType = ruleType;
            this.enabled = rule.enabled;

            InitializeComponent();
        }

        private void applyRule(object sender, System.EventArgs e)
        {
            if (this.textChanged && this.textBox_PrependTouched)
            {
                this.core.applyRulesPreview();
                this.textChanged = false;
            }
        }

        public void enable()
        {
            this.enabled = true;
            this.textBox_RulePrepend_Prepend.Enabled = true;
        }

        public void disable()
        {
            this.enabled = false;
            this.textBox_RulePrepend_Prepend.Enabled = false;
        }

        private void textBox_RulePrepend_Prepend_TextChanged(object sender, System.EventArgs e)
        {
            this.textChanged = true;
            this.ruleType.Value = textBox_RulePrepend_Prepend.Text;
        }

        private void textBox_RulePrepend_Prepend_Enter(object sender, System.EventArgs e)
        {
            this.textBox_PrependTouched = true;
        }

        private void RulePrepend_SizeChanged(object sender, System.EventArgs e)
        {
            resizeChildControls();
        }

        private void resizeChildControls()
        {
            textBox_RulePrepend_Prepend.Width = this.Width - 6;
        }
    }
}

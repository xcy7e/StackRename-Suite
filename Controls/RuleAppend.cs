using SRSuite.Classes;
using System.Windows.Forms;

namespace SRSuite.Controls
{
    
    public partial class RuleAppend : UserControl
    {

        private Core core;
        public Rule rule;
        public RuleTypeAppend ruleType;
        public bool enabled;
        private bool textChanged = false;
        private bool textBox_AppendTouched = false;

        public RuleAppend(Core core, RuleTypeAppend ruleType, Rule rule)
        {
            this.core = core;
            this.rule = rule;
            this.ruleType = ruleType;
            this.enabled = rule.enabled;

            InitializeComponent();
        }

        private void applyRule(object sender, System.EventArgs e)
        {
            if (this.textChanged && this.textBox_AppendTouched)
            {
                this.core.applyRulesPreview();
                this.textChanged = false;
            }
        }

        public void enable()
        {
            this.enabled = true;
            this.textBox_RuleAppend_Append.Enabled = true;
        }

        public void disable()
        {
            this.enabled = false;
            this.textBox_RuleAppend_Append.Enabled = false;
        }

        private void textBox_RuleAppend_Append_TextChanged(object sender, System.EventArgs e)
        {
            this.textChanged = true;
            this.ruleType.Value = textBox_RuleAppend_Append.Text;
        }

        private void textBox_RuleAppend_Append_Enter(object sender, System.EventArgs e)
        {
            this.textBox_AppendTouched = true;
        }
    }
}

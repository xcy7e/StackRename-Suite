using SRSuite.Classes;
using System.Windows.Forms;

namespace SRSuite.Controls
{

    public partial class RuleReplace : UserControl
    {

        private Core core;
        public Rule rule;
        public RuleTypeReplace ruleType;
        public bool enabled;
        private bool textChanged = false;
        private bool textBox_ReplaceTouched = false;

        public RuleReplace(Core core, RuleTypeReplace ruleType, Rule rule)
        {
            this.core = core;
            this.rule = rule;
            this.ruleType = ruleType;
            this.enabled = rule.enabled;

            InitializeComponent();
        }

        private void applyRule(object sender, System.EventArgs e)
        {
            if (this.textChanged && this.textBox_ReplaceTouched)
            {
                this.core.applyRulesPreview();
                this.textChanged = false;
            }
        }

        public void enable()
        {
            this.enabled = true;
            this.textBox_RuleReplace_Search.Enabled = true;
            this.textBox_RuleReplace_Replace.Enabled = true;
        }

        public void disable()
        {
            this.enabled = false;
            this.textBox_RuleReplace_Search.Enabled = false;
            this.textBox_RuleReplace_Replace.Enabled = false;
        }

        private void textBox_RuleReplace_Search_TextChanged(object sender, System.EventArgs e)
        {
            this.textChanged = true;
            this.ruleType.Search = textBox_RuleReplace_Search.Text;
        }

        private void textBox_RuleReplace_Replace_TextChanged(object sender, System.EventArgs e)
        {
            this.textChanged = true;
            this.ruleType.Replace = textBox_RuleReplace_Replace.Text;
        }

        private void textBox_RuleReplace_Replace_Enter(object sender, System.EventArgs e)
        {
            this.textBox_ReplaceTouched = true;
        }
    }
}

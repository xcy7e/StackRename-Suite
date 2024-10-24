using SRSuite.Classes;
using System.Windows.Forms;

namespace SRSuite.Controls
{

    public partial class RuleNumbering : UserControl
    {

        private Core core;
        public Rule rule;
        public RuleTypeNumbering ruleType;
        public bool enabled;
        private bool ruleChanged = false;
        private bool textBox_NumberingTouched = false;

        public RuleNumbering(Core core, RuleTypeNumbering ruleType, Rule rule)
        {
            this.core = core;
            this.rule = rule;
            this.ruleType = ruleType;
            this.enabled = rule.enabled;

            InitializeComponent();

            toolTipPattern.SetToolTip(pictureBoxPatternHelp, "Legt fest, wie nummeriert werden soll.\nBsp: \"%nnn\" erzeugt eine mind. 3-Stellige Nummerierung mit führenden Nullen.");
            listBoxNbrType.SelectedIndex = 0;
        }

        private void applyRule(object sender, System.EventArgs e)
        {
            if (this.ruleChanged && this.textBox_NumberingTouched)
            {
                this.core.applyRulesPreview();
                this.ruleChanged = false;
            }
        }

        public void enable()
        {
            this.enabled = true;
            this.listBoxNbrType.Enabled = true;
            this.radioButtonNbrBefore.Enabled = true;
            this.radioButtonNbrAfter.Enabled = true;
            this.textBoxNbrPattern.Enabled = true;
        }

        public void disable()
        {
            this.enabled = false;
            this.listBoxNbrType.Enabled = false;
            this.radioButtonNbrBefore.Enabled = false;
            this.radioButtonNbrAfter.Enabled = false;
            this.textBoxNbrPattern.Enabled = false;
        }

        private void textBoxNbrPattern_Enter(object sender, System.EventArgs e)
        {
            this.textBox_NumberingTouched = true;
        }

        private void textBoxNbrPattern_TextChanged(object sender, System.EventArgs e)
        {
            this.ruleType.Pattern = textBoxNbrPattern.Text;
            this.ruleChanged = true;
        }

        private void radioButtonNbrBefore_CheckedChanged(object sender, System.EventArgs e)
        {
            radioButtonNbrAfter.Checked = false;
            this.ruleType.Append = false;
            this.ruleChanged = true;
        }

        private void radioButtonNbrAfter_CheckedChanged(object sender, System.EventArgs e)
        {
            radioButtonNbrBefore.Checked = false;
            this.ruleType.Append = true;
            this.ruleChanged = true;
        }
    }
}

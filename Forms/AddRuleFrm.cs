using SRSuite.Classes;
using System;
using System.Windows.Forms;

namespace SRSuite.Forms
{
    public partial class AddRuleFrm : Form
    {

        public Core core;

        public AddRuleFrm(Core core)
        {
            this.core = core;
            InitializeComponent();
        }

        public void confirm(string ruleTypeAlias)
        {
            this.core.addRule(ruleTypeAlias);

            this.Close();
        }

        public void cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rtReplace_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypeReplace.Alias);
        }

        private void btn_rtPrepend_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypePrepend.Alias);
        }

        private void btn_rtAppend_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypeAppend.Alias);
        }

        private void btn_rtNumbering_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypeNumbering.Alias);
        }

        private void btn_rtRegReplace_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypeRegReplace.Alias);
        }

        private void btn_rtRegRemove_Click(object sender, EventArgs e)
        {
            this.confirm(RuleTypeRegRemove.Alias);
        }
    }
}

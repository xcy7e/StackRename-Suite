using SRSuite.Controls;

namespace SRSuite.Classes
{
    /// <summary>
    /// Renaming Command based on a specific rule
    /// </summary>
    public class Rule
    {
        /// <param name="=ruleSetIndex">Type of the rule (replace, numbering, regex, ..)</param>
        public int ruleSetIndex;    // ruleSet index
        public int index;           // global rule index
        public RuleType type;
        public bool enabled;
        public int order;

        private Core core;
        public RuleCtrl control;

        /// <summary>
        /// Parent Rule Obj Class
        /// </summary>
        /// <param name="core"></param>
        /// <param name="ruleSetIndex">Index of the Rule's RuleSet</param>
        /// <param name="index">Absolute Index of the Rule over all RuleSets</param>
        /// <param name="type"></param>
        /// <param name="enabled"></param>
        /// <param name="order"></param>
        public Rule(Core core, int ruleSetIndex, int index, string type, bool enabled, int order)
        {
            this.core = core;

            this.ruleSetIndex = ruleSetIndex;
            this.index = index;
            this.type = this.newTypeInstance(type);
            this.enabled = enabled;
            this.order = order;

            this.createControl();
            this.control.groupBox_RuleWrapper.Text = this.type.getCaption();
        }

        private RuleType newTypeInstance(string ruleType)
        {
            switch (ruleType)
            {
                case RuleTypeAppend.Alias:
                    return new RuleTypeAppend();
                case RuleTypeNumbering.Alias:
                    return new RuleTypeNumbering();
                case RuleTypePrepend.Alias:
                    return new RuleTypePrepend();
                case RuleTypeRegRemove.Alias:
                    return new RuleTypeRegRemove();
                case RuleTypeRegReplace.Alias:
                    return new RuleTypeRegReplace();
                default:
                    return new RuleTypeReplace();   // fallback type
            }
        }

        private RuleCtrl createControl()
        {
            this.control = new RuleCtrl(this.core, this, this.type);
            return this.control;
        }

        /// <summary>
        /// Apply type-specific rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            return this.type.ApplyRule(str, i, itemIsFolder, renameFileExt);
        }

        public void dropRule()
        {
            this.core.dropRule(this.index);
        }

    }
}

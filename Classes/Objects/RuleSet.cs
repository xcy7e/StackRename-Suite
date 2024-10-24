using System.Collections.Generic;

namespace SRSuite.Classes
{
    /// <summary>
    /// Set of rules for renaming operation
    /// </summary>
    public class RuleSet
    {

        public int index;
        public Dictionary<int,Rule> rules;

        public RuleSet(int index)
        {
            this.index = index;
            this.rules = new Dictionary<int, Rule>();
        }
        
        public void addRule(Rule rule)
        {
            rule.ruleSetIndex = this.index;
            this.rules.Add(rule.index, rule);
        }
    
    }
}

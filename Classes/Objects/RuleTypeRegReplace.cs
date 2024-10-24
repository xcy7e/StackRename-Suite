
namespace SRSuite.Classes
{
    /// <summary>
    /// Regex replace Rule
    /// </summary>
    public class RuleTypeRegReplace : RuleType
    {

        public const string Alias = "rule_type.reg_replace";

        public const string Caption = "Regex (Ersetzen)";

        /// <param name="regex">Regex value</param>
        private string regex;
        /// <param name="mode">regex mode</param>
        private string mode;
        /// <param name="value">replace with</param>
        private string value;

        public RuleTypeRegReplace()
        {
            this.alias = Alias;
            this.caption = Caption;
        }

        public string Regex
        {
            get { return regex; }
            set { this.regex = value; }
        }

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string Mode
        {
            get { return mode; }
            set { this.mode = value; }
        }

        /// <summary>
        /// Apply Regex-Replace Rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public new string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            // @todo renameFileExt - berücksichtigen!
            if (this.regex == null || this.value == null)
            {
                return str;
            }

            return System.Text.RegularExpressions.Regex.Replace(str, this.regex, this.value);   // @todo regex options?
        }

    }
}

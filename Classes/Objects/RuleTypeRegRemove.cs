
namespace SRSuite.Classes
{
    /// <summary>
    /// Regex remove Rule
    /// </summary>
    public class RuleTypeRegRemove : RuleType
    {

        public const string Alias = "rule_type.reg_remove";

        public const string Caption = "Regex (Entfernen)";

        /// <param name="regex">regex</param>
        private string regex;
        /// <param name="mode">regex mode</param>
        private string mode;

        public RuleTypeRegRemove()
        {
            this.alias = Alias;
            this.caption = Caption;
        }

        public string Regex
        {
            get { return regex; }
            set { this.regex = value; }
        }

        public string Mode
        {
            get { return mode; }
            set { this.mode = value; }
        }

        /// <summary>
        /// Apply Regex-Remove Rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public new string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            // @todo renameFileExt - berücksichtigen!
            if (this.regex == null)
            {
                return str;
            }

            return System.Text.RegularExpressions.Regex.Replace(str, this.regex, "");   // @todo regex options?
        }

    }
}

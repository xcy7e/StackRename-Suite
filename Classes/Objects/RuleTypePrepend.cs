
namespace SRSuite.Classes
{
    /// <summary>
    /// Prepend text Rule
    /// </summary>
    public class RuleTypePrepend : RuleType
    {

        public const string Alias = "rule_type.prepend";

        public const string Caption = "Voranstellen";

        /// <param name="value">prepend text</param>
        private string value;

        public RuleTypePrepend()
        {
            this.alias = Alias;
            this.caption = Caption;
        }

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Apply Prepend Rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public override string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            if (this.Value == null)
            {
                return str;
            }
            return this.Value + str;
        }

    }
}

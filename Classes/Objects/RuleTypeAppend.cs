
namespace SRSuite.Classes
{
    /// <summary>
    /// Append text Rule
    /// </summary>
    public class RuleTypeAppend : RuleType
    {

        public const string Alias = "rule_type.append";

        public const string Caption = "Anhängen";

        /// <param name="value">append text</param>
        private string value;

        public RuleTypeAppend()
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
        /// Apply Append Rule
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

            if (!itemIsFolder && !renameFileExt && str.Contains("."))
            {
                // rename filename only (without extension)
                string fileExt = str.Substring(str.LastIndexOf("."));
                string fileName = str.Substring(0, str.LastIndexOf("."));

                return fileName + this.Value + fileExt;
            }


            return str + this.Value;
        }

    }
}

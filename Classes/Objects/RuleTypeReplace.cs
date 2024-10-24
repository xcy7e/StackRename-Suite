
namespace SRSuite.Classes
{
    /// <summary>
    /// Search-and-replace Rule
    /// </summary>
    public class RuleTypeReplace : RuleType
    {

        public const string Alias = "rule_type.replace";

        public const string Caption = "Suchen und Ersetzen";

        /// <param name="search">search for</param>
        private string search;
        /// <param name="replace">replace with</param>
        private string replace;

        public RuleTypeReplace()
        {
            this.alias = Alias;
            this.caption = Caption;
        }

        public string Search
        {
            get { return search; }
            set { search = value; }
        }

        public string Replace
        {
            get { return replace; }
            set { replace = value; }
        }

        /// <summary>
        /// Apply Search&Replace-Rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public override string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            if (this.search == null || this.replace == null)
            {
                return str;
            }

            if(!itemIsFolder && !renameFileExt && str.Contains("."))
            {
                // rename filename only (without extension)
                string fileExt = str.Substring(str.LastIndexOf("."));
                string fileName = str.Substring(0, str.LastIndexOf("."));

                return fileName.Replace(this.search, this.replace) + fileExt;
            }

            return str.Replace(this.search, this.replace);
        }

    }
}

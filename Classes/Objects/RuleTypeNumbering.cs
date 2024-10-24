
using System.Collections.Generic;
using System.Linq;

namespace SRSuite.Classes
{
    /// <summary>
    /// Numbering Rule
    /// </summary>
    public class RuleTypeNumbering : RuleType
    {

        public const string Alias = "rule_type.numbering";

        public const string Caption = "Nummerieren";

        /// <param name="PatternTranslation">Translate user given pattern to usable pattern</param>
        private static readonly Dictionary<char, char> PatternTranslation = new Dictionary<char, char>()
        {
            { 'n','D' },
            { 'x','X' },
        };

        /// <param name="append">true=append, false=prepend</param>
        private bool append;
        /// <param name="pattern">numbering pattern (e.g. "%nnn - " for "005 - ")</param>
        private string pattern;

        public RuleTypeNumbering()
        {
            this.alias = Alias;
            this.caption = Caption;
        }

        public bool Append
        {
            get { return append; }
            set { append = value; }
        }

        public string Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }

        /// <summary>
        /// Apply Numbering Rule
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If item to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        public override string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            if (this.pattern == null)
            {
                return str;
            }

            string n = this.CalculateNbr(i);

            if (!itemIsFolder && !renameFileExt && str.Contains(".") && append)
            {
                // exclude fileExt from numbering (append nbr after file's name)
                string fileExt = str.Substring(str.LastIndexOf("."));
                string fileName = str.Substring(0, str.LastIndexOf("."));

                return fileName + n + fileExt;
            }
            
            return (append) ? str + n : n + str;
        }

        private string CalculateNbr(int i)
        {
            string p = this.pattern.Replace("%", "");
            string pChar = this.getPatternChar(p);

            int decimalLength = i.ToString(pChar).Length + p.Length;

            return i.ToString(pChar + decimalLength.ToString());
        }

        /// <summary>
        /// Translate pattern characters to usable chars
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private string getPatternChar(string p)
        {
            char[] c = p.ToLower().ToCharArray();
            List<int> invalidIndicies = new List<int>();

            // Translate each char
            for (int key = 0; key < c.Length; ++key)
            {
                if(RuleTypeNumbering.PatternTranslation.TryGetValue(c[key], out char transChar))
                {
                    c[key] = transChar;
                } else
                {
                    // Invalid pattern character  - usually avoided / strip char
                    invalidIndicies.Add(key);
                }
            }

            string tPattern = c.ToString();

            // Remove invalid characters
            if(invalidIndicies.Count > 0)
            {
                foreach(int invI in invalidIndicies)
                {
                    tPattern.Remove(invI, 1);
                }
            }

            return this.flattenPattern(tPattern);
        }

        /// <summary>
        /// Reduce group of following of same characters to one of the given chars from string
        /// e.g. "ADDDXX" => "ADX"
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private string flattenPattern(string p)
        {
            var unique = new HashSet<char>(p);
            string fStr = "";

            foreach (char c in unique)
            {
                fStr += c.ToString();
            }

            return p;
        }

    }
}

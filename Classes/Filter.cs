using System.Collections.Generic;
using System.Linq;

namespace SRSuite.Classes
{
    /// <summary>
    /// Directory List Filter
    /// </summary>
    public class Filter
    {
        private MainFrm mainFrm;

        public List<string> hideFileEndings;

        public Filter(MainFrm mainFrm)
        {
            this.mainFrm = mainFrm;

            this.hideFileEndings = new List<string>();
        }

        /// <summary>
        /// Extract File endings from filter control
        /// </summary>
        /// <param name="fileEndings"></param>
        /// <returns></returns>
        public Filter setHideFileEndings(string fileEndings)
        {
            this.hideFileEndings = new List<string>();  // clear list
            if(fileEndings.Trim().Length > 0)
            {
                this.hideFileEndings = fileEndings.Split(',').Select(p =>
                "." + (p.ToLower()
                    .Replace('*', ' ')
                    .Replace('.', ' ')
                    .Trim())
                ).ToList(); // split, trim, unify format
            }

            return this;
        }

    }
}

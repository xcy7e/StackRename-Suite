
namespace SRSuite.Classes
{
    interface RuleTypeInterface
    {
        /// <summary>
        /// ApplyRule-Function pattern
        /// </summary>
        /// <param name="str">Elements name to wich to apply the rule to</param>
        /// <param name="i">Elements index in the preview list</param>
        /// <param name="itemIsFolder">If element to rename is of type directory</param>
        /// <param name="renameFileExt">Current RenameFileExt-Setting value</param>
        /// <returns></returns>
        string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false);
    }

    /// <summary>
    /// Renaming Rule Type Class
    /// </summary>
    public class RuleType : RuleTypeInterface
    {

        protected string alias;
        protected string caption;

        public string getAlias()
        {
            return this.alias;
        }

        public string getCaption()
        {
            return this.caption;
        }

        public virtual string ApplyRule(string str, int i, bool itemIsFolder = false, bool renameFileExt = false)
        {
            return str;
        }

    }
}

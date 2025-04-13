using System.Xml.Linq;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileleName)
        {
            if (!fileleName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}

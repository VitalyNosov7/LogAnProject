using System.Xml.Linq;

namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        public LogAnalyzer()
        {
        }

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("Имя файла должно быть задано");
            }

            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            WasLastFileNameValid = true;

            return true;
        }

        public bool IsValidLogFileName2(string fileName)
        {

            return manager.IsValid(fileName);

        }
    }
}

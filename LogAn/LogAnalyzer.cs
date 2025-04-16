namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileleName)
        {
            if (string.IsNullOrEmpty(fileleName))
            {
                throw new ArgumentException("Имя файла должно быть задано");
            }

            if (!fileleName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}

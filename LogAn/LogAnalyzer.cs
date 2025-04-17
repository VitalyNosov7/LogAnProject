namespace LogAn
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileleName)
        {
            WasLastFileNameValid = false;
            if (string.IsNullOrEmpty(fileleName))
            {
                throw new ArgumentException("Имя файла должно быть задано");
            }

            if (!fileleName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            WasLastFileNameValid = true;

            return true;
        }
    }
}

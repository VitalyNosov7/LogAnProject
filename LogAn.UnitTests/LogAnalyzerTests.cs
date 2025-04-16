using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LogAn.UnitTests
{

    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }


        [Test]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            LogAnalyzer la = MakeAnalyzer();
            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            StringAssert.Contains("Имя файла должно быть задано",
            ex.Message);
        }

            [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filelewithbadextension.foo");
            Assert.That(result,Is.False);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");
            Assert.That(result,Is.True);
        }
        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");
            Assert.That(result, Is.True);
        }
    }
}

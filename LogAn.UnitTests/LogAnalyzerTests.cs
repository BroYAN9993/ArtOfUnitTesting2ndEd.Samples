using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer = null;

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }

        [TestCase("filewithbadextension.foo", false)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        public void IsValidLogFileName_VariousExtension_CheckThem(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);
            Assert.AreEqual(expected, result);
        }

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            analyzer.IsValidLogFileName(file);
            Assert.AreEqual(expected, analyzer.WasLastFileNameValid);
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowsArgumentException()
        {
            LogAnalyzer analyzer = MakeAnalyzer();
            var ex = Assert.Catch<ArgumentException>(() => analyzer.IsValidLogFileName(string.Empty));
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }
    }
}

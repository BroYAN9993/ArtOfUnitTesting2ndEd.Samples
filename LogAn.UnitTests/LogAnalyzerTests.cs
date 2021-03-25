using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnTrue()
        {
            FakeExtensionManager fakeManager = new FakeExtensionManager();
            fakeManager.WillBeValid = true;
            ExtensionManagerFactory.SetManager(fakeManager);
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("wtf.wtf");
            Assert.True(result);
        }
    }
}

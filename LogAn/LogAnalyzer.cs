using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("LogAn.UnitTests")]
namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        internal LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidLogFileName(string fileName)
        {
            try
            {
                return manager.IsValid(fileName);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

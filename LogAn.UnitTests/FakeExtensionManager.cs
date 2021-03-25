using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    internal class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public Exception WillThrow = null;

        public bool IsValid(string fileName)
        {
            if (WillThrow != null)
            {
                throw WillThrow;
            }
            return WillBeValid;
        }
    }
}

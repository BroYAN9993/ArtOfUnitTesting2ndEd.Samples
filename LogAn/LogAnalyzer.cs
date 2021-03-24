﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid;

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }
            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            WasLastFileNameValid = true;
            return true;
        }
    }
}
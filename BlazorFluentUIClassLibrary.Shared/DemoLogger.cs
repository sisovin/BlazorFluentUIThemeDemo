using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentUIClassLibrary.Shared
{
    public delegate void OnLogHandler(string text);
    public static class DemoLogger
    {
        public static event OnLogHandler? OnLog;
        public static void WriteLine(string text)
        {
            OnLog?.Invoke(text);
        }
    }
}

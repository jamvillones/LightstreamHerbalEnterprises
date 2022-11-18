using Lightstream.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lightstream

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            var process = PriorProcess();
            if (process is not null)
            {
                var windowHandle = process.MainWindowHandle;
                ShowWindow(windowHandle, 9);
                ShowWindow(windowHandle, 5);
                SetForegroundWindow(windowHandle);
                //window.BringToFront();
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Shell());
        }        

        public static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
    }
}
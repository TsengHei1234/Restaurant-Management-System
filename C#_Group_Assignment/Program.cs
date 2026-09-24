using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDatabaseDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin());
        }

        private static void ConfigureDatabaseDirectory()
        {
            string executableDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(executableDirectory, "..", ".."));
            string[] candidates = { projectDirectory, executableDirectory, Directory.GetCurrentDirectory() };

            foreach (string candidate in candidates)
            {
                if (File.Exists(Path.Combine(candidate, "Database.mdf")))
                {
                    AppDomain.CurrentDomain.SetData("DataDirectory", candidate);
                    return;
                }
            }

            throw new FileNotFoundException("Database.mdf was not found in the project directory.");
        }
    }
}

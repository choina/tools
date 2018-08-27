using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] folders = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Thunderbird\\Profiles\\", "*.default");
            string defaultprofile = folders[0];
            defaultprofile += @"\prefs.js";
            File.AppendAllLines(defaultprofile, new[] { "user_pref(\"mail.purge.ask\", false);" });
        }
    }
}

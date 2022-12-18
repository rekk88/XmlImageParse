using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlImageParse.XMLParse.Helpers
{
    public static class Helpers
    {
        public static string getProjectDirectory()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            if (dir.Contains("bin"))
            {
                dir = dir.Substring(0, dir.IndexOf("bin"));
            }
            return dir;
        }
    }
}

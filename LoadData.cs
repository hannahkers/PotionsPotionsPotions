using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionsPotionsPotions
{
    class LoadData
    {
        public static string[] GetExternalText(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}

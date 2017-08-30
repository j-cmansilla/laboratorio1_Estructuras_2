using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class ControlDeArchivos
    {
        public static string[] OpenFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllLines(FilePath);
            }
            else
            {
                string[] nuevo = new string[1];
                File.WriteAllLines(FilePath, nuevo);
                return File.ReadAllLines(FilePath);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents
{

    internal class FindFiles(string dirName, int searchDepth)
    {
        public delegate void Files(string[]? files);

        public event Files? OnFound;


        public void Find()
        {
            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            string[] directories = Directory.GetDirectories(dirName);


            foreach (string dir in directories)
            {
 
                try
                {
                    string[]? files = Directory.GetFiles(dir);
                    if (files.Length != null)
                    {
                        OnFound(files);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Отказано в доступе");
                }

            }
        }
    }
}

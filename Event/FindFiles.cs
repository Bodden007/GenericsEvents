using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.Event{
    internal class FindFiles
    {
        public string DirName { get; set; }
        public string FileName { get; set; }
        public FindFiles(string dirName, string fileName)
        {
            DirName = dirName;
            FileName = fileName;
        }
        public delegate void EventHandler(object? sender, FileArgs e);

        public event EventHandler? FileFound;

        /// <summary>
        /// Поиск файла *.log
        /// </summary>
        public void Find()
        {
            var bufFiles = Directory.GetFiles(DirName);

            //NOTE поиск файла
            foreach (var dir in bufFiles)
            {
                if (dir.IndexOf(FileName) > 1)
                {
                    string[] splitFileName = dir.Split('\\');

                    FileFound?.Invoke(this, new FileArgs(DirName, splitFileName.Last()));
                }
            }            
        }
    }
}
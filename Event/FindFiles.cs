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
        public FindFiles(string dirName)
        {
            DirName = dirName;
        }
        public delegate void EventHandler(object? sender, FileArgs e);

        public event EventHandler? FileFound;

        /// <summary>
        /// Поиск файла
        /// </summary>
        public void Find()
        {
            List<string> directories = new List<string>();

            var bufDirectories = Directory.GetDirectories(DirName);

            var bufFiles = Directory.GetFiles(DirName);

            var subStr = ".log";

            //NOTE первый проход по диску
            foreach (var dir in bufDirectories)
            {
                directories.Add(dir);
            }

            //NOTE проход по каталогам. Рекурсивный цикл
            while (!Console.KeyAvailable)
            {

                //NOTE поиск по файлам
                foreach (var dir in bufFiles)
                {

                    //Console.WriteLine($"Files: {dir}");
                    try
                    {
                        if (dir.IndexOf(subStr) > 1)
                        {
                            string[] splitFileName = dir.Split('\\');

                            FileFound?.Invoke(this, new FileArgs(DirName, splitFileName.Last()));
                        }
                    }
                    catch (Exception ex)
                    {
                        //FIXME закоментировать
                        //----------------------------------------------
                        //Console.WriteLine($"{dir}  Отказано в доступе");
                        //----------------------------------------------
                    }
                }

                Array.Clear(bufFiles);

                //NOTE следующий проход по директориям, если есть директории
                try
                {
                    if (directories.Count > 0)
                    {
                        DirName = directories[0];

                        bufDirectories = Directory.GetDirectories(DirName);

                        bufFiles = Directory.GetFiles(DirName);

                        directories.RemoveAt(0);
                    }
                }
                catch (Exception ex)
                {
                    //FIXME закоментировать
                    //---------------------------------------------------------
                    //Console.WriteLine($"{directories[0]}  Отказано в доступе");
                    //---------------------------------------------------------
                    directories.RemoveAt(0);
                }

                if (Console.KeyAvailable)
                {
                    Console.WriteLine("The program was stopped ");
                    break;
                }
            }
        }
    }
}
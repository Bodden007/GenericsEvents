using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.Event
{

    internal class FindFiles
    {
        public string DirName {  get; set; }
        public FindFiles(string dirName)
        {
            DirName = dirName;
        }
        public delegate void EventHandler(object? sender, FileArgs e);

        public event EventHandler? FileFound;


        public void Find()
        {
            var num = 0;            

            List<string> directories = new List<string>();

            var bufDirectories = Directory.GetDirectories(DirName);

            var bufFiles = Directory.GetFiles(DirName);

            var subStr = ".log";

            foreach (var dir in bufDirectories)
            {
                directories.Add(dir);
            }            

            foreach (var dir in bufFiles)
            {

                Console.WriteLine($"Files: {dir}");
                if (dir.IndexOf(subStr) > 1)
                {
                    Console.WriteLine($"Обнаружен {subStr}");
                }
                //Console.WriteLine($"Х з {dir.IndexOf(subStr)}");
            }

            #region
            //while (!Console.KeyAvailable)
            //{
            //    Thread.Sleep(1000);


            //    if (num == 5)
            //    {
            //        var mes = "привет";
            //        FileFound(this, new FileArgs(mes));
            //        break;
            //    }

            //    if (Console.KeyAvailable)
            //    {
            //        Console.WriteLine("The program was stopped ");
            //        break;
            //    }

            //    num++;

            //    Console.WriteLine($"Number {num}");
            //}
            #endregion
        }
    }
}
//Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

//string[] directories = Directory.GetDirectories(dirName);


//foreach (string dir in directories)
//{

//    try
//    {
//        string[]? files = Directory.GetFiles(dir);
//        if (files.Length != null)
//        {
//            OnFound(files);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Отказано в доступе");
//    }

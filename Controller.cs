using GenericsEvents.Event;
using GenericsEvents.ExtensionGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents
{
    internal class Controller
    {
        public string DirName {  get; set; }
        List<object> ListTest;
        public Controller(List<object> listTest, string dirName)
        {
            DirName = dirName;
            ListTest = listTest;
        }
        public void RunController()
        {
            var maxNumber = ListTest.GetMax(ExtensionClass.ConvertToNumber);

            Console.WriteLine($"The maximum number {maxNumber}");

            FindFiles findFiles = new FindFiles(DirName);

            Console.WriteLine("");
            Console.WriteLine("Finding files...");

            findFiles.FileFound += MessageController;
            findFiles.Find();
            findFiles.FileFound -= MessageController;
        }

        public static void MessageController(object sender, FileArgs e)
        {
            Console.WriteLine($"Directory: {e.DirectoryName}   file found: {e.FileName}");

        }
    }
}

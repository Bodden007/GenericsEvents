using GenericsEvents.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents
{
    internal class Controller
    {
        public void RunController()
        {
            var dirName = "C:\\";
            //NOTE Test object
            //FIXME раскоментировать
            //---------------------------------------------------------
            //List<object> ts = new List<object>() { 1, 2, 3, 4, 5 };

            //var maxNumber = ts.GetMax(ExtensionClass.ConvertToNumber);

            //Console.WriteLine($"The maximum number {maxNumber}");
            //---------------------------------------------------------

            //FIXME Удалить
            //-------------------------------------------------------                       

            //List<string> directories = new List<string>() { "A", "B", "C", "D" };

            //Console.WriteLine($"Элемент 1 до удаления: {directories[0]}, элементов: {directories.Count} ");

            //directories.RemoveAt(0);

            //Console.WriteLine($"Элемент 1 после удаления: {directories[0]}, элементов: {directories.Count}");

            //-------------------------------------------------------------------------------------------------

            FindFiles findFiles = new FindFiles(dirName);
            findFiles.FileFound += MessageController;
            findFiles.Find();
            findFiles.FileFound -= MessageController;

        }



        public static void MessageController(object sender, FileArgs e)
        {
            Console.WriteLine($"File: {e.FileName}");

        }
    }
}

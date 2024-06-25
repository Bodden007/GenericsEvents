using GenericsEvents.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.ExtensionGeneric
{
    internal class Controller
    {
        public void RunControllerAsync()
        {
            //NOTE Test object
            //FIXME раскоментировать
            //---------------------------------------------------------
            //List<object> ts = new List<object>() { 1, 2, 3, 4, 5 };

            //var maxNumber = ts.GetMax(ExtensionClass.ConvertToNumber);

            //Console.WriteLine($"The maximum number {maxNumber}");
            //---------------------------------------------------------

            NumberFindes numberFindes = new NumberFindes();

            numberFindes.FileFound += StopController;

            numberFindes.Run();

            //numberFindes.FileFound -= StopController;
            //await Task.Run(() => { numberFindes.Run(); });

            //ConsoleKeyInfo key = Console.ReadKey();

            //if (key.Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("Press to button enter for exit");
            //    return;
            //}

        }



        public static void StopController(object sender, FileArgs e)
        {
            Console.WriteLine(sender + $"  number {e.FileName}");

            //Console.WriteLine("Press to button enter for exit");
        }
    }
}

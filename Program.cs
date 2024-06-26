using System.Reflection;


namespace GenericsEvents
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            controller.RunController();

            //var dirName = "C:\\";
            //var searchDepth = 3;
            //FindFiles findFiles = new FindFiles(dirName, searchDepth);

            ////FIXME раскоментировать
            ////-----------------------------
            //findFiles.OnFound += Message;
            ////-----------------------------
            //findFiles.Find();
        }

        /// <summary>
        /// Метод обработчика событий
        /// </summary>
        /// <param name="files"></param>
        //public static void Message(string[]? files)
        //    {
        //        Console.WriteLine($"Нашел : {files.Count()}");
        //    }

    }
}

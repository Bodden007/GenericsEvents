using System.Reflection;


namespace GenericsEvents
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //NOTE Test the directory
            var dirName = "C:\\";

            //NOTE Test for file name
            var fileName = ".log";

            //NOTE Test object
            List<object> listTs = new List<object>() { 1, 2, 3, 4, 5 };

            Controller controller = new Controller(listTs, dirName, fileName);

            controller.RunController();
        }

    }
}

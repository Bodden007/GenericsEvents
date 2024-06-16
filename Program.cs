using System.Reflection;

namespace GenericsEvents
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //NOTE Тестовый объект
            List<object> ts = new List<object>() { 1, 2, 3 };

            //NOTE Вызов делегата обработки чисел
            GetMax(ts,ConvertToNumber);   

            var dirName = "C:\\";
            var searchDepth = 3;
            FindFiles findFiles = new FindFiles(dirName, searchDepth);

            //FIXME раскоментировать
            //-----------------------------
            findFiles.OnFound += Message;            
            //-----------------------------
            findFiles.Find();
        }

        /// <summary>
        /// Метод поиска максимального числа в коллекции
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ConvertToNumber"></param>
        public static void GetMax(List<object> list, Func<List<object>, List<float>> ConvertToNumber)
        {
            float maxNumber = ConvertToNumber(list).Max();

            Console.WriteLine($"Максимальное число коллекции  {maxNumber}");
        }

        /// <summary>
        /// Метод конвертации из Object to float
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<float> ConvertToNumber(List<object> list)
        {
            List<float> result = new List<float>();

            foreach (object obj in list)
            {
                result.Add(Convert.ToSingle(obj));
                Console.WriteLine(obj);
            }
            return result;
        }

        /// <summary>
        /// Метод обработчика событий
        /// </summary>
        /// <param name="files"></param>
        public static void Message(string[]? files)
        {
            Console.WriteLine($"Нашел : {files.Count()}");
        }
    }
}

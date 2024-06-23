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
            //GetMax(ts, ConvertToNumber);

            //object data = 3;

            Console.WriteLine(GetMax(ts, ConvertToNumber));
            Console.ReadLine();

            //var rezult = ts.GetMax(data, );

            //var dirName = "C:\\";
            //var searchDepth = 3;
            //FindFiles findFiles = new FindFiles(dirName, searchDepth);

            ////FIXME раскоментировать
            ////-----------------------------
            //findFiles.OnFound += Message;
            ////-----------------------------
            //findFiles.Find();
        }
        public static float GetMax(List<object> list, Func<List<object>, List<float>> ConvertToNumber)
        {
            //List<object> list

            //float maxNumber = ConvertToNumber(collection).Max();
            object num = 5;

            float maxNumber = ConvertToNumber(list).Max();
            //float data = ConvertToNumber(num);

            //ConvertToNumber(data);

            //T t = ConvertToNumber(data);

            //Console.WriteLine($"Максимальное число коллекции  {maxNumber}");

            return maxNumber;

        }
        public static List<float> ConvertToNumber(List<object> list)
        {
            List<float> result = new List<float>();

            foreach (object obj in list)
            {
                result.Add(Convert.ToSingle(obj));
                //Console.WriteLine(obj);
            }

            //float rezult = Convert.ToSingle(num);

            return result;
        }


        /// <summary>
        /// Метод конвертации из Object to float
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>


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

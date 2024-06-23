using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents
{
    public static class ExtensionClass
    {
        public static float GetMax(this List<object> list, Func<List<object>, List<float>> convertToNumber)
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
    }
}

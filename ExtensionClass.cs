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
        public static T GetMax<T>(this List<T> list, Func<T, float> convertToNumber) where T : class/*, new()*/
        {
            //List<object> list

            //float maxNumber = ConvertToNumber(collection).Max();
            //object num = 5;

            //List<object> listObj = list.Cast<object>().ToList();

            List<float> floats = new List<float>();

            foreach (var item in list)
            {
                floats.Add(convertToNumber(item));

            }

            //listObj = list.Cast<object>;

            var maxNumber = floats.Max();

            //float maxNumber = convertToNumber(list).Max();

            //float data = ConvertToNumber(num);

            //ConvertToNumber(data);            

            //Console.WriteLine($"Максимальное число коллекции  {maxNumber}");

            return (T)Convert.ChangeType(maxNumber, typeof(T));

        }

        public static float ConvertToNumber(object data)
        {
            //List<float> result = new List<float>();

            //foreach (object obj in list)
            //{
            //    result.Add(Convert.ToSingle(obj));
            //    //Console.WriteLine(obj);
            //}

            float result = Convert.ToSingle(data);

            return result;
        }
    }
}
//public static T GetMax<T>(this List<T> list, Func<List<T>, List<float>> convertToNumber) where T : class/*, new()*

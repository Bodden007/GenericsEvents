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
        public static T GetMax<T>(this List<T> list, Func<List<object>, List<float>> convertToNumber) where T : class, new()
        {
            //List<object> list

            //float maxNumber = ConvertToNumber(collection).Max();
            object num = 5;

            List<object> listObj = list.Cast<object>().ToList();

            //foreach (var item in list)
            //{
            //    listObj.Add(Convert.)

            //}

            //listObj = list.Cast<object>;

            float maxNumber = convertToNumber(listObj).Max();



            //float data = ConvertToNumber(num);

            //ConvertToNumber(data);

            

            //Console.WriteLine($"Максимальное число коллекции  {maxNumber}");

            return (T)Convert.ChangeType(maxNumber, typeof(T));

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

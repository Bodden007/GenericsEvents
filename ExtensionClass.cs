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
        //public static T GetMax<T>(this IEnumerable collection, Func<T, float> сonvertToNumber ) where T : class
        //{
        //    //List<object> list

        //    //float maxNumber = ConvertToNumber(collection).Max();
        //    object num = 5;

        //    float  data = ConvertToNumber(num);

        //    ConvertToNumber(data);

        //    //T t = ConvertToNumber(data);

        //    //Console.WriteLine($"Максимальное число коллекции  {maxNumber}");

        //    return t;

        //}

        public static float ConvertToNumber(object num)
        {
            //List<float> result = new List<float>();

            //foreach (object obj in list)
            //{
            //    result.Add(Convert.ToSingle(obj));
            //    Console.WriteLine(obj);
            //}

            float rezult = Convert.ToSingle(num);

            return rezult;
        }
    }
}

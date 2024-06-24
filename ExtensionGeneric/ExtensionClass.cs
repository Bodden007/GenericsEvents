using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.ExtensionGeneric
{
    public static class ExtensionClass
    {
        /// <summary>
        /// Метод поиска максимального числа коллекции
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="convertToNumber"></param>
        /// <returns></returns>
        public static T GetMax<T>(this List<T> list, Func<T, float> convertToNumber) where T : class
        {
            List<float> floats = new List<float>();

            foreach (var item in list)
            {
                floats.Add(convertToNumber(item));
            }

            var maxNumber = floats.Max();

            return (T)Convert.ChangeType(maxNumber, typeof(T));

        }
        /// <summary>
        /// Метод конвертации значения в тип float
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static float ConvertToNumber(object data)
        {
            float result = Convert.ToSingle(data);

            return result;
        }
    }
}
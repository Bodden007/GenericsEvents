using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.ExtensionGeneric
{
    internal class Controller
    {
        public void RunController()
        {
            List<object> ts = new List<object>() { 1, 2, 3, 4, 5 };

            var maxNumber = ts.GetMax(ExtensionClass.ConvertToNumber);

            Console.WriteLine($"The maximum number {maxNumber}");

        }
    }
}

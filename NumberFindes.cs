using GenericsEvents.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents
{
    internal class NumberFindes
    {
        public delegate void EventHandler(object? sender, FileArgs e);

        public event EventHandler? FileFound;

        public void Run()
        {
            var num = 0;

            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);

                if (num == 5)
                {                              
                    FileFound(this, new FileArgs(num));
                    break;
                }

                if (Console.KeyAvailable)
                {
                    Console.WriteLine("The program was stopped ");
                    break;
                }

                num++;

                Console.WriteLine($"Number {num}");
            }
        }

    }
}

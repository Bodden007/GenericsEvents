using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEvents.Event
{
    internal class FileArgs : EventArgs
    {
        public int FileName { get; set; }
        public FileArgs(int fileName)
        {
            FileName = fileName;
        }
    }
}

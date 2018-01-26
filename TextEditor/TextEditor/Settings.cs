using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    abstract class Settings
    {
        static double opacity;
        public static double Opacity { get => opacity; set => opacity = value; }
    }
}

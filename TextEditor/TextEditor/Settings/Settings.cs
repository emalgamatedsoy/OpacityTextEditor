using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Settings
{
    class Settings
    {
        double opacity;

        public Settings() => opacity = 1;
        public double GetOpacity() => opacity;

        public void SetOpacity(double opacity)
        {
            if (opacity <= 1.0 && opacity > 0.0)
                this.opacity = opacity;
        }
    }
}

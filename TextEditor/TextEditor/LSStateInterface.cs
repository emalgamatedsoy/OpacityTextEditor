using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    interface LSStateInterface
    {
        void LoadTextFile();
        void SaveTextFile(String text);
        Boolean IsLoadedState();
    }
}

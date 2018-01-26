using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    class Save : LSStateInterface
    {
        public Save() { }

        public bool IsLoadedState()
        {
            throw new NotImplementedException();
        }

        public void LoadTextFile()
        {
            //not implemented
            return;
        }

        public void SaveTextFile(String text)
        {
            try
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "Text File (*.txt)|*.txt";
                s.DefaultExt = "txt";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    if (s.FileName.Contains(".txt"))
                    {
                        if (text != null)
                        {
                            File.WriteAllText(s.FileName, text);
                        }
                    }
                    else
                        MessageBox.Show("Save only allows text files in format .txt");
                }
            }
            catch (System.IO.FileNotFoundException) { }
        }
        
    }
}

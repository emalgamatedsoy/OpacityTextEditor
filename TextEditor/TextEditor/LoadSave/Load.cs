using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor.LoadSave
{
    class Load : LSStateInterface
    {
        String text;
        Boolean loadState;

        public Load()
        {
            text = "";
            loadState = false;
        }

        public void ResetText()
        {
            text = "";
        }

        public bool IsLoadedState()
        {
            return loadState;            
        }

        public void LoadTextFile()
        {
            try
            {
                ResetText();
                OpenFileDialog d = new OpenFileDialog();
                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.Contains(".txt"))
                    {
                        using (StreamReader sr = new StreamReader(d.FileName))
                        {
                            text = sr.ReadToEnd();
                        }
                        loadState = true;
                    }

                }
                else
                    loadState = false;
                
                
            }
            catch (System.IO.FileNotFoundException) { }
        }

        public void SaveTextFile(String text)
        {
            //not implemented.
            return;
        }

        public String GetText()
        {
            return text;
        }

        public Boolean GetLoadState()
        {
            return loadState;
        }
    }
}

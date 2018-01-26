using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        private Load load;
        private Save save;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load = new Load();
            save = new Save();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TextInstance.text = RichTextEditor.Text;

            try
            {
                save.SaveTextFile(TextInstance.text);
            }
            catch (ArgumentNullException) { }
                
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            load.LoadTextFile();
            if (load.GetLoadState())
                TextInstance.text = load.GetText();

            RichTextEditor.Text = TextInstance.text;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsEditor settings = new SettingsEditor();
            settings.ShowDialog();
            Opacity = Settings.Opacity;
        }

    }
}

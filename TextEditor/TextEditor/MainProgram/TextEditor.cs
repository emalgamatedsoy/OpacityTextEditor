using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.LoadSave;
using TextEditor.Settings;
using TextEditor.ModelEditors;

namespace TextEditor.Main
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

        private void SaveTextDoc()
        {
            TextInstance.text = RichTextEditor.Text;

            try
            {
                save.SaveTextFile(TextInstance.text);
            }
            catch (ArgumentNullException) { }

        }

        private void LoadTextDoc()
        {
            load.LoadTextFile();
            if (load.GetLoadState())
                TextInstance.text = load.GetText();

            RichTextEditor.Text = TextInstance.text;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveTextDoc();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadTextDoc();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsEditor settings = new SettingsEditor();
            settings.ShowDialog();
            this.Opacity = settings.GetSettingOpacity();

        }
        
        private void TextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
                LoadTextDoc();
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                SaveTextDoc();
        }

    }
}

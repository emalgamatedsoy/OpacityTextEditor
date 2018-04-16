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
using TextEditor.ModelObj;

namespace TextEditor.Main
{
    public partial class TextEditor : Form
    {
        private Load load;
        private Save save;
        /// <summary>
        /// Creates object type TextEditor
        /// it is of object-type form.
        /// </summary>
        public TextEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on form load, execute. Create load and save object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEditorFormLoad(object sender, EventArgs e)
        {
            load = new Load();
            save = new Save();
        }

        /// <summary>
        /// use the save object, and save the string from
        /// the rich text editor from the save function in the save object.
        /// </summary>
        private void SaveTextDoc()
        {
            TextEditorModObj.text = RichTextEditor.Text;
            try
            {
                save.SaveTextFile(TextEditorModObj.text);
            }
            catch (ArgumentNullException) { }

        }

        /// <summary>
        /// load the text document.
        /// if the load state is good, then load the text..
        /// load the text file into the rich text editor.
        /// </summary>
        private void LoadTextDoc()
        {
            load.LoadTextFile();
            if (load.GetLoadState())
                TextEditorModObj.text = load.GetText();

            RichTextEditor.Text = TextEditorModObj.text;
        }

        /// <summary>
        /// when the save button is click, 
        /// call a composite function to SaveTextDoc()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveTextDoc();
        }

        /// <summary>
        /// when the load button is clicked,
        /// call a composite fucntion to LoadTextDoc()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// On key down event (ctrl + o) && (ctrl + s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
                LoadTextDoc();
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                SaveTextDoc();
        }

    }
}

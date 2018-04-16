using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Settings
{
    public partial class SettingsEditor : Form
    {
        Settings setting;

        /// <summary>
        /// create the settings editor.
        /// and initialize the new setting.
        /// </summary>
        public SettingsEditor()
        {
            InitializeComponent();
            setting = new Settings();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            setting.SetOpacity(((double)OpacityBar.Value) / 10);
            Close();
        }

        public double GetSettingOpacity() => setting.GetOpacity();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextEditor
{
    class EditorForm
    {
        private RichTextBox rtb;
        List<Button> buttons = new List<Button>();
        int buttonCount;

        EditorForm(RichTextBox rtb, int buttonCount)
        {
            this.rtb = rtb;
            createButtons(buttonCount);
            this.buttonCount = buttonCount;
        }

        private void createButtons(int buttonCount) 
        {
            for (int i = 0; i < buttonCount; i++)
            {
                buttons.Add(new Button());
            }
        }

        public Button GetButton(int i)
        {
            if (buttons.ElementAt(i) == null)
                throw new NullReferenceException("Button not found");
            else
                return buttons.ElementAt(i);
        }

        public RichTextBox GetRichTextBox()
        {
            return rtb;
        }
    }
}

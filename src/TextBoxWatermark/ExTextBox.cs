using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace TextBoxWatermark
{
    public class ExTextBox : TextBox
    {
        string hint;
        [DefaultValue("")]
        public string Hint
        {
            get { return hint; }
            set { hint = value; this.Invalidate(); }
        }

        Color hintColor = SystemColors.GrayText;
        public Color HintColor
        {
            get { return hintColor; }
            set { hintColor = value; Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                if (!this.Focused && string.IsNullOrEmpty(this.Text)
                    && !string.IsNullOrEmpty(this.Hint))
                {
                    using (var g = this.CreateGraphics())
                    {
                        TextRenderer.DrawText(g, this.Hint, this.Font,
                            this.ClientRectangle, this.HintColor, this.BackColor,
                             TextFormatFlags.Top | TextFormatFlags.Left);
                    }
                }
            }
        }
        private bool ShouldSerializeHintColor()
        {
            return HintColor != SystemColors.GrayText;
        }
        private void ResetHintColor()
        {
            HintColor = SystemColors.GrayText;
        }
    }

}

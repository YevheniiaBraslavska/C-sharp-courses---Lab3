using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.Lab3;
using System.Windows.Forms;

namespace SimCorp.IMS.Lab3 {
    public class WinLogOutput : IOutput {
        private RichTextBox _vTextBox { get; }

        public WinLogOutput(RichTextBox textbox) {
            _vTextBox = textbox;
        }

        public void Write(string text) {
            _vTextBox.Text += text;
        }

        public void WriteLine(string text) {
            _vTextBox.Text += text + "\n";
        }

        public void Clean() {
            _vTextBox.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.Lab3;

namespace WinFormsApp {
    class WinLogOutput : IOutput {
        private IWinAppLog WinForm { get; }

        public WinLogOutput(IWinAppLog winForm) {
            WinForm = winForm;
        }

        public void Write(string text) {
            WinForm.LogText += text;
        }

        public void WriteLine(string text) {
            WinForm.LogText += text + "\n";
        }

        public void Clean() {
            WinForm.LogText = "";
        }
    }
}

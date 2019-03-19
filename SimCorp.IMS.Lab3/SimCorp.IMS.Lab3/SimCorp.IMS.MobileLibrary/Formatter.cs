using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobileLibrary {
    public class MessageFormatter {
        public delegate string FormatDelegate(string text);

        public FormatDelegate Formatter;

        public void SetFormat(FormatDelegate del) {
            Formatter = del;
        }

        public bool NullFormatter() {
            return Formatter == null;
        }

        public void ClearFormat() {
            Formatter = null;
        }
    }
}

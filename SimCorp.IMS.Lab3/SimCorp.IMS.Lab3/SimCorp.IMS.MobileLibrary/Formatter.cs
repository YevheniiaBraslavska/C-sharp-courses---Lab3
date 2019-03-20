using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobileLibrary {
    public class MessageFormatter {
        public delegate string FormatHandler(string text);

        public FormatHandler Formatter;

        public void SetFormat(FormatHandler del) {
            Formatter = del;
        }

        public bool NullFormatter() {
            return Formatter == null;
        }

        public void ClearFormat() {
            Formatter = null;
        }

        public static string StartWithTime(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        public static string EndWithTime(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        public static string LowerCase(string message) {
            return message.ToLower();
        }

        public static string UpperCase(string message) {
            return message.ToUpper();
        }

        public static string Custom(string message) {
            var charArray = message.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

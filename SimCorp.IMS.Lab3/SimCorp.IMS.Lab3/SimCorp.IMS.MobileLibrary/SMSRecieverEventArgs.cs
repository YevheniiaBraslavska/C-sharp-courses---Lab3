using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobileLibrary {
    public class SMSRecieverEventArgs : EventArgs {
        public string Message { get; set; }

        public SMSRecieverEventArgs(string message) {
            Message = message;
        }
    }
}

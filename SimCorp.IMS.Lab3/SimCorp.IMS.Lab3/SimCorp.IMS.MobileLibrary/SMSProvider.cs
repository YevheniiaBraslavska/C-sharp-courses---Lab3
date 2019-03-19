using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Lab3 {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSReceived;

        public SMSProvider(SMSRecievedDelegate del) {
            SMSReceived += del;
        }

        public void RaiseSmsRecievedEvent(string message) {
            SMSReceived?.Invoke(message);
        }
    }
}

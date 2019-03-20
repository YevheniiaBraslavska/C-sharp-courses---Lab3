using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobileLibrary;

namespace SimCorp.IMS.Lab3 {
    public class SMSProvider {
        public event EventHandler<SMSRecieverEventArgs> SMSRecieved;

        public void RaiseSmsRecievedEvent(object sender, SMSRecieverEventArgs args) {
            SMSRecieved?.Invoke(sender, args);
        }
    }
}

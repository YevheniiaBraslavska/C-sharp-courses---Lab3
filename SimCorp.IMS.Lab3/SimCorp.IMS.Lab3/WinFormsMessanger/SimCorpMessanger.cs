using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.Lab3;
using SimCorp.IMS.MobileLibrary;
using SimCorp.IMS.WinFormApp;

namespace SimCorp.IMS.WinFormsMessanger {
    public partial class SimCorpMessanger : Form {
        public SimCorpMessanger() {
            InitializeComponent();
            _vMobile.AddMessanger(PushMessage);
            AddFormatTypesToComboBox();
            _vOutput = new WinLogOutput(MessageRichBox);
        }

        private readonly SimCorpMobile _vMobile = new SimCorpMobile();
        private int _vMessagecounter = 0;
        private readonly MessageFormatter _vFormatter = new MessageFormatter();
        private readonly IOutput _vOutput;

        private void SMSPushTimer_Tick(object sender, EventArgs e) {
            _vMessagecounter += 1;
            OnSmsRecieved(this, new SMSRecieverEventArgs(GenMessage()));
        }

        private void FormatTypesBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetFormatter();
        }

        public void OnSmsRecieved(object sender, SMSRecieverEventArgs args) {
            if (InvokeRequired) {
                Invoke(new EventHandler<SMSRecieverEventArgs>(OnSmsRecieved), sender, args);
            }
            _vMobile.SmsProvider.RaiseSmsRecievedEvent(sender, args);
        }

        private string GenMessage() {
            return "Message " + _vMessagecounter;
        }

        private void PushMessage(object sender, SMSRecieverEventArgs args) {
            var formattedstring = _vFormatter.NullFormatter() ? args.Message : _vFormatter.Formatter(args.Message);
            _vOutput.WriteLine(formattedstring);
        }

        private void SetFormatter() {
            switch (FormatTypesBox.SelectedItem.ToString()) {
                case "Start with DateTime":
                _vFormatter.SetFormat(MessageFormatter.StartWithTime);
                break;
                case "End with DateTime":
                _vFormatter.SetFormat(MessageFormatter.EndWithTime);
                break;
                case "Custom":
                _vFormatter.SetFormat(MessageFormatter.Custom);
                break;
                case "Lowercase":
                _vFormatter.SetFormat(MessageFormatter.LowerCase);
                break;
                case "Uppercase":
                _vFormatter.SetFormat(MessageFormatter.UpperCase);
                break;
                default:
                _vFormatter.ClearFormat();
                break;
            }
        }

        private void AddFormatTypesToComboBox() {
            var items = new string[]
            {
                "None",
                "Start with DateTime",
                "End with DateTime",
                "Custom",
                "Lowercase",
                "Uppercase"
            };
            FormatTypesBox.Items.AddRange(items);
            FormatTypesBox.SelectedItem = "None";
        }
    }
}

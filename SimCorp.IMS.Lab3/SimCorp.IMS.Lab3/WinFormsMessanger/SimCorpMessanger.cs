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

namespace SimCorp.IMS.WinFormsMessanger {
    public partial class SimCorpMessanger : Form {
        public SimCorpMessanger() {
            InitializeComponent();
            _vMobile = new SimCorpMobile(PushMessage);
            AddFormatTypesToComboBox();
        }

        private SimCorpMobile _vMobile;
        private int _vMessagecounter = 0;
        private MessageFormatter _vFormatter = new MessageFormatter();

        private void SMSPushTimer_Tick(object sender, EventArgs e) {
            _vMessagecounter += 1;
            OnSmsRecieved(GenMessage());
        }

        private void FormatTypesBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetFormatter();
        }

        public void OnSmsRecieved(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSmsRecieved), message);
            }
            _vMobile.SmsProvider.RaiseSmsRecievedEvent(message);
        }

        private string GenMessage() {
            return "Message " + _vMessagecounter;
        }

        private void PushMessage(string message) {
            var formattedstring = _vFormatter.NullFormatter() ? message : _vFormatter.Formatter(message);
            MessageRichBox.Text += formattedstring + '\n';
        }

        private void SetFormatter() {
            switch (FormatTypesBox.SelectedItem.ToString()) {
                case "Start with DateTime":
                _vFormatter.SetFormat(StartWithTime);
                break;
                case "End with DateTime":
                _vFormatter.SetFormat(EndWithTime);
                break;
                case "Custom":
                _vFormatter.SetFormat(Custom);
                break;
                case "Lowercase":
                _vFormatter.SetFormat(LowerCase);
                break;
                case "Uppercase":
                _vFormatter.SetFormat(UpperCase);
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

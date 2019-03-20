using System;
using System.Windows.Forms;
using SimCorp.IMS.Lab3;
using SimCorp.IMS.MobileLibrary;

namespace SimCorp.IMS.WinFormApp {
    public partial class WinFormApp : Form {
        public WinFormApp() {
            InitializeComponent();
            Mobile = new SimCorpMobile();
            Output = new WinLogOutput(TextBox);
        }

        private SimCorpMobile Mobile
        {
            get;
        }

        private IOutput Output
        {
            get;
        }

        private void SetPlayback(IPlayback playback) {
            Output.WriteLine($"{playback.GetType().Name} playback selected");
            Output.WriteLine("Set playback to mobile...");
            Mobile.PlaybackComponent = playback;
            Output.WriteLine("Play sound in mobile:");
            var data = new object();
            Mobile.Play(data);
            Output.WriteLine("");
        }

        private void SetCharger(ICharger charger) {
            Output.WriteLine($"{charger.GetType().Name} charger selected");
            Output.WriteLine("Set charger to mobile...");
            Mobile.ChargingComponent = charger;
            Output.WriteLine("Charging mobile:");
            Mobile.Charge();
            Output.WriteLine("");
        }

        private void ApplyButton_Click(object sender, EventArgs args) {
            Output.Clean();

            //Playback
            if (IPhoneHeadsetButton.Checked == true) {
                SetPlayback(new IPhoneHeadset(Output, "2365:2015"));
            } else if (SamsungHeadsetButton.Checked == true) {
                var plug = new AudioPlug(200, 100, 3.5f);
                SetPlayback(new SamsungHeadset(Output, plug));
            } else if (PhoneSpeakerButton.Checked == true) {
                SetPlayback(new PhoneSpeaker(Output,24.0f));
            }

            //Charger
            if (WirelessChargerButton.Checked == true) {
                SetCharger(new WirelessCharger(Output,1.5f));
            } else if (USBChargerButton.Checked == true) {
                SetCharger(new USBCharger(Output,1.5f,USBCharger.Ports.StandartDownstreamPort));
            }
        }
    }
}

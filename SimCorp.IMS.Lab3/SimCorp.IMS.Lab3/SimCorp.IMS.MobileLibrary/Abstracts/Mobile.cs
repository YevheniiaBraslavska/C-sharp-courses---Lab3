using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.Lab3 {
    public abstract class Mobile {
        public abstract ScreenAttribute Screen { get; }
        public abstract KeyboardAttribute Keyboard { get; }
        public abstract BatteryAttribute Battery { get; }
        public abstract SlotAttribute Slot { get; }
        public IPlayback PlaybackComponent { get; set; }
        public ICharger ChargingComponent { get; set; }
        public SMSProvider SmsProvider { get; set; }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }

        public void Charge() {
            ChargingComponent.Charge();
        }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard Type: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Slot Type: {Slot.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class USBCharger : ICharger {
        public enum Ports {
            StandartDownstreamPort = 1,
            ChargingDownstreamPort = 2,
            DedicatedChargingPort = 3
        }

        private IOutput Output { get; }
        public float Amperage { get; }
        public Ports Port { get; }

        public USBCharger(IOutput output, float amperage, Ports port) {
            Output = output;
            Amperage = amperage;
            Port = port;
        }

        public void Charge() {
            Output.WriteLine($"Charge with {nameof(USBCharger)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class WirelessCharger : ICharger {
        private IOutput Output { get; }
        public float Amperage { get; }

        public WirelessCharger(IOutput output, float amperage) {
            Output = output;
            Amperage = amperage;
        }

        public void Charge() {
            Output.WriteLine($"Charge with {nameof(WirelessCharger)}");
        }

        private void ElectromagneticResonantInit() {
            throw new NotImplementedException();
        }

        private void ElectromagneticResonantRun() {
            throw new NotImplementedException();
        }
    }
}

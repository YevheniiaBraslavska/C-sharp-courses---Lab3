using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class IPhoneHeadset : IPlayback {
        private IOutput Output { get; }
        public string BluetoothConnection { get; private set; }

        public IPhoneHeadset(IOutput output, string blthcon) {
            Output = output;
            BluetoothConnection = blthcon;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(IPhoneHeadset)} sound");
        }
    }
}

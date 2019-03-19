using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobileLibrary;

namespace SimCorp.IMS.Lab3 {
    public class SamsungHeadset : IPlayback {
        private IOutput Output { get; }
        public AudioPlug Plug { get; private set; }

        public SamsungHeadset(IOutput output, AudioPlug plug) {
            Output = output;
            Plug = plug;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}

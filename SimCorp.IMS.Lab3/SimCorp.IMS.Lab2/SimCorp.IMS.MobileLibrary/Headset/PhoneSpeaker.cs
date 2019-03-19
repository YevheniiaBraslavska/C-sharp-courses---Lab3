using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobileLibrary;

namespace SimCorp.IMS.Lab3 {
    public class PhoneSpeaker : IPlayback {
        private IOutput Output { get; }

        private float _vImpedance;
        public float Impedance
        {
            get { return _vImpedance; }
            private set
            {
                if (value < 20.0f) {
                    throw new ArgumentException("Impedance for phone speaker should be more than 20.0 om");
                }
                _vImpedance = value;
            }
        }

        public PhoneSpeaker(IOutput output, float impedance) {
            Output = output;
            Impedance = impedance;
        }

        public void Play(object data) {
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}

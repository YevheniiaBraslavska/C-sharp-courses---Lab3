using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class SimCardSlot : SlotAttribute {
        public enum FormFactors {
            MicroSim = 1,
            MiniSim = 2,
            NanoSim = 3,
        }

        public override int Height { get; }
        public override int Width { get; }
        public FormFactors FormFactor { get; }

        public SimCardSlot(FormFactors formFactor, int height, int width) {
            FormFactor = formFactor;
            Height = height;
            Width = width;
        }

        public override string ToString() {
            return "SimCard Slot";
        }
    }
}

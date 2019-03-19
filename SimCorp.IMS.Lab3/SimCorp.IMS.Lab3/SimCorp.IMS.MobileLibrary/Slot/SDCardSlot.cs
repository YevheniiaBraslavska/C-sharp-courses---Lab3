using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class SDCardSlot : SlotAttribute {
        public enum SDTypes {
            MicroSD = 1,
            MiniSD = 2,
        }

        public override int Height { get; }
        public override int Width { get; }
        public SDTypes SDType { get; }
        public int Capacity { get; }

        public SDCardSlot(SDTypes sdType, int height, int width, int capacity) {
            SDType = sdType;
            Height = height;
            Width = width;
            Capacity = capacity;
        }

        public override string ToString() {
            return "SDCard Slot";
        }
    }
}

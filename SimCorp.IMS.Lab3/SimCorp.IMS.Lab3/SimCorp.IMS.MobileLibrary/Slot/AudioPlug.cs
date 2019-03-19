using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.Lab3;

namespace SimCorp.IMS.MobileLibrary {
    public class AudioPlug : SlotAttribute {
        public override int Height { get; }
        public override int Width { get; }
        public float RoundSize { get; }

        public AudioPlug(int height, int width, float size)
        {
            Height = height;
            Width = width;
            RoundSize = size;
        }
    }
}

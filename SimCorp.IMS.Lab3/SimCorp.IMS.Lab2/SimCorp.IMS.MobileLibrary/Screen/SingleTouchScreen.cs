using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class SingleTouchScreen : ScreenAttribute{
        public override int Height { get; set; }
        public override int Width { get; set; }
        public override int DPI { get; set; }

        public virtual void Touch() {           
        }

        public override string ToString() {
            return "Single Touch Screen";
        }

        public override void Show(IScreenImage screenImage) {
            throw new NotImplementedException();
        }
    }
}

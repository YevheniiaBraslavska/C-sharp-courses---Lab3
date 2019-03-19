using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class MultyTouchScreen : SingleTouchScreen{
        private int vMaxTouches;
        public int MaxTouches {
            get {
                return vMaxTouches;
            }
            set {
                vMaxTouches = value;
            }
        }

        public MultyTouchScreen(int maxTouches) {
            vMaxTouches = maxTouches;
        }

        public override void Touch() {
            base.Touch();
        }

        public override void Show(IScreenImage screenImage) {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "Multy Touch Screen";
        }
    }
}

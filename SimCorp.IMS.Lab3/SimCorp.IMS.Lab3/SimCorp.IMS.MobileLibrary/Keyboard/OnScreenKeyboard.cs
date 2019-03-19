using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class OnScreenKeyboard : KeyboardAttribute {
        public override List<Layout> Layouts { get; }

        public OnScreenKeyboard(List<Layout> layouts) {
            Layouts = new List<Layout>(layouts);
        }

        public override void Push(IInput input) {
            //Input with touching
        }

        public void Slide(IInput input) {
            //Input with sliding across keyboard
        }

        public override string ToString() {
            return "OnScreen Keyboard";
        }
    }
}

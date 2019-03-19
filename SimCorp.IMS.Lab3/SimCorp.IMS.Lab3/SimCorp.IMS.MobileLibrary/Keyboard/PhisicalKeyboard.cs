using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class PhisicalKeyboard : KeyboardAttribute {
        public override List<Layout> Layouts { get; }

        public PhisicalKeyboard(Layout layout) {
            Layouts = new List<Layout>() {
                layout
            };
        }

        public override void Push(IInput input) {
        }

        public override string ToString() {
            return "Phisical Keyboard";
        }
    }
}

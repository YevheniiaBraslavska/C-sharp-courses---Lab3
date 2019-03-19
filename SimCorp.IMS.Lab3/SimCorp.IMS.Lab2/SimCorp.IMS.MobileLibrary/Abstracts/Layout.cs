using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab3 {
    public class Layout {
        public List<Button> Values { get; }

        public Layout(List<char> values) {
            Values = GenLayoutVal(values);
        }

        public Layout(List<List<char>> values) {
            Values = GenLayoutVal(values);
        }

        public static List<Button> GenLayoutVal(List<char> sets) {
            List<Button> layout = new List<Button>();
            foreach (char set in sets) {
                Button button = new Button(set);
                layout.Add(button);
            }
            return layout;
        }

        public static List<Button> GenLayoutVal(List<List<char>> sets) {
            List<Button> layout = new List<Button>();
            foreach (List<char> set in sets) {
                Button button = new Button(set);
                layout.Add(button);
            }
            return layout;
        }
    }
}

using System.Collections.Generic;

namespace SimCorp.IMS.Lab3 {
    public class Button {
        private List<char> vValues;

        public List<char> Values {
            get {
                return vValues;
            }
        }

        public Button(char set) {
            vValues = new List<char>() {
                set
            };
        }

        public Button(List<char> set) {
            vValues = new List<char>(set);
        }
    }
}
using System.Collections.Generic;

namespace SimCorp.IMS.Lab3 {
    public abstract class KeyboardAttribute {
        public abstract List<Layout> Layouts { get; }
        public abstract void Push(IInput input);
    }
}
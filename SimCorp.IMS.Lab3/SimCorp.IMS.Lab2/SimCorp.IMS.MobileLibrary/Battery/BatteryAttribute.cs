namespace SimCorp.IMS.Lab3 {
    public class BatteryAttribute {
        public enum Types {
            LitiumIon = 1,
            NickelMetalHydride = 2,
        }

        public int Capacity { get; }
        public Types Type { get; }

        public BatteryAttribute(Types type, int capacity) {
            Type = type;
            Capacity = capacity;
        }

        public override string ToString() {
            return Type.ToString() + " Battery";
        }
    }
}
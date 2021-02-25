using System;

namespace ClassStructureEnumTest
{
    [Flags]
    public enum Bitmap : uint
    {
        none = 0,
        first = 1,
        second = 2,
        third = 4,
        forth = 8,
        fifth = 16,
        sixth = 32,
        seventh = 64,
        eigth = 128,
        all = ~none
    }
    class BitOperations
    {
        public Bitmap Value {get; private set;}

        public BitOperations() => this.Value = Bitmap.none;
        public BitOperations(Bitmap value) => this.Value = value;
        public void Add(Bitmap value) => this.Value |= value;
        public void Remove(Bitmap value) => this.Value ^= value;
        public bool Contains(Bitmap value) => (this.Value & value) == value;
        public override string ToString() => this.Value.ToString();
    }
}

using System;

namespace DesignPattern.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine("Primary Operation: " + depth + " -- " + Name);
        }

    }
}

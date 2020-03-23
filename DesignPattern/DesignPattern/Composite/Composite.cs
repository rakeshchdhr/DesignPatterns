using System;
using System.Collections.Generic;

namespace DesignPattern.Composite
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public void Add(Component c)
        {
            children.Add(c);
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine("Primary Operation: " + depth + " -- " + Name);
            foreach (var component in children)
            {
                component.PrimaryOperation(depth + 2);
            }
        }

        public void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class Human
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }


        public void Dead()
        {
            Console.WriteLine("Humans will dead");
        }
        public abstract void Drink();
    }
}

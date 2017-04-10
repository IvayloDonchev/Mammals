using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Mammal
    {
        private string name;
        public Mammal(string name)
        {
            this.name = name;
        }
        public void Breathe()
        {
            //..................
        }
        public void SuckleYoung()
        {
            //..................
        }
        public void Move()
        {
            Console.WriteLine("Mammal moves");
        }
    }
    public class Horse : Mammal
    {
        public Horse(string name) : base(name)
        {
        }

        public void Trot()  // Тръс, бърз ход
        {
            //..................
        }
        new public void Move()
        {
            base.Move();
            Console.WriteLine("Horse moves");
        }
    }
    public class Whale : Mammal
    {
        public Whale(string name) : base(name)
        {
        }

        public void Swim()
        {
            //..................
        }
    }
}

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
        public override string ToString() => name;
        public virtual string GetTypeName() => "This is a mammal";
    }
    public class Horse : Mammal, ILandBound, IJourney, IGrazable
    {
        public Horse(string name) : base(name)
        {}

        public void Trot()  // Тръс, бърз ход
        {
            //..................
        }
        new public void Move()
        {
            base.Move();
            Console.WriteLine("Horse moves");
        }
        public override string ToString() => $"Horse {base.ToString()}";
        public new string GetTypeName() => "This is a horse";
        int ILandBound.NumberOfLegs() => 4;
        int IJourney.NumberOfLegs() => 3;
        void IGrazable.ChewGrass()
        {
            throw new NotImplementedException();
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
        public new string GetTypeName() => "This is a whale";
       
    }
    public class Aardvark : Mammal
    {
        public Aardvark(string name) : base(name)
        { }
    }
}

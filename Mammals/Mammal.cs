using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Mammal
    {
        public void Breathe()
        {
            //..................
        }
        public void SuckleYoung()
        {
            //..................
        }
    }
    public class Horse : Mammal
    {
        public void Trot()  // Тръс, бърз ход
        {
            //..................
        }
    }
    public sealed class Whale : Mammal
    {
        public void Swim()
        {
            //..................
        }
    }
}

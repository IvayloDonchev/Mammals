using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse("Napoleon");
            horse.Trot();
            horse.Breathe();
            horse.SuckleYoung();

            Whale whale = new Whale("Abalone");
            whale.Swim();
            whale.Breathe();
            whale.SuckleYoung();
        
            var horseMethods = typeof(Horse).GetMethods(System.Reflection.BindingFlags.Public | 
                                                        System.Reflection.BindingFlags.Instance);
            foreach(var method in horseMethods)
            {
                var parameters = method.GetParameters();
                Console.Write($"{method.ReturnType.Name} {method.Name}(");
                foreach (var parameter in parameters)
                {
                    Console.Write($"{parameter.ParameterType.Name} {parameter.Name} ");
                }
                Console.WriteLine(")");
            }

            Horse myHorse = new Horse("Napoleon");
            Mammal myMammal = myHorse;  // myMammal refers to a Horse
            Horse myHorseAgain = myMammal as Horse;     // OK - myMammal was a Horse
            Whale myWhale = new Whale("Abalone");
            myMammal = myWhale;         // myMammal refers to a Whale
            myHorseAgain = myMammal as Horse;   // returns null - myMammal was a Whale






        }
    }
}

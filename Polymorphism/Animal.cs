using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal:LivingBeing
    {
        public void Adaptation()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilirler.");
        }

        public override void ReactionToWarnings()
        {
            base.ReactionToWarnings();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }
}

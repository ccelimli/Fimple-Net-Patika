using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Plant:LivingBeing
    {
        protected void Photosynthesize()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void ReactionToWarnings()
        {
            Console.WriteLine("Bitkiler güneşe tepki verir!");
        }
    }
}

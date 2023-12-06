using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class LivingBeing
    {
        protected void Nutrition()
        {
            Console.WriteLine("Canlılar Beslenir!");
        }

        protected void Respiration()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Discharge()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }

        public virtual void ReactionToWarnings()
        {
            Console.WriteLine("Canlılar Uyarılara tepki verir.");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bird: Animal
    {
        public Bird()
        {
            base.Adaptation();
            base.Nutrition();
            base.Discharge();
            base.ReactionToWarnings();
        }
    }
}

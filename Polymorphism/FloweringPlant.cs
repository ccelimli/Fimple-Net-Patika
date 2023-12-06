using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class FloweringPlant : Plant
    {
        public FloweringPlant()
        {
            base.Photosynthesize();
            base.Nutrition();
            base.Discharge();
            base.Respiration();
            base.ReactionToWarnings();
        }
    }
}

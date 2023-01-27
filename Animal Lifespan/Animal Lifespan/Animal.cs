using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lifespan
{
    public class Animal
    {
        public int MaximumEnergy { get; set; }
        public HashSet<string> Diet { get; set; }
        public int CurrentEnergy { get; set; }

        public void Feed(string food)
        {
            if (Diet.Contains(food))
            {
                CurrentEnergy++;
                if (CurrentEnergy > MaximumEnergy)
                {
                    CurrentEnergy = MaximumEnergy;
                }
            }
            else
            {
                CurrentEnergy--;
            }
        }
    }
}

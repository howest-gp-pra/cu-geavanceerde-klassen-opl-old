using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.AdvancedClasses.CORE
{
    public class Bicycle : Vehicle
    {
        private bool hasFenders;

        public bool HasFenders
        {
            get { return hasFenders; }
            set { hasFenders = value; }
        }

        public Bicycle()
        {
            numberOfWheels = 2;
        }

        public override string ShowDetails()
        {
            string engineText = hasEngine ? "een" : "geen";
            return $"Deze fiets heeft {engineText} motor, heeft {numberOfWheels} wielen en is van het merk {brand}";
        }
    }
}

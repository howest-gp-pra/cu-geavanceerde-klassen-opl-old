using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.AdvancedClasses.CORE
{
    public class Car : Vehicle
    {
        private int numberOfDoors;

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }

        public override string ShowDetails()
        {
            return $"Deze auto heeft {numberOfDoors} deuren en {numberOfWheels} wielen";
        }
    }
}

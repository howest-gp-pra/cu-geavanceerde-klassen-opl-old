using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.AdvancedClasses.CORE
{
    //public abstract class Vehicle
    public class Vehicle
    {
        protected int numberOfWheels = 4;

        protected bool hasEngine;
        protected string brand;

        public bool HasEngine
        {
            get { return hasEngine; }
            set { hasEngine = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public virtual string ShowDetails()
        {
            string engineText = hasEngine?"een":"geen";
            return $"Dit voertuig heeft {engineText} motor en is van het merk {brand}";
        }
    }
}

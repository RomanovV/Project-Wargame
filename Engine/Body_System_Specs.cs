using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Body_System_Specs
    {
        public string name { get; protected set; }
        public double weight { get; protected set; }

        public Body_System_Specs(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}

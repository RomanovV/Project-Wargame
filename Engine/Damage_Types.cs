using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Damage_Types
    {
        public string name { get; protected set; }
        public double damage;

        // TODO: public double time_to_recuperate;

        public Damage_Types(string name, double damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}

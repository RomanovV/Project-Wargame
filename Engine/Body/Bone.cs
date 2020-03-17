using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Bone
    {
        public string name { get; protected set; }

        public class Damage_Types
        {
            public string name;
            public enum type { crack, brake}
            public double damage;

            public Damage_Types(string name, double damage)
            {
                this.name = name;
                this.damage = damage;
            }
        }

        public List<Damage_Types> damage_types = new List<Damage_Types>();

        public double bone_HP 
        { 
            get { return getBoneHP( damage_types ); } 
            protected set { }
        }

        private double getBoneHP(object damage_types)
        {
            
        }

        public Bone()
        {

        }

        
    }
}

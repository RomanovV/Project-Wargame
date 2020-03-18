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

        public double bone_HP 
        { 
            get { return getBoneHP(  ); } 
            protected set { }
        }

        private double getBoneHP()
        {
            
        }

        public Bone()
        {

        }

        
    }
}

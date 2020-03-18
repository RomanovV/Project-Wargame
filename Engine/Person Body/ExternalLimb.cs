using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class ExternalLimb : Limb
    {
        public Limb skin;
        public List<Bone> bones = new List<Bone>();

        public ExternalLimb(string name,
                             Limb skin,
                             List<Bone> bones,
                             List<DamageController> damageControllers) : 
            base(name, damageControllers)
        {
            this.skin = skin;
            this.bones = bones;
        }

        public ExternalLimb(string name,
                             Limb skin,
                             List<Bone> bones,
                             List<TypeOfDamage> types,
                             List<double> damages,
                             List<double> influences) :
            base(name, types, damages, influences)
        {
            this.skin = skin;
            this.bones = bones;
        }
    }
}

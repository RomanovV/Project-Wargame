using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Body
    {
        //blood tuff
        //temperature stuff
        //nutrition stuff
        //air stuff
        //age stuff

        public readonly List<ExternalLimb> externalLimbs = new List<ExternalLimb>();

        public readonly List<Limb> internalLimbs = new List<Limb>();
        public List<BodySystem> bodySystems = new List<BodySystem>();
    }
}

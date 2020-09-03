using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Body
    {
        //blood stuff
        public double bloodVolume;
        public double externalBleeding;
        public double internalBleeding;

        public double confortableTemperature;

        public int age;

        //TODO: Implementar os tipos de ar respiráveis como classe:
        //public airType air blablabla
        public bool requireAtmosfere;
        public double minimunAtmosfere;

        //nutrition stuff

        public readonly List<ExternalLimb> externalLimbs = new List<ExternalLimb>();

        public readonly List<Limb> internalLimbs = new List<Limb>();

        public List<BodySystem> bodySystems = new List<BodySystem>();

        public Body(List<ExternalLimb> externalLimbs,
                    List<Limb> internalLimbs,
                    List<BodySystem> bodySystems)
        {
            this.externalLimbs = externalLimbs;
            this.internalLimbs = internalLimbs;
            this.bodySystems = bodySystems;
        }
    }
}

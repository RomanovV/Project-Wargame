using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Disease
    {
        // TODO: Ver se doença e toxina vão ser classes herdadas uma da outra.
        public string name { get; protected set; }

        // TODO: Ver melhor esse negocio de enum
        public enum Disease_Type { Virus, Bacteria, Fungae, Vermin, Toxine, Enviromental };
        Disease_Type type;
        public enum Infection_Type { Contact, Inalation, Igenstion };
        Infection_Type infection_type;

        Body body;

        public Disease()
        {

        }

    }
}

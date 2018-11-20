using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Toxin
    {
        public string name { get; protected set; }
        public double PPM;

        // IMPLEMENTAR:
        // Lista de tipos de toxina ou efeitos que elas causam nos outros sitemas.

        public Toxin(string name, double PPM)
        {
            this.PPM = PPM;
            this.name = name;
        }
    }
}

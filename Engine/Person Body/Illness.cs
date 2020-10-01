using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Person_Body
{
    public class Illness
    {
        public string name;
        public illnessType illnessType;
        public infectionType infectionType;
        private readonly Body body; // Não tem que ter um body

    }
}

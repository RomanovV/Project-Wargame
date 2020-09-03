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

        public Body body;

        public class Toxin_Specs
        {
            // Nome do Orgão que vai ser afetado.
            public string limb_name;

            // Dano a cada intervalo de tempo.
            public double limb_damage;

            public Toxin_Specs(string limb_name, double limb_damage)
            {
                this.limb_name = limb_name;
                this.limb_damage = limb_damage;
            }
        }

        public List<Toxin_Specs> specs = new List<Toxin_Specs>();

        public int numberOfAffectedLimbs;

        // TODO: implementar isso como uma "coisa" no mundo.
        public double resistence;
        public double volatility;
        public double decay;

        

        public Toxin(string name, double PPM, int numberOfAffectedLimbs,
            string[] nameOfAffectedLimbs, double[] damageOfAffectedLimbs, Body body)
        {
            this.PPM = PPM;
            this.name = name;
            this.numberOfAffectedLimbs = numberOfAffectedLimbs;

            this.body = body;

            for (int i=0 ; i < numberOfAffectedLimbs ; i++)
            {
                
                specs.Add(new Toxin_Specs(nameOfAffectedLimbs[i], damageOfAffectedLimbs[i]));
            }
        }

        // TODO: Danificar pele
        public void damageLimbs()
        {
            foreach (Toxin_Specs toxin in specs)
            {
                body.internal_limb_list.Find(item => item.name == toxin.limb_name).modify_limb_damage_by_damage_name(toxin.limb_name,toxin.limb_damage);
            }
        }
    }
}

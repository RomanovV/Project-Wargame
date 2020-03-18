using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// Classe que define um Tipo de Dano orgânico,
    /// Tipo, Dano e Influencia no Sistema
    /// </summary>
    public class DamageController
    {
        public TypeOfDamage type;
        public double damage;
        public double influence;

        public DamageController(TypeOfDamage type, double damage, double influence)
        {
            this.type = type;
            this.damage = damage;
            this.influence = influence;
        }
    }
}

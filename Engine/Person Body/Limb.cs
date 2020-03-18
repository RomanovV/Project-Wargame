using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// Classe que descreve o funcionamento geral de um orgão.
    /// </summary>
    class Limb
    {
        public string name { get; protected set; }

        /// <summary>
        /// O Controlador do dano de um Orgão.
        /// </summary>
        public List<DamageController> damageControllers = new List<DamageController>();

        /// <summary>
        /// Abstração do funcionamento de um Orgão.
        /// </summary>
        public double hp
        {
            get { return getHP(); }
            protected set { }
        }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="damageControllers">Controlador do dano para o Orgão.</param>
        public Limb(string name,
                    List<DamageController> damageControllers)
        {
            this.name = name;
            this.damageControllers = damageControllers;
        }

        /// <summary>
        /// Construtor que gera a sua própria Lista de Dano a partir de uma lista de Tipos
        /// uma de Danos e uma de Influências.
        /// </summary>
        /// <param name="types">Tipo de dano do tipo.</param>
        /// <param name="damages">Valor do dano, Default = 0f.</param>
        /// <param name="influences">A influencia que esse dano tem no HP/Funcionamento do um Orgão.</param>
        public Limb(string name,
                    List<TypeOfDamage> types,
                    List<double> damages,
                    List<double> influences)
        {
            this.name = name;

            try
            {
                for (int i = 0; i < types.Count; i++)
                {
                    damageControllers.Add(new DamageController(types[i], damages[i], influences[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong when trying to create the damage types list, ERROR: " + ex);
            }
        }

        /// <summary>
        /// Metodo que causa dano no orgão.
        /// </summary>
        /// <param name="type">Tipo do dano a ser causado</param>
        /// <param name="damage">Valor do dano a ser causado</param>
        public void damageHPByDamageType(DamageController type, double damage)
        {
            damageControllers.Find(item => item.type == type.type).damage += damage;
        }

        /// <summary>
        /// Metodo que retorna o HP/Funcionamento  baseado nos danos que recebeu
        /// </summary>
        /// <returns>O HP Calculado</returns>
        public double getHP()
        {
            double calcHP = 1000f;

            foreach (DamageController damage in damageControllers)
            {
                calcHP -= damage.damage * damage.influence;
            }

            // Return calcHP if >= 0 else return 0
            return calcHP >= 0 ? calcHP : 0f;
        }
    }
}

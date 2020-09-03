using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// Classe que descreve o funcionamento geral de um orgão externo,
    /// i.e. braço, perna, nariz, olho. É baseada na classe Limb. 
    /// Um olho é um nariz sem osso.
    /// </summary>
    public class ExternalLimb : Limb
    {
        /// <summary>
        /// Pele que recobre o orgão. É um limb.
        /// </summary>
        public Limb skin;

        /// <summary>
        /// A lsita de ossos que estão dentro deste orgão externo.
        /// Cartilagem é osso. Olho não tem osso.
        /// </summary>
        public List<Bone> bones = new List<Bone>();

        /// <summary>
        /// Construtor padrão para uma lsita de controladores de dano e ossos.
        /// </summary>
        /// <param name="name">Nome do orgão externo.</param>
        /// <param name="skin">Pele.</param>
        /// <param name="bones">Lista de ossos que estão contidos nesse orgão</param>
        /// <param name="damageControllers"> Lista de controladores de dano</param>
        public ExternalLimb(string name,
                             Limb skin,
                             List<Bone> bones,
                             List<DamageController> damageControllers) : 
            base(name, damageControllers)
        {
            this.skin = skin;
            this.bones = bones;
        }

        /// <summary>
        /// Construtor que gera a sua própria Lista de Dano a partir de uma lista de Tipos
        /// uma de Danos e uma de Influências.
        /// </summary>
        /// <param name="name">Nome do orgão externo.</param>
        /// <param name="skin">Pele.</param>
        /// <param name="bones">Lista de ossos que estão contidos nesse orgão.</param>
        /// <param name="types">Lista de tipos de dano</param>
        /// <param name="damages">Lista de valores de dano, Default = 0f</param>
        /// <param name="influences">A influencia que esse dano tem no HP/Funcionamento do orgão externo</param>
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

            try
            {
                for(int i = 0; i < types.Count; i++)
                {
                    damageControllers.Add(new DamageController(types[i], damages[i], influences[i]));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong when trying to create the damage types list, ERROR: " + ex);
            }
        }
    }
}

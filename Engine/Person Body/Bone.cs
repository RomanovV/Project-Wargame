using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// Classe que descreve o funcionamento das Estruturas Osseas
    /// </summary>
    public class Bone
    {
        /// <summary>
        /// Nome do Osso
        /// </summary>
        public string name { get; protected set; }

        /// <summary>
        /// Abstração do Funcionamento do Osso
        /// </summary>
        // TODO: Encapsular isso melhor
        public double hp = 1000f;

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="name">Nome do Osso</param>
        public Bone(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Retorna um texto explicando a condição do osso segundo algumas
        /// limites pré estabelescidos
        /// </summary>
        /// <returns>Mensagem em Texto.</returns>
        public string boneStatusToText()
        {
            if (hp == 1000) // TODO: Equalidade com float da merda
            {
                return "The " + name + " is in perfect Conditions";
            }
            else if (hp < 1000 && hp >= 750)
            {
                return "The " + name + " is Cracked";
            }
            else if (hp < 750 && hp >= 500)
            {
                return "The " + name + " is  broken";
            }
            else if (hp < 500 && hp >= 250)
            {
                return "The " + name + " is  broken and exposed";
            }
            else if (hp < 250 && hp >= 0)
            {
                return "The " + name + " is  destroyed";
            }
            else
            {
                return "ERROR: For some reason the " + name + " bone HP is less then 0 or more then 1000, HP = " + hp;
            }
        }

    }
}

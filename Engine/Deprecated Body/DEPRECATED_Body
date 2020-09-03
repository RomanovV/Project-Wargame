using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.DeprecatedBody
{
    /// <summary>
    /// Corpo humano com todos os seus membros e orgãos.
    /// TODO: Fazer um método para melhoramento fisico e mental. Aprendizado e treinamento
    /// </summary>
    public class Body
    {
        public double blood_amount; // valor em l

        public double internal_bleeding; // Quantidade em l/5s
        public double bleeding; // Quantidade em l/5s

        public List<Toxin> blood_toxin_list = new List<Toxin>(); // List of Toxins in blood 

        public double temperature; // Body temp in ºC

        public double nutrition; // Body nutrition in calories (Kcal)

        // public double oxigen_need
        // {
        //    get { oxigen_need_weighted_by_system_need(algo) }
        //    protected set { }
        // }

        public List<External_Limb> external_limb = new List<External_Limb>(); // Lista de membros externos
        public List<Limb> internal_limb_list = new List<Limb>(); // Lista de membros internos

        // TODO: Implemntar uma fraca influência do corpo nos atributos físicos.
        public double age; // Idade do corpo
        
        // Default Constructor without toxin
        // TODO: Adicionar age, bleeding, internal bleeding.
        // TODO: Fazer um construtor padrão que aceite parâmetros de estatus negativos
        // como Doenças, Toxinas, e Bleeding
        // TODO: Fazer o construtor receber uma lista de nomes de membros internos e membros externos
        // para fazer um construtor que valha para coisas que nao sao humanas
        public Body(double blood_amount = 5f, double temperature = 34f, double nutrition = 1f)
        {
            this.blood_amount = blood_amount;
            this.temperature = temperature;
            this.nutrition = nutrition;

            // Populando a lista de membros externos (pele e osso)
            external_limb.Add(new External_Limb("Head"));
            external_limb.Add(new External_Limb("Torso"));

            external_limb.Add(new External_Limb("Left Arm"));
                external_limb.Add(new External_Limb("Left Hand"));
            external_limb.Add(new External_Limb("Right Arm"));
                external_limb.Add(new External_Limb("Right Hand"));

            external_limb.Add(new External_Limb("Left Leg"));
                external_limb.Add(new External_Limb("Left Foot"));
            external_limb.Add(new External_Limb("Right Leg"));
                external_limb.Add(new External_Limb("Right Foot"));

            // Populando a lista de membros internos
            internal_limb_list.Add(new Limb("Right Eye")); // Capacidade de ver
            internal_limb_list.Add(new Limb("Left Eye")); // Capacidade de ver
            internal_limb_list.Add(new Limb("Right Ear")); // Capacidade de ouvir
            internal_limb_list.Add(new Limb("Left Ear")); // Capacidade de ouvir
            internal_limb_list.Add(new Limb("Mouth")); // Para depois atrapalhar as capacidades dos oficiasi em dar ordens
            internal_limb_list.Add(new Limb("Nose")); // Capacidade de respirar e cheirar

            internal_limb_list.Add(new Limb("Brain")); // Capacidade de raciocinar e controle do resto
            internal_limb_list.Add(new Limb("Spine")); // Sistema nervoso central
            internal_limb_list.Add(new Limb("Lungs")); // Respiração
            internal_limb_list.Add(new Limb("Heart")); // Sistema circulatório
            internal_limb_list.Add(new Limb("Stomahc")); // Digestivo
            internal_limb_list.Add(new Limb("Intestines")); // Excretor
            internal_limb_list.Add(new Limb("Kidneys")); // Excretor, Filtragem do Sangue e Adrenalina
            internal_limb_list.Add(new Limb("Liver")); // Filtragem dos venenos tudo e um pouco do digestivo
            internal_limb_list.Add(new Limb("Spleen")); // Imunidade

        }

        /// <summary>
        /// Metodo para popular a lista de partes externas a partir de uma
        /// lista de nomes. 
        /// Safeguard para o futuro
        /// </summary>
        /// <param name="external_limb_name_list">Lista de nomes dos membros externos</param>
        public void populate_external_limbs(List<string> external_limb_name_list)
        {
            foreach (string name in external_limb_name_list)
            {
                external_limb.Add(new External_Limb(name));
            }
        }

        /// <summary>
        /// Metodo para popular a lista de partes externas a partir de uma
        /// lista de nomes. 
        /// Safeguard para o futuro 
        /// </summary>
        /// <param name="internal_limb_name_list">Lista de nomes dos membros internos</param>
        public void populate_internal_limbs(List<string> internal_limb_name_list)
        {
            foreach (string name in internal_limb_name_list)
            {
                internal_limb_list.Add(new Limb(name));
            }
        }

        // Retorna a PPM de uma toxina pelo nome
        // TODO: Depois que mudar a toxina para uma versão mais complexa
        // mudar o scopo da função aqui para retornar uma Toxin ao invés 
        // da PPM
        public double get_toxin_PPM_by_name(string name)
        {
            return blood_toxin_list.Find(item => item.name == name).PPM;
        }

        // Modifica o valor de PPM de uma toxina pelo nome
        // TODO: Quando mudar a toxina, mudar aqui os valores que podem ser mudados
        // ou passar uma função que retorna ua toxina para essa função para ela 
        // ser modificada aqui
        public void change_toxin_amount(string name_to_change, double PPM_to_change)
        {
            blood_toxin_list.Find(item => item.name == name_to_change).PPM = PPM_to_change;
        }

        // Causa dano na pele dependendo do tipo do dano
        // TODO: Ver a possibilidade de juntar essa com a função de cima com um Switch/Case
        public void damage_skin(External_Limb external_limb, string name, double damage)
        {
            external_limb.modify_skin_damage_by_damage_name(name, damage);
        }

        // Causa dano nos ossos dentro de um "orgão" externo
        // TODO: Esse método vai sumir.
        public void damage_bone(External_Limb bone, double damage)
        {
            bone.modify_bone_damage(damage);
        }

        // Causa dano no orgão dependendo do tipo do dano
        public void damage_internal_limb(Limb limb, string name, double damage)
        {
            limb.modify_limb_damage_by_damage_name(name, damage);
        }
    }
}
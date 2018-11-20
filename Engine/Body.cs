using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Body
    {
        public double blood_amount; // % value of total
        public double blood_oxigen; // % value of normal

        public double internal_bleeding; // Quantidade em l/s
        public double bleeding; // Quantidade em l/s

        public List<Toxin> blood_toxin = new List<Toxin>(); // List of Toxins in blood 

        public double temperature; // Body temp in ºC

        public double nutrition; // Body nutrition in calories (Kcal)

        public List<Limb> external_limb = new List<Limb>(); // Lista de membros externos
        public List<Limb> internal_limb_list = new List<Limb>(); // Lista de membros internos

        // TODO: Implemntar uma fraca influência do corpo nos atributos físicos.
        int age; // Idade do corpo
        
        // Default Constructor without toxin
        public Body(double blood_amount, double blood_oxigen, double temperature,
            double nutrition)
        {
            this.blood_amount = blood_amount;
            this.blood_oxigen = blood_oxigen;
            this.temperature = temperature;
            this.nutrition = nutrition;

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


            external_limb.Add(new Limb("Right Eye")); // Capacidade de ver
            external_limb.Add(new Limb("Left Eye")); // Capacidade de ver
            external_limb.Add(new Limb("Right Ear")); // Capacidade de ouvir
            external_limb.Add(new Limb("Left Ear")); // Capacidade de ouvir
            external_limb.Add(new Limb("Mouth")); // Para depois atrapalhar as capacidades dos oficiasi em dar ordens
            external_limb.Add(new Limb("Nose")); // Capacidade de respirar e cheirar

            external_limb.Add(new Limb("Brain")); // Capacidade de raciocinar e controle do resto
            external_limb.Add(new Limb("Spine")); // Sistema nervoso central
            external_limb.Add(new Limb("Lungs")); // Respiração
            external_limb.Add(new Limb("Heart")); // Sistema circulatório
            external_limb.Add(new Limb("Stomahc")); // Digestivo
            external_limb.Add(new Limb("Intestines")); // Excretor
            external_limb.Add(new Limb("Kidneys")); // Excretor, Filtragem do Sangue e Adrenalina
            external_limb.Add(new Limb("Liver")); // Filtragem dos venenos tudo e um pouco do digestivo
            external_limb.Add(new Limb("spleen")); // Não sei

        }

        // Constructor for blood born with toxins
        public Body(double blood_amount, double blood_oxigen, double temperature,
            double nutrition, Toxin toxin)
        {
            this.blood_amount = blood_amount;
            this.blood_oxigen = blood_oxigen;
            this.temperature = temperature;
            this.nutrition = nutrition;

            blood_toxin.Add(toxin);
        }

        // Adiciona uma toxina na lista de toxinas
        public void add_toxins(string name_add, double PPM_add)
        {
            blood_toxin.Add(new Toxin(name_add, PPM_add));
        }

        // Retorna a PPM de uma toxina pelo nome
        public double get_toxin_PPM_by_name(string name)
        {
            return blood_toxin.Find(item => item.name == name).PPM;
        }

        // Modifica o valor de PPM de uma toxina pelo nome
        public void change_toxin_by_name(string name_to_change, double PPM_to_change)
        {
            blood_toxin.Find(item => item.name == name_to_change).PPM = PPM_to_change;
        }

        // Causa dano no orgão externo dependendo do tipo do dano
        public void damage_external_limbs(External_Limb external_limb, string name, double damage)
        {
            external_limb.modify_limb_damage_by_damage_name(name, damage);
        }

        // Causa dano na pele dependendo do tipo do dano
        // TODO: Ver a possibilidade de juntar essa com a função de cima com um Switch/Case
        public void damage_skin_external_limbs(External_Limb external_limb, string name, double damage)
        {
            external_limb.modify_skin_damage_by_damage_name(name, damage);
        }

        // Causa dano nos ossos dentro de um "orgão" externo
        public void damage_bone_external_limb(External_Limb bone, double damage)
        {
            bone.modify_bone_damage(damage);
        }

        // Causa dano no orgão interno dependendo do tipo do dano
        public void damage_internal_limb(Limb limb, string name, double damage)
        {
            limb.modify_limb_damage_by_damage_name(name, damage);
        }
    }
}
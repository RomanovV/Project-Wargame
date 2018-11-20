using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Limb
    {
        public string name { get; protected set; }// Nome do orgão

        // TODO: Ver se o get/set estão funcionando como esperado
        public double limb_PV // Abstração do funcionamento geral, em % do total
        {
            get { return get_PV_value(1 , damage_types); }
            protected set { }
        }

        public List<Damage_Types> damage_types = new List<Damage_Types>(); // Lista de tipos de dano

        private double initial_damage_burning; // dano em % inicial
        private double initial_damage_laceration; // dano em % inicial
        private double initial_damage_freeze; // dano em % inicial
        private double initial_damage_concussion; // dano em % inicial
        private double initial_damage_necrosis; // dano em % inicial

        // Por enqaunto deixar como o pãdrão que está
        // TODO: default constructor para isso
        // TODO: Definir as propriedades, get/set
        double burning_influence = 0.8;
        double laceration_influence = 0.5;
        double freeze_influence = 0.8;
        double concussion_influence = 0.2;
        double necrosis_influence = 1;


        // TODO: Por enquanto vamos iniciar todos os damages com o
        // mudar para um valor na construção depois. Os doubles ali em cima
        public Limb(string name)
        {
            this.name = name;

            damage_types.Add(new Damage_Types("Burning", 0));
            damage_types.Add(new Damage_Types("laceration", 0));
            damage_types.Add(new Damage_Types("Freeze", 0));
            damage_types.Add(new Damage_Types("Concussion", 0));
            damage_types.Add(new Damage_Types("Necrosis", 0));

            //set_PV_value(limb_PV, damage_types); Se o get/set funcionar, isso não é necessário
        }

        // Modifica o valor do dano armazenado, causa dano do tipo [name]
        public void modify_limb_damage_by_damage_name(string name, double damage)
        {
            this.damage_types.Find(item => item.name == name).damage = damage;
            //set_PV_value(limb_PV, damage_types); se o get/set funcionar, isso não é necessário
        }

        public double get_PV_value(double initial_PV_value, List<Damage_Types> list_of_damages)
        {
            // TODO: Ver a possibilidade de mudar isso para 1
            double calc_pv = initial_PV_value;

            foreach (Damage_Types type in list_of_damages)
            {
                switch (type.name)
                {
                    case "Burning":
                        calc_pv -= (burning_influence * type.damage);
                        break;
                    case "Laceration":
                        calc_pv -= (laceration_influence * type.damage);
                        break;
                    case "Freeze":
                        calc_pv -= (freeze_influence * type.damage);
                        break;
                    case "Concussion":
                        calc_pv -= (concussion_influence * type.damage);
                        break;
                    case "Necrosis":
                        calc_pv -= (necrosis_influence * type.damage);
                        break;
                }
            }
            return calc_pv;
        }

    }
}

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

        public double limb_PV // Abstração do funcionamento geral, em % do total
        {
            get { return get_PV_value( damage_types ); }
            protected set { }
        }

        // Declaração dos tipos de dano
        public class Damage_Types
        {
            // TODO: TROCAR name por Type_of_Damage. Pq aí quando for lidar com os danos
            // não vai lidar na forma de string, que pode dar erro por case sensitive.
            public string name { get; protected set; }
            public enum Type_of_Damages { Burning, Laceration, Freeze, Concussion, Necrosis }
            public double damage;

            // TODO: public double time_to_recuperate;

            public Damage_Types(string name, double damage)
            {
                this.name = name;
                this.damage = damage;
            }
        }

        // Guarda uma lista de tipos de danos e os valores deles
        public List<Damage_Types> damage_types = new List<Damage_Types>(); // Lista de tipos de dano

        // TODO: Default Constructor nisso
        private double initial_damage_burning;
        private double initial_damage_laceration;
        private double initial_damage_freeze;
        private double initial_damage_concussion;
        private double initial_damage_necrosis;

        // Os pesos para os tipos de dano, os valores padrão estão no
        // Defautl Constructor como: .8, .5, .8, .2, 1, respectivamente
        private double burning_influence;
        private double laceration_influence;
        private double freeze_influence;
        private double concussion_influence;
        private double necrosis_influence;


        // TODO: Por enquanto vamos iniciar todos os damages com o
        // mudar para um valor na construção depois. Os doubles ali em cima
        public Limb(string name, double burning_influence = 0.8, 
            double laceration_influence = 0.5, double freeze_influence = 0.8, 
                double concussion_influence = 0.2, double necrosis_influence = 1)
        {
            // Define o nome
            this.name = name;

            // Popula os valores dos pesos
            this.burning_influence = burning_influence;
            this.laceration_influence = laceration_influence;
            this.freeze_influence = freeze_influence;
            this.concussion_influence = concussion_influence;
            this.necrosis_influence = necrosis_influence;


            // Popula a lista de danos, e seus valores iniciais
            // TODO: Implemetnar os valores iniciais como parâmetros no constructor
            damage_types.Add(new Damage_Types("Burning", 0f));
            damage_types.Add(new Damage_Types("laceration", 0f));
            damage_types.Add(new Damage_Types("Freeze", 0f));
            damage_types.Add(new Damage_Types("Concussion", 0f));
            damage_types.Add(new Damage_Types("Necrosis", 0f));
        }

        // Causa dano baseado no tipo do dano e no valor passado
        public void modify_limb_damage_by_damage_name(string name, double damage)
        {
            damage_types.Find(item => item.name == name).damage += damage;
        }

        // Função que calcula o dano total do sistema baseado nos tipos de danos 
        // acumulados na lista de danos e em seus pesos
        public double get_PV_value( List<Damage_Types> list_of_damages)
        {
            double calc_pv = 1f;

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
            // TODO: Talvez fazer algo se o Limb ficou com 0 de PV
            if (calc_pv >= 0f)
                return calc_pv;
            else
                return 0f;
        }

    }
}

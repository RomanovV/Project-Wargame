using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class External_Limb : Limb
    {
        public double skin_PV // Abstração do total do funcionamento da pele em %
        {
            get { return get_PV_value(1, skin_damage_types); }
            protected set { }
        }

        // TODO: Arrumar as propriedades daqui
        public double bone_PV = 1; // Abstração de quão quebrado está o osso

        public List<Damage_Types> skin_damage_types = new List<Damage_Types>();

        private double initial_skin_damage_burning; // dano da pele em %
        private double initial_skin_damage_laceration; // dano da pele em %
        private double initial_skin_damage_freeze; // dano da pele em %
        private double initial_skin_damage_concussion; // dano da pele em %
        private double initial_skin_damage_necrosis; // dano da pele em %

        private double initial_bone_damage; // dano do osso em %
                
        // Mesmo role do Limb sobre os valores iniciais do dano
        public External_Limb(string name) : base(name)
        {
            skin_damage_types.Add(new Damage_Types("Burning", 0)); // 0.8
            skin_damage_types.Add(new Damage_Types("Laceration", 0)); // 0.5
            skin_damage_types.Add(new Damage_Types("Freeze", 0)); // 0.8
            skin_damage_types.Add(new Damage_Types("Concussion", 0)); // 0.2
            skin_damage_types.Add(new Damage_Types("Necrosis", 0)); // 1

            //skin_PV = set_PV_value(skin_PV, skin_damage_types);
        }

        // Modifica o valor do dano pelo nome
        public void modify_skin_damage_by_damage_name(string name, double damage)
        {
            this.skin_damage_types.Find(item => item.name == name).damage = damage;

            // Quando o dano muda, muda o PV.
            //skin_PV = set_PV_value(skin_PV, skin_damage_types);
        }

        // TODO: Melhorar o encapsulamento disso
        public void modify_bone_damage(double damage)
        {
            this.bone_PV -= damage;
        }
    }
}

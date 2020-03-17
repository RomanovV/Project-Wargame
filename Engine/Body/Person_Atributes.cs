using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Person_Atributes
    {
        // Aqui ficam os atributos da pessoal, sendo atributos definido como
        // coisas que são influenciados pelos sistemas
        public Body body;
        public Body_Systems body_system;

        public class Specs
        {
            public string name { get; protected set; }
            public double weight { get; protected set; }

            public Specs(string name, double weight)
            {
                this.name = name;
                this.weight = weight;
            }
        }


        // Atributos Mentais
        public double logic;
        public double memory;
        public double charisma;
        public double leadership;
        public double intuition;
        public double criativity;
        public double learning;

        public double consciousness;
        public double pain;

        // Atributos Físicos

        // Manipulação: L_Arm: 10%, R_Arm: 10%, L_Hand: 40%, R_Hand: 40%, nota. 
        private List<Specs> manipulation_list = new List<Specs>();
        public double manipulation;

        public double speed;
        public double immunity;
        public double hearing;
        public double sight;
        public double smell;
        public double toxin_filtering;
        public double strenght;
        public double reflexes;

        public double resistence;

        public Person_Atributes(Body body, Body_Systems body_system, double manipulation_score)
        {
            this.body = body;
            this.body_system = body_system;

            manipulation = manipulation_score;
            manipulation_list.Add(new Specs("Left Hand", 0.4));
            manipulation_list.Add(new Specs("Roght Hand", 0.4));
            manipulation_list.Add(new Specs("Left Arm", 0.1));
            manipulation_list.Add(new Specs("Right Arm", 0.1));

        }

        // TODO: Ver o que da pra fazer com isso, se isso ta certinho. Ou se existe um jeito
        // Melhor. Caso não exita, mudar o nome de Specs para algo mais genérico.
        public double getAtributeValue(double score, List<Specs> list)
        {
            double calc_value = 0f;
            foreach (Specs spec in list)
            {
                calc_value += spec.weight * body.internal_limb_list.Find(item => item.name == spec.name).limb_PV;
            }

            return score * calc_value;
        }
        
    }
}

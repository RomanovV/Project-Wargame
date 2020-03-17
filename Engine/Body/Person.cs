using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Person
    {
        public Body body;
        public Body_Systems body_systems;
        public Person_Atributes atributes;
        public Person_Stats stats;

        public string name;
        public string surname;
        public double height;
        public double weight;
        
        public string skin_color;
        public string eye_color;
        public string hair_color;

        public bool isAlive;

        public Person()
        {
            body = new Body();
            body_systems = new Body_Systems(body);
            atributes = new Person_Atributes(body, body_systems);
            stats = new Person_Stats();
        }

        public void add_toxins(string name_add, double PPM_add, int numberOfAffectedLimbs,
            string[] nameOfAffectedLimbs, double[] damageOfAffectedLimbs)
        {
            // FIXME: SÓ PARA TESTE DE PARÂMETROS
            body.blood_toxin_list.Add(new Toxin(name_add, PPM_add, 1, new string[] { "Heart" }, new double[] { 1f }, body));
        }

        

        public void hunger()
        {
            body.nutrition -= stats.hunger;

            if (body.nutrition < 0f)
                body.nutrition = 0f;
        }
        public void check_If_Alive()
        {
            if (isAlive == true)
            {
                if (body.blood_amount <= 0f)
                    isAlive = false;
                else if (body.nutrition <= 0f)
                    isAlive = false;
                else if (body_systems.cardiac_system_PV <= 0f)
                    isAlive = false;
                else if (body_systems.central_nerve_system_PV <= 0f)
                    isAlive = false;
                else if (body_systems.nerve_system_PV <= 0f)
                    isAlive = false;
                else if (body_systems.respiratory_system_PV <= 0f)
                    isAlive = false;
                else
                    isAlive = true;
            }
        }
        public void bleed()
        {
            body.blood_amount -= body.bleeding;
            body.blood_amount -= body.internal_bleeding;

            check_If_Alive();

            if (body.blood_amount < 0f)
                body.blood_amount = 0f;
        }
        public void change_Temperature(double newTemp)
        {
            body.temperature = newTemp;
        }
        public void age_Increment(double increment)
        {
            body.age += increment;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Person_Stats
    {
        Body_Systems body_system;

        // Atributos Mentais
        double logic;
        double memory;
        double charisma;
        double leadership; //MAYBE
        double intuition;
        double criativity;
        double focus;
        double pain;
        double fear;
        double stress;
        double sanity;
        double learning;
        double consciousness;

        // Atributos Físicos
        double resistence;
        double manipulation;
        double speed;
        double immunity;
        double hearing;
        public double sight
        {
            get { return body_system.sight_system_PV; }
            protected set { }
        }
        double smell;
        double toxin_filtering;
        double hunger;
        double cold;
        double tiredness;
        double strenght;
        double reflexes;

    }
}

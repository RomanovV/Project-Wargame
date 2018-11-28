using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Person_Stats
    {
        // Aqui ficam os status da pessoa, os status são definidos como:
        // coisas que influenciam os sistemas e atributos, a mais
        // superestrutural das características da pessoa.


        // Os atributos vão de 0 à 100.
        // Atrbutos Mentais
        public double pain;
        public double focus;
        public double fear;
        public double stress;
        public double sanity;

        // Atributos físicos
        public double hunger; // Quantidade de calorias queimadas num dado intervalo de tempo [Kcal/5s]
        public double cold;
        public double tiredness;

        public Person_Stats(double pain_score_start = 50f, double focus_score_start = 50f,
            double fear_score_start = 50f, double stress_score_start = 50f, double sanity_score_start = 50f,
                double hunger_score_start = 50f, double cold_score_start = 50f, double tiredness_score_start = 50f)
        {
            pain = pain_score_start;
            focus = focus_score_start;
            fear = fear_score_start;
            stress = stress_score_start;
            sanity = sanity_score_start;
            hunger = hunger_score_start;
            cold = cold_score_start;
            tiredness = tiredness_score_start;
        }

    }
}

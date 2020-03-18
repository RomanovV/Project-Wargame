using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    /// <summary>
    /// Essa é uma versão teste para criação de sistemas do corpo
    /// que posso ter nome variável, principalmente para aliens,
    /// não será usada agora pq depende de xml ou definições 
    /// completas (pq exige uma lista de specs para ser criada)
    /// mas existe para futura implementação
    /// 
    /// Ja tem implementado o novo método de calculo de PV 
    /// do sistema separando peso para outros sistemas e 
    /// para limbs
    /// </summary>
    public class Body_System
    {
        /// <summary> Nome do Sistema </summary>
        public string name;

        /// <summary> Corpo que ele pertence </summary>
        private Body body;

        /// <summary>
        /// Classe que define o nome e o peso de cada parte/limb 
        /// do sistema
        /// </summary>
        public class Body_System_Specs
        {
            public string name { get; protected set; }
            public double weight { get; protected set; }

            public Body_System_Specs(string name, double weight)
            {
                this.name = name;
                this.weight = weight;
            }
        }

        /// <summary>
        /// Lista de coisas que influenciam no funcionamento do sistema
        /// </summary>
        private List<Body_System_Specs> system_specs = new List<Body_System_Specs>();

        /// <summary> Abstração do funcionamento de um sistema </summary>
        /// retorna o calculo baseado nos outros sistemas e limbs do Body.
        public double system_PV
        {
            get { return body_system_get_PV(system_specs); }
            protected set { }
        }

        public Body_System(string name, Body body, List<Body_System_Specs> system_specs)
        {
            this.name = name;
            this.body = body;
            this.system_specs = system_specs;
        }

        public double body_system_get_PV(List<Body_System_Specs> system_specs)
        {
            double pv = 0f;

            foreach(Body_System_Specs spec in system_specs)
            {
                if(spec.name.Contains("System"))
                {
                    // TODO: Implementar isso quando mudar de System_Specs para System_Spec
                    // pv += spec.weight * body.system_list.Find(item => item.name == spec.name).system_PV;
                }
                else
                {
                    pv += spec.weight * body.internal_limb_list.Find(item => item.name == spec.name).limb_PV;
                }
            }

            return pv;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Body_Systems
    {
        // TODO: Implementar uma forma de sistemas dependerem dos outros
        // TODO: Verificar os tipos de acesso aqui
        public Body body { get; protected set; }

        // Lista dos pesos e orgãos da visão e variavel do PV da visão Gettada
        // Pela função
        private List<Body_System_Specs> sight_system = new List<Body_System_Specs>();
        public double sight_system_PV
        {
            get { return body_system_get(sight_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> heationg_system = new List<Body_System_Specs>();
        public double heationg_system_PV
        {
            get { return body_system_get(heationg_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> smell_system = new List<Body_System_Specs>();
        public double smell_system_PV
        {
            get { return body_system_get(smell_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> respiratory_system = new List<Body_System_Specs>();
        public double respiratory_system_PV
        {
            get { return body_system_get(respiratory_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> cardiac_system = new List<Body_System_Specs>();
        public double cardiac_system_PV
        {
            get { return body_system_get(cardiac_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> central_nerve_system = new List<Body_System_Specs>();
        public double central_nerve_system_PV
        {
            get { return body_system_get(central_nerve_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> nerve_system = new List<Body_System_Specs>();
        public double nerve_system_PV
        {
            get { return body_system_get(nerve_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> excretory_system = new List<Body_System_Specs>();
        public double excretory_system_PV
        {
            get { return body_system_get(excretory_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> digestive_system = new List<Body_System_Specs>();
        public double digestive_system_PV
        {
            get { return body_system_get(digestive_system); }
            protected set { }
        }

        //
        private List<Body_System_Specs> immune_system = new List<Body_System_Specs>();
        public double immune_system_PV
        {
            get { return body_system_get(immune_system); }
            protected set { }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Body_Systems()
        {
            // Instanciando Body com os valores padrões
            //TODO: Passar como referência os valores padrão pro body
            body = new Body(5f, 1f, 34f, 1f);

            // Sistema visual: 50% para cada olho
            sight_system.Add(new Body_System_Specs("Right Eye", 0.5));
            sight_system.Add(new Body_System_Specs("Left Eye", 0.5));

            // Sistema auditivo: 50% para cada orelha
            heationg_system.Add(new Body_System_Specs("Right Ear", 0.5));
            heationg_system.Add(new Body_System_Specs("Left Ear", 0.5));

            // Sistema olfativo: 100% nariz
            smell_system.Add(new Body_System_Specs("Nose", 1));

            // Sistema respiratório: Nariz 10%, Pulmão 70%, Coração 20%
            respiratory_system.Add(new Body_System_Specs("Lungs", 0.7));
            respiratory_system.Add(new Body_System_Specs("Nose", 0.1));
            respiratory_system.Add(new Body_System_Specs("Heart", 0.2));

            // Sistema cardíaco: Coração 70%, Rim 10%, Pulmão 20%
            cardiac_system.Add(new Body_System_Specs("Heart", 0.7));
            cardiac_system.Add(new Body_System_Specs("Kidneys", 0.1));
            cardiac_system.Add(new Body_System_Specs("Lungs", 0.2));


            // Sistema Nervoso Central: Espinha 90%, Cérebro 10%
            central_nerve_system.Add(new Body_System_Specs("Spine", 0.9));
            central_nerve_system.Add(new Body_System_Specs("Brain", 0.1));

            // Sistema Nervoso: Cérebro 90%, Espinha 10%
            nerve_system.Add(new Body_System_Specs("Brain", 0.9));
            nerve_system.Add(new Body_System_Specs("Spine", 0.1));

            // Sistema Excretor: Rins 60%, Fígado 20%, Intestinos 20%
            excretory_system.Add(new Body_System_Specs("Kidneys", 0.6));
            excretory_system.Add(new Body_System_Specs("Liver", 0.2));
            excretory_system.Add(new Body_System_Specs("Intestines", 0.2));

            // Sistema Digestivo: Estômago 50%, Fígado 10%, Intestinos 25%, Boca 15%
            digestive_system.Add(new Body_System_Specs("Stomach", 0.5));
            digestive_system.Add(new Body_System_Specs("Liver", 0.1));
            digestive_system.Add(new Body_System_Specs("Intestines", 0.25));
            digestive_system.Add(new Body_System_Specs("Mouth", 0.15));

            // Sistema Imunológico: Baço 100%
            immune_system.Add(new Body_System_Specs("Spleen", 1));

        }

        /// <summary>
        /// Função de Get das variáveis PV
        /// A mágica ta na lista_of_specs que contém o nome e o peso dos orgãos
        /// Muito orgulho dessa função
        /// </summary>
        /// <param name="list_of_specs"></param>
        /// <returns>o PV do sistema baseado no PV dos orgãos e seu respectivo peso no sitema</returns>
        public double body_system_get(List<Body_System_Specs> list_of_specs)
        {
            double calc_value = 0;
            foreach (Body_System_Specs spec in list_of_specs)
            {
                calc_value += spec.weight * body.internal_limb_list.Find(item => item.name == spec.name).limb_PV;
            }
            return calc_value;
        }
    }
}
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

        // 
        private List<Body_System_Specs> sight = new List<Body_System_Specs>();
        public double sight_PV
        {
            get { return body_system_get(sight); }
            protected set { }
        }

        //
        private List<Body_System_Specs> hearing = new List<Body_System_Specs>();
        public double hearing_PV
        {
            get { return body_system_get(hearing); }
            protected set { }
        }

        //
        private List<Body_System_Specs> smell = new List<Body_System_Specs>();
        public double smell_PV
        {
            get { return body_system_get(smell); }
            protected set { }
        }

        //
        private List<Body_System_Specs> respiratory = new List<Body_System_Specs>();
        public double respiratory_PV
        {
            get { return body_system_get(respiratory); }
            protected set { }
        }

        //
        private List<Body_System_Specs> cardiac = new List<Body_System_Specs>();
        public double cardiac_PV
        {
            get { return body_system_get(cardiac); }
            protected set { }
        }

        //
        private List<Body_System_Specs> central_nerve_system = new List<Body_System_Specs>();
        public double central_nerve_system_PV
        {
            get { return body_system_get(central_nerve_system); }
            protected set { }
        }

        public Body_Systems()
        {

            body = new Body(5, 1, 34, 1);
            // Sistema visual: 50% para cada olho
            sight.Add(new Body_System_Specs("Right Eye", 0.5));
            sight.Add(new Body_System_Specs("Left Eye", 0.5));

            // Sistema auditivo: 50% para cada orelha
            hearing.Add(new Body_System_Specs("Right Ear", 0.5));
            hearing.Add(new Body_System_Specs("Left Ear", 0.5));

            // Sistema olfativo: 100% nariz
            smell.Add(new Body_System_Specs("Nose", 1));

            // Sistema respiratório: Nariz 10%, Pulmão 70%, Coração 20%
            respiratory.Add(new Body_System_Specs("Lungs", 0.7));
            respiratory.Add(new Body_System_Specs("Nose", 0.1));
            respiratory.Add(new Body_System_Specs("Heart", 0.2));

            // Sistema cardíaco: Coração 70%, Rim 10%, Pulmão 20%
            cardiac.Add(new Body_System_Specs("Heart", 0.7));
            cardiac.Add(new Body_System_Specs("Kidneys", 0.1));
            cardiac.Add(new Body_System_Specs("Lungs", 0.2));


            // Sistema Nervoso Central: Espinha 90%, Cérebro 10%
            central_nerve_system.Add(new Body_System_Specs("Spine", 0.9));
            central_nerve_system.Add(new Body_System_Specs("Brain", 0.1));

            // Sistema Nervoso: Cérebro 90%, Espinha 10%
            // Sistema Excretor: Rins 60%, Fígado 20%, Intestinos 20%
            // Sistema Digestivo: Estômago 50%, Fígado 10%, Intestinos 25%, Boca 15%
            // Sistema Imunológico: Baço 100%

        }


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

/*
        public double get_PV_value_Ssight()
        {
            double left_eye_limb_PV = body.external_limb.Find(item => item.name == "Left Eye").limb_PV;
            double right_eye_limb_PV = body.external_limb.Find(item => item.name == "Right Eye").limb_PV;

            return ( (left_eye_limb_PV * 0.5) + (right_eye_limb_PV * 0.5) );
        }
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Body_Systems
    {
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

        //
        private List<Body_System_Specs> cardiac = new List<Body_System_Specs>();
        public double cardiac_PV

        public Body_Systems()
        {
            sight.Add(new Body_System_Specs("Right Eye", 0.5));
            sight.Add(new Body_System_Specs("Left Eye", 0.5));

            hearing.Add(new Body_System_Specs("Right Ear", 0.5));
            hearing.Add(new Body_System_Specs("Left Ear", 0.5));

            // Sistema respiratório: Nariz 10%, Pulmão 70%, sistema cardíaco 20%
            respiratory.Add(new Body_System_Specs("Lungs", 0.7));
            respiratory.Add(new Body_System_Specs("Nose", 0.1));

            // Sistema cardíaco: Coração 70%, Excretor 10%, 
        }

        public double body_system_get(List<Body_System_Specs> list_of_specs)
        {
            double calc_value = 0;
            foreach (Body_System_Specs spec in list_of_specs)
            {
                calc_value += spec.weight * body.external_limb.Find(item => item.name == spec.name).limb_PV;
            }
            return calc_value;
        }
    }
}
/*
        public double get_PV_value()
        {
            double left_eye_limb_PV = body.external_limb.Find(item => item.name == "Left Eye").limb_PV;
            double right_eye_limb_PV = body.external_limb.Find(item => item.name == "Right Eye").limb_PV;

            return ( (left_eye_limb_PV * 0.5) + (right_eye_limb_PV * 0.5) );
        }
*/

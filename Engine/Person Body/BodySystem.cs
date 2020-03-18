using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class BodySystem
    {
        public string name { get; protected set; }

        public double systemHP
        {
            get { return getHP(); }
            protected set { }
        }

        public class Dependency
        {
            public string name { get; protected set; }
            public double influence { get; protected set; }

            public Dependency(string name, double influence)
            {
                this.name = name;
                this.influence = influence;
            }
        }

        private Body body;
        public List<Dependency> dependencies = new List<Dependency>();

        public BodySystem(string name,
                          double systemHP,
                          List<Dependency> dependencies)
        {
            this.name = name;
            this.systemHP = systemHP;
            this.dependencies = dependencies;
        }

        public double getHP()
        {
            try
            {
                foreach (Dependency limbList in dependencies)
                {

                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

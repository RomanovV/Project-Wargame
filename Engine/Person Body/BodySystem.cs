using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BodySystem
    {
        /// <summary>
        /// Nome do sitema corporal.
        /// </summary>
        public string name { get; protected set; }

        /// <summary>
        /// Abstração do funcionamento de um sistema.
        /// </summary>
        public double hp
        {
            get => getHP();
            protected set { }
        }

        /// <summary>
        /// Classe que define uma dependência de um sistema pelo nome do orgão e/ou sistema
        /// e o valor da influência deste sobre o sistema.
        /// </summary>
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

        /// <summary>
        /// Corpo a qual esse sistema pertence.
        /// </summary>
        private readonly Body body;

        /// <summary>
        /// Lista de dependencias deste sistema.
        /// </summary>
        public List<Dependency> limbDependencies = new List<Dependency>();

        public List<Dependency> systemDependencies = new List<Dependency>();
        /// <summary>
        /// Construtor padrão.
        /// </summary>
        /// <param name="name"> Nome do sistema </param>
        /// <param name="hp">TODO: Esse paramentro faz sentido estar no construtor?</param>
        /// <param name="body">Corpo a qual esse sistema pertence</param>
        /// <param name="limbDependencies">A lista de dependencias desse sistema</param>
        /// <param name="systemDependencies">A lista de dependencias desse sistema</param>
        public BodySystem(string name,
                          double hp,
                          Body body,
                          List<Dependency> limbDependencies,
                          List<Dependency> systemDependencies)
        {
            this.name = name;
            this.hp = hp;
            this.body = body;
            this.limbDependencies = limbDependencies;
            this.systemDependencies = systemDependencies;
        }

        /// <summary>
        /// Metodo que retorna o HP/funcionamento deste sistema baseado
        /// no HP do funcionamento dos orgãos que ele depende.
        /// Escala aditivamente com os Orgãos Externos e Multiplicativamente 
        /// com os orgãos internos.
        /// </summary>
        /// <returns>Retorna um um valor entre 1000 e 0 (0 para erro)</returns>
        public double getHP()
        {
            double calcHP = 1000f;
            try
            {
                foreach (Dependency limb in limbDependencies)
                {
                    calcHP -= body.internalLimbs.Find(item => item.name == limb.name).hp * limb.influence;
                }
                foreach (Dependency system in systemDependencies)
                {
                    calcHP *= body.bodySystems.Find(item => item.name == system.name).hp * system.influence;
                }
                return calcHP >= 0 ? calcHP : 0f;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong when trying to calculate Body System HP, ERROR: " + ex);
                return 0f;
            }
        }
    }
}

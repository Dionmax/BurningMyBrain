using System;
using System.Collections.Generic;
using System.Text;

namespace Aula118_Composicao1_Exercicios
{
    class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
		
		public double GerarRenda(){
			return 100;
		}
    }
}

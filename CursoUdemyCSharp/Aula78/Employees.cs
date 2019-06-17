using System;
using System.Collections.Generic;
using System.Text;

namespace Aula78 {

    class Employees {

        public int id;
        private string _name;
        public float salario;

        public Employees() { }
        public Employees(int id, string name) { setName(name); setId(id); }
        public Employees(int id, string name, float salario) : this() { setSalario(salario); }

        private void setId(int id)
            => this.id = id;

        private void setName(string name)
            => _name = name;

        private void setSalario(float salario)
            => this.salario = salario;

        public void aumentarSalario(float aumento)
            => salario += salario * aumento / 100;

        public override string ToString() {
            return "\nId: " + id + "\nNome: " + _name + "\nSalario: " + salario;
        }
    }
}

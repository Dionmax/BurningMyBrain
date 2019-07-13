using System;
using System.Collections.Generic;
using System.Text;

namespace Aula145_ExercicioFixacao.Entities.Exeption
{
    class AccountExeption : ApplicationException
    {
        public AccountExeption(string exeption) : base(exeption) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula145_ExercicioFixacao.Entities.Exception
{
    class AccountException : ApplicationException
    {
        public AccountException(string exception) : base(exception) { }
    }
}

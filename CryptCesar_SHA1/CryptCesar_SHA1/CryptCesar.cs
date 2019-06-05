using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCesar_SHA1
{
    class CryptCesar
    {
        private int letra;
        private string mensagem;
        public string decriptMensagem(string mensagem, int salto)
        {
            for (int contador = 0; contador < mensagem.Length; contador++)
            {
                letra = Convert.ToInt32(mensagem[contador]) - salto;

                if (letra < 97)
                    letra = 32;

                this.mensagem += Char.ConvertFromUtf32(letra);
            }

            return this.mensagem;
        }

    }
}

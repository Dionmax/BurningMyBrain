using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptCesar_SHA1
{
    class Program
    {
        const string URL = "https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=0e7297e2922537c4fea422ffd04232ae645c6544";
        static void Main(string[] args)
        {
            InteracaoJson interacao = new InteracaoJson(URL);
            CryptCesar descript = new CryptCesar();

            Console.Write(descript.decriptMensagem(interacao.getAtributoJson("cifrado"),
                Convert.ToInt32(interacao.getAtributoJson("numero_casas")))
                );

            //Console.Write(interacao.getAtributoJson("cifrado"));
            //Console.Write("\n");
            //Console.Write(Convert.ToInt32(interacao.getAtributoJson("numero_casas")));

            Console.ReadKey();

            SHA1 sha;
        }
    }
}

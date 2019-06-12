using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptCesar_SHA1
{
    class Program
    {
        const string URL = "https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=0e7297e2922537c4fea422ffd04232ae645c6544";
        const string RespoUrl = "https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=0e7297e2922537c4fea422ffd04232ae645c6544";

        public async void Sent()
        {
            InteracaoJson interacaoJson = new InteracaoJson();

            var enviado = await interacaoJson.sentPost(RespoUrl);

            Console.ReadKey();

            if (enviado)
                Console.WriteLine("Enviado");
            else
                Console.WriteLine("Error");
        }
        static void Main(string[] args)
        {
            CryptCesar cesar = new CryptCesar();
            Crypt_SHA1 sha1 = new Crypt_SHA1();

            Program enviar = new Program();

            enviar.Sent();

            Console.ReadKey();
        }
    }
}

//Console.WriteLine(cesar.decriptMensagem((string) jObject.GetValue("cifrado"), (int) jObject.GetValue("numero_casas")));
// var interacao = JsonConvert.DeserializeObject<InteracaoJson>(answerJson);
// Console.WriteLine(sha1.SHA1HashStringForUTF8String((string)jObject.GetValue("decifrado")));
//Console.WriteLine(jObject);

//Console.WriteLine(answerJson);
//interacao.numero_casas = (int)jObject.GetValue("numero_casas");
//jObject.GetValue("token");
//jObject.GetValue("cifrado");
//jObject.GetValue("decifrado");
//jObject.GetValue("resumo_criptografico");

//JObject jObject = JObject.Parse(answerJson);

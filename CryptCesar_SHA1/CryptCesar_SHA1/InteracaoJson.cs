using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptCesar_SHA1
{
    class InteracaoJson
    {
        private string url;
        private JObject jObject;
        public InteracaoJson(string url)
        {
            this.url = url;
            getJson();
        }

        public string getAtributoJson(String nomeParametro)
        {
            return jObject.GetValue(nomeParametro).ToString();
        }
        private JObject getJson()
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                string jsonValue = "";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    jsonValue = reader.ReadToEnd();
                }

                this.jObject = JObject.Parse(jsonValue);

                return this.jObject;
            }
            catch (JsonException) {
                Console.Write("Falha ao pegar Json");
            }

            return this.jObject;
        }
    }
}

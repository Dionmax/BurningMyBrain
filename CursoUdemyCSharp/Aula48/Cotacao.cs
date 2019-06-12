using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System;

namespace Aula48 {
    class Cotacao {

        private string _urlHGFinance = "https://api.hgbrasil.com/finance?format=json&key=e4d3ec9c";
        private JObject jObject = new JObject();

        public Cotacao() {
            GenetareObjJson();
        }

        private void GenetareObjJson() {
            try {
                HttpWebRequest request = HttpWebRequest.Create(_urlHGFinance) as HttpWebRequest;
                string jsonValue = "";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    jsonValue = reader.ReadToEnd();
                }

                this.jObject = JObject.Parse(jsonValue);
            }
            catch (JsonException) {
                Console.Write("Falha ao pegar Json");
            }
        }

        public double GetDolarValueBuy() {
            return (double)jObject.SelectToken("results.currencies.USD.buy");
        }

        public double GetDolarValueSell() {
            return (double)jObject.SelectToken("results.currencies.USD.sell");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptCesar_SHA1
{

    class InteracaoJson
    {
        public async Task<bool> sentPost(string RespoUrl)
        {
            var answerJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\answer.json");

            var client = new HttpClient();
            client.BaseAddress = new Uri(RespoUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("multipart/form-data"));

           // string json = JsonConvert.SerializeObject(answerJson);

            // Envia o json para a API e verifica se obteve sucesso
            HttpResponseMessage response = await client.PostAsync(RespoUrl, new StringContent(answerJson, Encoding.UTF8, "multipart/form-data"));

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}

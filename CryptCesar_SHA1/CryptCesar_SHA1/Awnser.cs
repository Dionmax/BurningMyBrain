using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CryptCesar_SHA1
{
    [DataContract]
    class Awnser
    {
        [DataMember]
        public int numero_casas { get; set; }

        [DataMember]
        public string token { get; set; }

        [DataMember]
        public string cifrado { get; set; }

        [DataMember]
        public string decifrado { get; set; }

        [DataMember]
        public string resumo_criptografico { get; set; }
    }
}

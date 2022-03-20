using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace JsonXml
{
    [Serializable]
    [JsonObject("MovieStore")]
    [DataContract]
    public class LojaDeFilmes
    {
        [JsonProperty("Directors")]
        
        public List<Diretor> Diretores = new List<Diretor>();
        [JsonProperty("Movies")]
        [DataMember]
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }


    [Serializable]
    [JsonObject("Director")]
    [DataContract]
    public class Diretor
    {
        [JsonProperty("Name")]
        public string Nome { get; set; }
        [JsonIgnore]
        [NonSerialized]
        public int NumeroFilmes;
    }

    [Serializable]
    [JsonObject("Movie")]
    [DataContract]
    public class Filme
    {
        [JsonProperty("Director")]
        public Diretor Diretor { get; set; }
        [JsonProperty("Title")]
        [DataMember]
        public string Titulo { get; set; }
        [JsonProperty("Year")]
        [DataMember]
        public string Ano { get; set; }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace JsonXml
{
    [Serializable]
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
    public class Diretor : ISerializable
    {
        public string Nome { get; set; }
        public int NumeroFilmes;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Resumo", $"Marcelo Jaeger {Nome}, {NumeroFilmes}");
        }
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
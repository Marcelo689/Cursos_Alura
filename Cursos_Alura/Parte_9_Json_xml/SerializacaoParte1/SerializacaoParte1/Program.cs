using _01._01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializacaoParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dados = ObterDados();
            var xmlserializer = new XmlSerializer(typeof(LojaDeFilmes));

            using (var stringwriter = new StringWriter())
            {
                xmlserializer.Serialize(stringwriter, dados);
                Console.WriteLine(stringwriter);
            }

            using (var filestream = new FileStream("loja.xml", FileMode.Create))
            {
                xmlserializer.Serialize(filestream, dados);
            }

            // SEgunda parte

            LojaDeFilmes lojaDeFilmes;
            var xmlSerializer2 = new XmlSerializer(typeof(LojaDeFilmes));

            using (var fileStream = new FileStream("loja.xml", FileMode.Open))
            {
                lojaDeFilmes = (LojaDeFilmes)xmlSerializer2.Deserialize(fileStream);
            }

            foreach (var item in lojaDeFilmes.Filmes)
            {
                Console.WriteLine(item.Titulo);
            }

            Console.ReadKey();
        }

        private static LojaDeFilmes ObterDados()
        {
            return new LojaDeFilmes
            {
                Diretores = new List<Diretor>
                {
                    new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                    new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                    new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                    new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                    new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                    new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                    new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                    new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                    new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 }
                },
                Filmes = new List<Filme> {
                    new Filme {
                        Diretor = new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                        Titulo = "Avatar",
                        Ano = "2009"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                        Titulo = "I Am Legend",
                        Ano = "2007"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                        Titulo = "300",
                        Ano = "2006"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                        Titulo = "The Avengers",
                        Ano = "2012"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                        Titulo = "The Wolf of Wall Street",
                        Ano = "2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                        Titulo = "Interstellar",
                        Ano = "2014"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Game of Thrones",
                        Ano = "2011–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Vikings",
                        Ano = "2013–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Gotham",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Power",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Narcos",
                        Ano = "2015–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Breaking Bad",
                        Ano = "2008–2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                        Titulo = "Doctor Strange",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                        Titulo = "Rogue One: A Star Wars Story",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 },
                        Titulo = "Assassin's Creed",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Luke Cage",
                        Ano = "2016–"
                    }
                }
            };
        }
    }
}

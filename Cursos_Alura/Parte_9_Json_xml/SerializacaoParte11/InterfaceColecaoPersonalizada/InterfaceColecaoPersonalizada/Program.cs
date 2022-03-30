
using System.Collections;
using System.Text.RegularExpressions;

namespace InterfaceColecaoPersonalizada
{
    class Program
    {
        static PlacasDeCarro placas = new PlacasDeCarro();
        static void Main(string [] args)
        {
            //Console.WriteLine("Marcelo");

            placas.Add("FND 7714");
            placas.Add("ABC 1234");
            placas.Add("XYZ 9987");

            foreach (var placa in placas)
            {
                Console.WriteLine(placa);
            }

        }
        static bool EhPlacaValida(string numero)
        {
            Regex padrao = new Regex(@"[A-Z]{3} [0-9]{4}");
            Match retorno = padrao.Match(numero);
            //Console.WriteLine(retorno.Success);
            return retorno.Success;
        }
        class PlacasDeCarro : ICollection<string>
        {
            private List<string> lista = new List<string>();
            public int Count => lista.Count;

            public bool IsReadOnly => false;

            public void Add(string item)
            {
                if(EhPlacaValida(item))
                lista.Add(item);
            }

            public void Clear()
            {
                lista.Clear();
            }

            public bool Contains(string item)
            {
                return lista.Contains(item);
            }

            public void CopyTo(string[] array, int arrayIndex)
            {
                lista.CopyTo(array, arrayIndex);
            }

            public IEnumerator<string> GetEnumerator()
            {
                return lista.GetEnumerator();
            }

            public bool Remove(string item)
            {
                return lista.Remove(item);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return lista.GetEnumerator();
            }
        }
    }
}
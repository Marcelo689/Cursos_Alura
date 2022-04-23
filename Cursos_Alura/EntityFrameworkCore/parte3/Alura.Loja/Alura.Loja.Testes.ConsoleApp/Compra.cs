namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public Compra()
        {
        }
        public int Id { get; internal set; }
        public double Quantidade { get; internal set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }
    }
}
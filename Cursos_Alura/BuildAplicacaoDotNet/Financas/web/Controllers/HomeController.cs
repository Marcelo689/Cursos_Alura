using Microsoft.AspNetCore.Mvc;
using Alura.financas.Modelos;
namespace Alura.FinancasWeb.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var cliente = new Cliente("Fulano de tal");
			var conta = new Conta("12387-12", cliente);
			conta.Deposita(500);
			conta.Saca(200);
			return Ok("Alô, mundo!");
		}
	}
}
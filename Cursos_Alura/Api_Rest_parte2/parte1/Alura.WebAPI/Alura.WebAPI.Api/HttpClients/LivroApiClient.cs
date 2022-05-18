using Alura.ListaLeitura.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Alura.WebAPI.WebApp.HttpClients
{
    public class LivroApiClient
    {
        public HttpClient _httpClient { get; private set; }

        public LivroApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri("http://localhost:44365/api/");
        }
        public async Task<LivroApi> GetLivroAsync(int id)
        {
            HttpResponseMessage resposta = await _httpClient.GetAsync($"livros/{id}");
            resposta.EnsureSuccessStatusCode();

            return await resposta.Content.ReadAsAsync<LivroApi>();
        }
        public async Task<byte []> GetCapaLivroAsync(int id)
        {
            HttpResponseMessage resposta = await _httpClient.GetAsync($"livros/{id}/capa");
            resposta.EnsureSuccessStatusCode();

            return await resposta.Content.ReadAsByteArrayAsync();
        }
        
        public async Task DeleteLivroAsync(int id)
        {
            HttpResponseMessage resposta = await _httpClient.DeleteAsync($"livros/{id}");
            resposta.EnsureSuccessStatusCode();

        }
    }
}

using Alura.ListaLeitura.Modelos;
using Lista = Alura.ListaLeitura.Modelos.ListaLeitura;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Alura.WebAPI.WebApp.HttpClients
{
    public class LivroApiClient
    {
        public HttpClient _httpClient { get; private set; }

        public LivroApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri("http://localhost:6000/api/");
        }
        //private void AddBearerToken()
        //{
        //    var token = _acessor.HttpContext.User.Claims.First(c => c.Type == "Token").Value;
        //    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //}
        public async Task<Lista> GetListaLeituraAsync(TipoListaLeitura tipo)
        {
            //AddBearerToken();

            var resposta = await _httpClient.GetAsync($"listasleitura/{tipo}");
            resposta.EnsureSuccessStatusCode();
            return await resposta.Content.ReadAsAsync<Lista>();
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

        private string EnvolveComAspasDuplas(string entrada)
        {
            return $"\"{entrada}\"";
        }

        public async Task PostLivroAsync(LivroUpload model)
        {
            HttpContent content = CreateMultiparFormDataContent(model);
            var resposta = await _httpClient.PostAsync("livros", content);
            resposta.EnsureSuccessStatusCode();
        }

        public async Task PutLivroAsync(LivroUpload model)
        {
            HttpContent content = CreateMultiparFormDataContent(model);
            var resposta = await _httpClient.PutAsync("livros", content);
            resposta.EnsureSuccessStatusCode();
        }

        private HttpContent CreateMultiparFormDataContent(LivroUpload model)
        {
            var content = new MultipartFormDataContent();
            content.Add(new StringContent(model.Titulo), EnvolveComAspasDuplas("titulo"));
            content.Add(new StringContent(model.Lista.ParaString()), EnvolveComAspasDuplas("capa"));

            if (!string.IsNullOrEmpty(model.Subtitulo))
            {
               content.Add(new StringContent(model.Subtitulo), EnvolveComAspasDuplas("subtitulo"));
            }
            if (!string.IsNullOrEmpty(model.Resumo))
            {
               content.Add(new StringContent(model.Resumo), EnvolveComAspasDuplas("resumo"));
            }
            if (!string.IsNullOrEmpty(model.Autor))
            {
               content.Add(new StringContent(model.Autor), EnvolveComAspasDuplas("autor"));
            }

            if(model.Id > 0)
            {
                content.Add(new StringContent(model.Id.ToString()), EnvolveComAspasDuplas("id"));
            }

            if(model.Capa != null)
            {
                var imagemContent = new ByteArrayContent(model.Capa.ConvertToBytes());
                imagemContent.Headers.Add("content-type", "image/png");
                content.Add(imagemContent,
                    EnvolveComAspasDuplas("capa"),
                    EnvolveComAspasDuplas("capa.png")
                    );
            }
            return content;
        }
    }
}

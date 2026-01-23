using MSE.WebApp.MVC.Models;
using System.Text;
using System.Text.Json;


namespace MSE.WebApp.MVC.Services
{
    public class AutenticacaoService : IAutenticacaoService

    {
        private readonly HttpClient _httpClient;
        public AutenticacaoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin)
        {
            /*var loginContent = new StringContent(
                JsonSerializer.Serialize(usuarioLogin),
                Encoding.UTF8,
                "application/json");*/

            var apiPath = "https://localhost:44309/api/identidade/autenticar";
            var response = await _httpClient.PostAsJsonAsync(apiPath, usuarioLogin);
            
            var teste = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync(), options);
        }

        public async Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro)
        {
            /*var registroContent = new StringContent(
               JsonSerializer.Serialize(usuarioRegistro),
               Encoding.UTF8,
               "application/json");*/

            var apiPath = "https://localhost:44309/api/identidade/nova-conta";
            var response = await _httpClient.PostAsJsonAsync(apiPath, usuarioRegistro);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync(), options);
        }
    }
}

using WEBAPI5363922.Modelo;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WEBAPI5363922.Servicios
{
    public class RickAndMortyService : IRickAndMortyServices
    {
        private string urlApi = "https://rickandmortyapi.com/api/character";
        public async Task<List<PersonajesResponse>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var personajesData = JsonSerializer.Deserialize<List<PersonajesResponse>>(results.ToString());
            return personajesData;
        }
    }
}

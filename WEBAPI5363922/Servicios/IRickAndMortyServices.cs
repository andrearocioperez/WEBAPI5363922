using WEBAPI5363922.Modelo;

namespace WEBAPI5363922.Servicios
{
    public interface IRickAndMortyServices
    {
        public Task<List<PersonajesResponse>> Obtener();
    }
}

using System.Net.Http.Json;

namespace BlazingPizza.Services;

public class PizzaService
{
    private readonly HttpClient _httpClient;

    public PizzaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PizzaSpecial[]> GetSpecialsAsync()
    {
        return await _httpClient.GetFromJsonAsync<PizzaSpecial[]>("specials") ?? Array.Empty<PizzaSpecial>();
    }
}

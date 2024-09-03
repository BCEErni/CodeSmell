using System.Net.Http.Json;

namespace CodeRefactor;
public class UserData
{
    private readonly HttpClient _client;

    public UserData()
    {
        // Please make use of DI to inject the dependency.
        _client = new HttpClient();
    }

    public async Task<List<Users>?> GetUsersAsync(string apiUrl)
    {

        try
        {
            return await _client.GetFromJsonAsync<List<Users>>(apiUrl);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error {e.Message}");

            // Consider returning empty list instead of null
            return null;
        }
    }
}
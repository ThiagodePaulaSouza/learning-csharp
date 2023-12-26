namespace Helpers.Services;

public class HttpClientService
{
    public async Task<string> FakeUserIntegrationApi()
    {
        using HttpClient client = new HttpClient();
        var result = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
        result.EnsureSuccessStatusCode();
        if (!result.IsSuccessStatusCode)
        {
            throw new Exception();
        }

        return await result.Content.ReadAsStringAsync();
    }
}
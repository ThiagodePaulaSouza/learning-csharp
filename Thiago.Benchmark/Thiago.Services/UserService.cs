using Newtonsoft.Json;

namespace Thiago.Services;

public class UserService
{
    private readonly HttpClientService _clientService;
    public UserService(HttpClientService clientService)
    {
        _clientService = clientService;
    }

    public async Task<List<UserNameObject>> Get10Users()
    {
        var fakeUserJson = await _clientService.FakeUserIntegrationApi();
        var users = JsonConvert.DeserializeObject<List<UserNameObject>>(fakeUserJson) ?? throw new Exception();
        return users ?? [];
    }
}
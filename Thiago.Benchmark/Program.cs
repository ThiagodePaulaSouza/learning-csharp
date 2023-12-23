using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace Thiago.Program;

public class CountxAnyxExist
{
    [Benchmark]
    public async Task<bool> Count_Get10UsersMatchName()
    {
        var mock = new MockData();
        var users = await mock.Get10Users();

        return users.Count(x => x.Name == "Leanne Graham") > 0;
    }

    [Benchmark]
    public async Task<bool> Any_Get10UsersMatchName()
    {
        var mock = new MockData();
        var users = await mock.Get10Users();

        return users.Any(x => x.Name == "Leanne Graham");
    }

    [Benchmark]
    public async Task<bool> Exists_Get10UsersMatchName()
    {
        var mock = new MockData();
        var users = await mock.Get10Users();

        return users.Exists(x => x.Name == "Leanne Graham");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<CountxAnyxExist>();
    }
}

public class MockData
{
    public async Task<List<SimpleUserName>> Get10Users()
    {
        var fakeUserJson = await FakeUserIntegrationApi();
        var users = JsonConvert.DeserializeObject<List<SimpleUserName>>(fakeUserJson) ?? throw new Exception();
        return users;
    }

    private async Task<string> FakeUserIntegrationApi()
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

public record SimpleUserName(string Name);

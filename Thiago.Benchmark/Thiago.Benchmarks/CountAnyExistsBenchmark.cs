using BenchmarkDotNet.Attributes;
using Thiago.Services;

namespace Thiago.Benchmarks;

public class CountAnyExistBenchmark
{

    [Benchmark]
    public async Task<bool> Count_Get10UsersMatchName()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();
        return users.Count(x => x.Name == "Leanne Graham") > 0;
    }

    [Benchmark]
    public async Task<bool> Any_Get10UsersMatchName()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();
        return users.Any(x => x.Name == "Leanne Graham");
    }

    [Benchmark]
    public async Task<bool> Exists_Get10UsersMatchName()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();
        return users.Exists(x => x.Name == "Leanne Graham");
    }
}
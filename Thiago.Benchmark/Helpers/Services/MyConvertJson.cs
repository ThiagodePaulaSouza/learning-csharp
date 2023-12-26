using Newtonsoft.Json;

namespace Helpers.Services;

public class MyConvertJson
{
    public async Task<T> ConvertJson<T>(string path)
    {
        using StreamReader reader = new StreamReader(path);
        string json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<T>(json) ?? throw new Exception();
    }
}
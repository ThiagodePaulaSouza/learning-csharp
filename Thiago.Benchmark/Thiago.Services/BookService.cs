using Newtonsoft.Json;
using Thiago.Objects;

namespace Thiago.Services;

public class BookService
{
    private readonly MyConvertJson _json;
    public BookService(MyConvertJson convertJson)
    {
        _json = convertJson;
    }

    public async Task<List<BookIdObject>> Get1000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"..\..\Thiago.Benchmark\Thiago.Fixtures\book-1000.json");
    public async Task<List<BookIdObject>> Get5000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"..\..\Thiago.Benchmark\Thiago.Fixtures\book-5000.json");
    public async Task<List<BookIdObject>> Get10000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"..\..\Thiago.Benchmark\Thiago.Fixtures\book-10000.json");
}
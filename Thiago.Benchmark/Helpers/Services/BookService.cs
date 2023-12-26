using Newtonsoft.Json;
using Helpers.Objects;

namespace Helpers.Services;

public class BookService
{
    private readonly MyConvertJson _json;
    public BookService(MyConvertJson convertJson)
    {
        _json = convertJson;
    }

    public async Task<List<BookIdObject>> Get1000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"C:\Users\m8dev\OneDrive\Documentos\PPRJs\learning-csharp\Thiago.Benchmark\Helpers\Fixtures\book-1000.json");
    public async Task<List<BookIdObject>> Get5000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"C:\Users\m8dev\OneDrive\Documentos\PPRJs\learning-csharp\Thiago.Benchmark\Helpers\Fixtures\book-5000.json");
    public async Task<List<BookIdObject>> Get10000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"C:\Users\m8dev\OneDrive\Documentos\PPRJs\learning-csharp\Thiago.Benchmark\Helpers\Fixtures\book-10000.json");
    public async Task<List<BookIdObject>> Get100000BookId() => await _json.ConvertJson<List<BookIdObject>>(@"C:\Users\m8dev\OneDrive\Documentos\PPRJs\learning-csharp\Thiago.Benchmark\Helpers\Fixtures\book-100000.json");
    public async Task<List<BookIdObject>> Get100000000BookId()
    {
        var million = new List<BookIdObject>();
        for (int i = 0; i < 10; i++)
        {
            var books = await _json.ConvertJson<List<BookIdObject>>(@"C:\Users\m8dev\OneDrive\Documentos\PPRJs\learning-csharp\Thiago.Benchmark\Helpers\Fixtures\book-100000.json");
            million.AddRange(books);
        }
        return million;
    }
}
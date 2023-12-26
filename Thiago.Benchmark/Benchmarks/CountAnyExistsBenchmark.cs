using BenchmarkDotNet.Attributes;
using Helpers.Services;

namespace Benchmarks;

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

    [Benchmark]
    public async Task<bool> Count_Get1000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();
        return books.Count(x => x.Id == 1) > 0;
    }

    [Benchmark]
    public async Task<bool> Any_Get1000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();
        return books.Any(x => x.Id == 1);
    }

    [Benchmark]
    public async Task<bool> Exists_Get1000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();
        return books.Exists(x => x.Id == 1);
    }

    [Benchmark]
    public async Task<bool> Count_Get5000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();
        return books.Count(x => x.Id == 1) > 0;
    }

    [Benchmark]
    public async Task<bool> Any_Get5000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();
        return books.Any(x => x.Id == 1);
    }

    [Benchmark]
    public async Task<bool> Exists_Get5000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();
        return books.Exists(x => x.Id == 1);
    }

    [Benchmark]
    public async Task<bool> Count_Get10000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();
        return books.Count(x => x.Id == 1) > 0;
    }

    [Benchmark]
    public async Task<bool> Any_Get10000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();
        return books.Any(x => x.Id == 1);
    }

    [Benchmark]
    public async Task<bool> Exists_Get10000BooksMatchId()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();
        return books.Exists(x => x.Id == 1);
    }
}
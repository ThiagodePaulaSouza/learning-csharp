using BenchmarkDotNet.Attributes;
using Helpers.Services;

namespace Benchmarks;

public class SwitchCasePatternMatchingBenchmark
{

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get10UsersMatchName_ReturnAttrValue()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();

        bool founded = false;
        foreach (var user in users)
        {
            switch (user.Name)
            {
                case "Leanne Graham":
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get10UsersMatchName_ReturnAttrValue()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();

        bool founded = false;
        foreach (var user in users)
        {
            founded = user.Name switch
            {
                "Leanne Graham" => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get10UsersMatchName_ReturnAttrValue()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();

        bool founded = false;
        users.ForEach(x =>
        {
            switch (x.Name)
            {
                case "Leanne Graham":
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });


        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get10UsersMatchName_ReturnAttrValue()
    {
        var userService = new UserService(new HttpClientService());
        var users = await userService.Get10Users();

        bool founded = false;
        users.ForEach(x =>
        {
            founded = x.Name switch
            {
                "Leanne Graham" => true,
                _ => false,
            };
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get1000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            switch (user.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get1000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            founded = user.Id switch
            {
                1 => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get1000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            switch (x.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });


        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get1000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get1000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            founded = x.Id switch
            {
                1 => true,
                _ => false,
            };
        });


        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get5000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            switch (user.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get5000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            founded = user.Id switch
            {
                1 => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get5000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            switch (x.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });


        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get5000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get5000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            founded = x.Id switch
            {
                1 => true,
                _ => false,
            };
        });


        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get10000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            switch (user.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get10000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            founded = user.Id switch
            {
                1 => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get10000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            switch (x.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get10000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get10000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            founded = x.Id switch
            {
                1 => true,
                _ => false,
            };
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get100000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            switch (user.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get100000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            founded = user.Id switch
            {
                1 => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get100000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            switch (x.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get100000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            founded = x.Id switch
            {
                1 => true,
                _ => false,
            };
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_foreach_Enumerable_Get100000000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            switch (user.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }

        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_foreach_Enumerable_Get100000000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000000BookId();

        bool founded = false;
        foreach (var user in books)
        {
            founded = user.Id switch
            {
                1 => true,
                _ => false,
            };
        }

        return founded;
    }

    [Benchmark]
    public async Task<bool> NormalSwitchCase_ForEach_Generic_Get100000000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            switch (x.Id)
            {
                case 1:
                    founded = true;
                    break;
                default:
                    founded = false;
                    break;
            }
        });

        return founded;
    }

    [Benchmark]
    public async Task<bool> PatternMatchingSwitchCase_ForEach_Generic_Get100000000BooksMatchId_ReturnAttrValue()
    {
        var bookService = new BookService(new MyConvertJson());
        var books = await bookService.Get100000000BookId();

        bool founded = false;
        books.ForEach(x =>
        {
            founded = x.Id switch
            {
                1 => true,
                _ => false,
            };
        });

        return founded;
    }
}
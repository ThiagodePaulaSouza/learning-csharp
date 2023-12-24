```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                      | Mean       | Error      | StdDev      | Median     |
|---------------------------- |-----------:|-----------:|------------:|-----------:|
| Count_Get10UsersMatchName   | 209.555 ms | 44.4004 ms | 130.9156 ms | 196.939 ms |
| Any_Get10UsersMatchName     | 227.628 ms | 60.1100 ms | 177.2356 ms | 345.372 ms |
| Exists_Get10UsersMatchName  | 185.814 ms | 31.7880 ms |  92.2227 ms | 147.344 ms |
| Count_Get1000BooksMatchId   |   1.207 ms |  0.0240 ms |   0.0373 ms |   1.198 ms |
| Any_Get1000BooksMatchId     |   1.214 ms |  0.0239 ms |   0.0372 ms |   1.215 ms |
| Exists_Get1000BooksMatchId  |   1.209 ms |  0.0239 ms |   0.0357 ms |   1.201 ms |
| Count_Get5000BooksMatchId   |   5.826 ms |  0.1044 ms |   0.2482 ms |   5.789 ms |
| Any_Get5000BooksMatchId     |   5.610 ms |  0.1073 ms |   0.1357 ms |   5.600 ms |
| Exists_Get5000BooksMatchId  |   5.629 ms |  0.1086 ms |   0.1207 ms |   5.582 ms |
| Count_Get10000BooksMatchId  |  13.019 ms |  0.2370 ms |   0.3689 ms |  13.050 ms |
| Any_Get10000BooksMatchId    |  12.639 ms |  0.2511 ms |   0.3084 ms |  12.676 ms |
| Exists_Get10000BooksMatchId |  12.788 ms |  0.2475 ms |   0.3628 ms |  12.891 ms |

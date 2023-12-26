```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                          | Mean         | Error      | StdDev      |
|-------------------------------- |-------------:|-----------:|------------:|
| Count_Get10UsersMatchName       |   348.729 ms |  6.7908 ms |   6.3521 ms |
| Any_Get10UsersMatchName         |   346.107 ms |  2.9736 ms |   2.6360 ms |
| Exists_Get10UsersMatchName      |   346.289 ms |  3.2436 ms |   2.7085 ms |
| Count_Get1000BooksMatchId       |     1.844 ms |  0.0762 ms |   0.2248 ms |
| Any_Get1000BooksMatchId         |     1.886 ms |  0.0741 ms |   0.2127 ms |
| Exists_Get1000BooksMatchId      |     1.741 ms |  0.0370 ms |   0.1037 ms |
| Count_Get5000BooksMatchId       |     6.967 ms |  0.1384 ms |   0.3445 ms |
| Any_Get5000BooksMatchId         |     6.677 ms |  0.2653 ms |   0.7821 ms |
| Exists_Get5000BooksMatchId      |     6.601 ms |  0.1801 ms |   0.5139 ms |
| Count_Get10000BooksMatchId      |    15.014 ms |  0.3928 ms |   1.1143 ms |
| Any_Get10000BooksMatchId        |    14.529 ms |  0.2880 ms |   0.8264 ms |
| Exists_Get10000BooksMatchId     |    14.691 ms |  0.2843 ms |   0.7637 ms |
| Count_Get100000BooksMatchId     |   170.273 ms |  6.9510 ms |  20.2763 ms |
| Any_Get100000BooksMatchId       |   179.143 ms |  5.1230 ms |  14.6989 ms |
| Exists_Get100000BooksMatchId    |   182.073 ms |  8.7250 ms |  25.4513 ms |
| Count_Get100000000BooksMatchId  | 1,728.668 ms | 44.1070 ms | 127.9624 ms |
| Any_Get100000000BooksMatchId    | 1,746.400 ms | 60.1964 ms | 177.4906 ms |
| Exists_Get100000000BooksMatchId | 1,769.982 ms | 67.5680 ms | 197.0990 ms |

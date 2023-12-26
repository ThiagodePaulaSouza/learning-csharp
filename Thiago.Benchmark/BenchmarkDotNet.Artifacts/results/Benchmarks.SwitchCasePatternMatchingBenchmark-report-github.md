```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                                                                | Mean         | Error      | StdDev      | Median       |
|-------------------------------------------------------------------------------------- |-------------:|-----------:|------------:|-------------:|
| NormalSwitchCase_foreach_Enumerable_Get10UsersMatchName_ReturnAttrValue               |   196.695 ms | 31.9721 ms |  91.7341 ms |   151.566 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get10UsersMatchName_ReturnAttrValue      |   243.106 ms | 69.4428 ms | 204.7537 ms |   346.644 ms |
| NormalSwitchCase_ForEach_Generic_Get10UsersMatchName_ReturnAttrValue                  |   222.281 ms | 68.5370 ms | 202.0830 ms |    58.242 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get10UsersMatchName_ReturnAttrValue         |   207.536 ms | 62.4350 ms | 184.0910 ms |    57.436 ms |
| NormalSwitchCase_foreach_Enumerable_Get1000BooksMatchId_ReturnAttrValue               |     1.659 ms |  0.0922 ms |   0.2705 ms |     1.633 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get1000BooksMatchId_ReturnAttrValue      |     1.355 ms |  0.0342 ms |   0.0960 ms |     1.323 ms |
| NormalSwitchCase_ForEach_Generic_Get1000BooksMatchId_ReturnAttrValue                  |     1.422 ms |  0.0284 ms |   0.0810 ms |     1.412 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get1000BooksMatchId_ReturnAttrValue         |     1.461 ms |  0.0388 ms |   0.1101 ms |     1.431 ms |
| NormalSwitchCase_foreach_Enumerable_Get5000BooksMatchId_ReturnAttrValue               |     5.859 ms |  0.1321 ms |   0.3810 ms |     5.785 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get5000BooksMatchId_ReturnAttrValue      |     5.711 ms |  0.1135 ms |   0.2214 ms |     5.707 ms |
| NormalSwitchCase_ForEach_Generic_Get5000BooksMatchId_ReturnAttrValue                  |     5.763 ms |  0.1119 ms |   0.2479 ms |     5.779 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get5000BooksMatchId_ReturnAttrValue         |     6.052 ms |  0.1950 ms |   0.5625 ms |     5.910 ms |
| NormalSwitchCase_foreach_Enumerable_Get10000BooksMatchId_ReturnAttrValue              |    12.734 ms |  0.2544 ms |   0.6476 ms |    12.726 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get10000BooksMatchId_ReturnAttrValue     |    12.860 ms |  0.2562 ms |   0.7185 ms |    12.785 ms |
| NormalSwitchCase_ForEach_Generic_Get10000BooksMatchId_ReturnAttrValue                 |    12.879 ms |  0.3159 ms |   0.9012 ms |    12.688 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get10000BooksMatchId_ReturnAttrValue        |    12.823 ms |  0.2481 ms |   0.6707 ms |    12.717 ms |
| NormalSwitchCase_foreach_Enumerable_Get100000BooksMatchId_ReturnAttrValue             |   148.652 ms |  2.9689 ms |   7.1702 ms |   147.869 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get100000BooksMatchId_ReturnAttrValue    |   142.619 ms |  5.1725 ms |  15.0886 ms |   139.094 ms |
| NormalSwitchCase_ForEach_Generic_Get100000BooksMatchId_ReturnAttrValue                |   148.730 ms |  2.9674 ms |   8.0224 ms |   147.836 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get100000BooksMatchId_ReturnAttrValue       |   154.299 ms |  4.6309 ms |  13.5816 ms |   152.929 ms |
| NormalSwitchCase_foreach_Enumerable_Get100000000BooksMatchId_ReturnAttrValue          | 1,481.504 ms | 29.6007 ms |  82.0234 ms | 1,481.778 ms |
| PatternMatchingSwitchCase_foreach_Enumerable_Get100000000BooksMatchId_ReturnAttrValue | 1,458.332 ms | 28.8635 ms |  29.6406 ms | 1,467.894 ms |
| NormalSwitchCase_ForEach_Generic_Get100000000BooksMatchId_ReturnAttrValue             | 1,481.001 ms | 28.9206 ms |  39.5869 ms | 1,468.967 ms |
| PatternMatchingSwitchCase_ForEach_Generic_Get100000000BooksMatchId_ReturnAttrValue    | 1,410.756 ms | 27.8796 ms |  65.7156 ms | 1,397.723 ms |

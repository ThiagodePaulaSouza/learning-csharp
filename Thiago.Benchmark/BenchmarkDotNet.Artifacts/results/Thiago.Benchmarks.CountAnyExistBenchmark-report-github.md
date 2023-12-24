```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                     | Mean     | Error    | StdDev   |
|--------------------------- |---------:|---------:|---------:|
| Count_Get10UsersMatchName  | 260.1 ms | 24.51 ms | 72.26 ms |
| Any_Get10UsersMatchName    | 345.1 ms |  5.02 ms |  4.45 ms |
| Exists_Get10UsersMatchName | 342.9 ms |  2.46 ms |  2.18 ms |

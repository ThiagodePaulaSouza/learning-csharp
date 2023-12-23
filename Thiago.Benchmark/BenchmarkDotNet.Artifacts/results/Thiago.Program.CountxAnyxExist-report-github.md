```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method | Mean     | Error    | StdDev    | Median    |
|------- |---------:|---------:|----------:|----------:|
| Count  | 218.3 ms | 28.39 ms |  83.70 ms | 206.72 ms |
| Any    | 218.7 ms | 27.97 ms |  82.46 ms | 203.93 ms |
| Exists | 192.8 ms | 62.78 ms | 185.10 ms |  51.83 ms |

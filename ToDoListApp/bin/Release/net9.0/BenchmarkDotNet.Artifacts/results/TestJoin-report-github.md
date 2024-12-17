```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5198/22H2/2022Update)
Intel Core i5-4440 CPU 3.10GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK 9.0.100-rc.2.24474.11
  [Host]     : .NET 9.0.0 (9.0.24.47305), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.47305), X64 RyuJIT AVX2


```
| Method   | Mean     | Error    | StdDev   | Gen0   | Allocated |
|--------- |---------:|---------:|---------:|-------:|----------:|
| Join     | 35.36 ns | 0.400 ns | 0.375 ns | 0.0255 |      80 B |
| plusPlus | 59.95 ns | 0.351 ns | 0.311 ns | 0.0509 |     160 B |

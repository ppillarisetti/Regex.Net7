``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22543
Unknown processor
.NET SDK=7.0.100-preview.1.22110.4
  [Host]     : .NET 7.0.0 (7.0.22.7608), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.7608), X64 RyuJIT


```
|                     Method |       PotentialEmail |       Mean |    Error |    StdDev |     Median | Allocated |
|--------------------------- |--------------------- |-----------:|---------:|----------:|-----------:|----------:|
|          **Old_IsMatch_Email** |    **ppillarisetti.com** |   **537.0 ns** | **39.10 ns** | **112.20 ns** |   **483.9 ns** |         **-** |
| Old_Compiled_IsMatch_Email |    ppillarisetti.com |   279.2 ns | 14.63 ns |  43.14 ns |   278.9 ns |         - |
|          New_IsMatch_Email |    ppillarisetti.com |   282.0 ns | 16.70 ns |  49.25 ns |   289.8 ns |         - |
| New_Compiled_IsMatch_Email |    ppillarisetti.com |   285.8 ns | 22.35 ns |  65.90 ns |   271.9 ns |         - |
|          **Old_IsMatch_Email** | **ppill(...)t.com [23]** | **1,093.5 ns** | **37.67 ns** | **109.29 ns** | **1,064.8 ns** |         **-** |
| Old_Compiled_IsMatch_Email | ppill(...)t.com [23] |   323.1 ns | 18.86 ns |  51.95 ns |   301.4 ns |         - |
|          New_IsMatch_Email | ppill(...)t.com [23] |   352.7 ns | 12.90 ns |  37.41 ns |   352.5 ns |         - |
| New_Compiled_IsMatch_Email | ppill(...)t.com [23] |   376.4 ns | 16.88 ns |  49.77 ns |   362.1 ns |         - |

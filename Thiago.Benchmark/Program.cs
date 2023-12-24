using BenchmarkDotNet.Running;
using Thiago.Benchmarks;

namespace Thiago.Program;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<CountAnyExistBenchmark>();
    }
}

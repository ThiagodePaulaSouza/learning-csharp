using BenchmarkDotNet.Running;
using Benchmarks;

namespace Thiago.Program;

public class Program
{
    public static void Main(string[] args)
    {
        // var summary = BenchmarkRunner.Run<CountAnyExistBenchmark>();
        var summary = BenchmarkRunner.Run<SwitchCasePatternMatchingBenchmark>();
    }
}

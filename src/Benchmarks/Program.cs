using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Project;

BenchmarkRunner.Run<Benchmarks>();

class Benchmarks
{
    [Benchmark]
    public int Std() => 1 + 2;

    [Benchmark]
    public int Lib() => Calculator.Add(1, 2);
}
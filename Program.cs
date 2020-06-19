using BenchmarkDotNet.Running;

namespace JObjectAgainstReflectionBenchmark
{
    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<BenchmarkGetProperties>();
        }
    }
}

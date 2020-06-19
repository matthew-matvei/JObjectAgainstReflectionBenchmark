using BenchmarkDotNet.Attributes;

namespace JObjectAgainstReflectionBenchmark
{
    [MemoryDiagnoser]
    public class BenchmarkGetProperties
    {
        private SomeModel _model;

        [GlobalSetup]
        public void Setup()
        {
            _model = new SomeModel();
        }

        [Benchmark]
        public (string name, object value)[] BenchmarkJObject() =>
            GetProperties.UsingJObject(_model);

        [Benchmark]
        public (string name, object value)[] BenchmarkReflection() =>
            GetProperties.UsingReflection(_model);
    }
}

using System;

namespace JObjectAgainstReflectionBenchmark
{
    public class SomeModel
    {
        public int Prop1 { get; set; } = 10;
        public string Prop2 { get; set; } = "Blah di blah";
        public Guid Prop3 { get; set; } = Guid.NewGuid();
        public Guid Prop4 { get; set; } = Guid.NewGuid();
        public decimal Prop5 { get; set; } = 100M;
        public float Prop6 { get; set; } = 55.4f;
        public Complex Prop7 { get; set; } = new Complex();
        public object Prop8 { get; set; } = new { anonymous = true };
        public dynamic Prop9 { get; set; } = new { dynamic = true };
        public int Prop10 { get; set; } = 100;

        public class Complex
        {
            public int ComplexProp1 { get; set; } = 20;
            public string ComplexProp2 { get; set; } = "Blah di blah di blah";
        }
    }
}

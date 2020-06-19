using Newtonsoft.Json.Linq;
using System.Linq;

namespace JObjectAgainstReflectionBenchmark
{
    public static class GetProperties
    {
        public static (string name, object value)[] UsingJObject(SomeModel model) =>
            JObject
                .FromObject(model)
                .Properties()
                .Select(property => (name: property.Name, value: property.Value<object>()))
                .ToArray();

        public static (string name, object value)[] UsingReflection(SomeModel model) =>
            model
                .GetType()
                .GetProperties()
                .Select(property => (name: property.Name, value: property.GetValue(model)))
                .ToArray();
    }
}

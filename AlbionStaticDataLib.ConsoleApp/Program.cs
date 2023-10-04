using AlbionStaticDataLib.Json.Items.Models;
using System.Reflection;

namespace AlbionStaticDataLib.ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            List<Type> types = new List<Type> { typeof(Hideoutitem), typeof(Farmableitem),
                typeof(Simpleitem), typeof(Consumableitem),typeof(Consumablefrominventoryitem), typeof(Equipmentitem),
                typeof(Weapon), typeof(Mount),typeof(Furnitureitem), typeof(Mountskin),
                typeof(Journalitem), typeof(Labourercontract),typeof(Crystalleagueitem), typeof(Killtrophy)};

            var commonProperties = GetCommonProperties(types);
            Console.WriteLine($"Common properties count: {commonProperties.Count()}");
            foreach (var prop in commonProperties)
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name} {{ get; set; }}");
            }
            var typeToCheck = typeof(List<Craftingrequirements>);
            var typesWithProperty = GetTypesWithPropertyOfType(types, typeToCheck);
            foreach (var type in typesWithProperty)
            {
                Console.WriteLine(type.Name);
            }
        }

        public static IEnumerable<PropertyInfo> GetCommonProperties(List<Type> types)
        {
            if (types == null || types.Count == 0) return Enumerable.Empty<PropertyInfo>();

            var firstTypeProperties = types[0].GetProperties();

            return firstTypeProperties.Where(p => types.Skip(1).All(t => t.GetProperty(p.Name) != null));
        }
        public static IEnumerable<Type> GetTypesWithPropertyOfType(List<Type> types, Type propertyType)
        {
            return types.Where(t => t.GetProperties().Any(p => p.PropertyType == propertyType));
        }
    }
}

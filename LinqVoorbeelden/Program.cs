using System;
using System.Linq;

namespace LinqVoorbeelden
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. de gegevensbron
            string[] namen = { "Arie", "Bert", "Charles", "Annet", "Barbara", "Cecile", "Dirk" };
            // 2. de query
            var lijstA = from naam in namen
                         where (naam.StartsWith("A", StringComparison.CurrentCultureIgnoreCase))
                         select naam;
            // 3. de uitvoering
            foreach (var naam in lijstA)
            {
                Console.WriteLine("Naam: {0}", naam);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class StringReturn
    {
        private static readonly List<string> Summaries = new List<string>
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static string GetRandomString()
        {
            var rng = new Random();
            return Summaries[rng.Next(Summaries.Count)];
        }

        public static void AddString(string str)
        {
            Summaries.Add(str);
        }

        public static string GetLast()
        {
            return "Добавлен: " + Summaries.Last();
        }
    }
}

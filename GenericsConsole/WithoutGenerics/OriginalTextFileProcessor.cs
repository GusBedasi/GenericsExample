using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace GenericsConsole.WithoutGenerics
{
    public static class OriginalTextFileProcessor
    {
        public static void SavePeople(List<Person> people, string filePath)
        {
            List<string> lines = new List<string>();

            // Add a header row
            lines.Add("FirstName,IsAlive,LastName");

            foreach(var p in people)
            {
                lines.Add($"{ p.FirstName },{ p.IsAlive },{ p.LastName }");
            }

            File.WriteAllLines(filePath, lines);
        }

        public static List<Person> LoadPeople(string filePath)
        {
            List<Person> output = new List<Person>();

            Person person;

            var lines = File.ReadAllLines(filePath).ToList();

            // Remove the header row
            lines.RemoveAt(0);

            foreach(var line in lines)
            {
                var vals = line.Split(',');
                person = new Person();

                person.FirstName = vals[0];
                person.IsAlive = bool.Parse(vals[1]);
                person.LastName = vals[2];

                output.Add(person);
            }

            return output;
        }
    }
}
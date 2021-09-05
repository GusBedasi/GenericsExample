using System;
using System.Collections.Generic;

namespace GenericsConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void DemonstrateTextFileStorage() 
        {
            List<Person> people =  new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"~/temp/people.csv";
            string logFile = @"~/temp/logs.csv";

            PopulateLists(people, logs);

            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach(var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            }
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Gustavo", LastName = "Melo"});
            people.Add(new Person { FirstName = "Nicolle", LastName = "Laurelli"});
            people.Add(new Person { FirstName = "George", LastName = "Washington" , IsAlive = false});
        
            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
        }
    }
}

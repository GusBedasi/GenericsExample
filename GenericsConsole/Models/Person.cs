namespace GenericsConsole
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAlive { get; set; } = true;
    }
}
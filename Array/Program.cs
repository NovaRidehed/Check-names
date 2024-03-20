namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstration av Contains
            string[] names = { "Anna", "Bertil", "Cesar" };
            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(names, "Bertil")); // true
            Console.WriteLine("Contains(David): " + Contains(names, "David")); // false
        }
        public static bool Contains(string[] names, string name)
        {
            foreach(string s in names)
            {
                bool itsAMatch = (s == name);
                if (itsAMatch == true)
                {
                    return true;
                }
            }
            
            return false; // TODO
        }
    }
}
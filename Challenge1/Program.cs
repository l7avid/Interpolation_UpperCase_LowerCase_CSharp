namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name and press enter: ");
            name = Console.ReadLine();

            Console.WriteLine("Name in upper case: {0}", name.ToUpper());
            Console.WriteLine($"Name in lower case: {name.ToLower()}");
            Console.WriteLine("Name substring 3: " + name.Substring(3));
        }
    }
}
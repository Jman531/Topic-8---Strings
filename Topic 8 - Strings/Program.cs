namespace Topic_8___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Aldworth", name2 = "aldworth", yearString;
            int year = 1982;
            yearString = 1982 + "";

            Console.WriteLine(name1[0]);
            Console.WriteLine(name1[name1.Length - 1]);

            Console.WriteLine();

            Console.WriteLine(name1.Substring(3));
            Console.WriteLine(name1.Substring(name1.Length - 2));

            Console.WriteLine();

            Console.WriteLine(name1.Substring(3, 4));
            Console.WriteLine(name1.Substring(1, name1.Length - 2));

            Console.WriteLine();

            Console.WriteLine(name1[0] + name1.Substring(5, 2));

            Console.WriteLine();

            Console.WriteLine(yearString);

            Console.WriteLine();

            Console.WriteLine(char.ToUpper(name1[name1.Length - 1]) + name1.Substring(1, name1.Length - 2) + char.ToLower(name1[0]));

            Console.WriteLine();

            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.WriteLine();

            if (name1.Contains("and"))
                Console.WriteLine(name1 + " contains and");
            else
                Console.WriteLine(name1 + " does not contain and");

            Console.WriteLine();

            name1 = name1.Insert(3, " and ");

            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.WriteLine();

            if (name1.Contains("and"))
                Console.WriteLine(name1 + " contains and");
            else
                Console.WriteLine(name1 + " does not contain and");

            name1 = name1.Insert(4, "fffffffff");

            Console.WriteLine(name1);

            name1 = name1.Replace("f", "");

            Console.WriteLine(name1);
        }
    }
}

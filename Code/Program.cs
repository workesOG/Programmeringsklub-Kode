namespace Code;

class Program
{
    static void Main(string[] args)
    {
        Variables variables = new Variables();
        Console.WriteLine(variables.x * variables.y);
        Console.ReadLine();
    }
}
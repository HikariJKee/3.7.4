class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        var age = Console.ReadLine();

        Console.WriteLine("Your name is {0}, your age is {1}", name, age);
        Console.WriteLine("Enter your birtdate: ");

        var birtdate = Console.ReadLine();
        Console.WriteLine("Your birtdate is {0}", birtdate);

        Console.WriteLine("Your name {0} \nYour age {1} \nYour birthdate {2}", name, age, birtdate);

        Console.ReadKey();
    }
}
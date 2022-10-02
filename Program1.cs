internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Console.WriteLine("Введите первое число");
       // Console.ReadLine();
        int a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        //Console.ReadLine();
        int b =Convert.ToInt32(Console.ReadLine());

        if (a == b * b)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}
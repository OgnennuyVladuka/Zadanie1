namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвёртое число:");
            int d = Convert.ToInt32(Console.ReadLine());
            int res = (a + b + c + d) / 4;
            Console.WriteLine("Среднее арифметическое для чисел " + (a) + ", " + (b) + ", " + (c) + ", " + (d) + " = " + (res));
        }
    }
}
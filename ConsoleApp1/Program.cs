namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double result1 = (a+3*(Math.Abs(a-b))+Math.Pow(a, 2.0))/Math.Abs(a-b)*c+Math.Pow(a, 2.0);
            double result2 = -(1 / 4.0) * Math.Cos(a) * result1;
            double result3 = 5 * Math.Atan(a) - result2;

            Console.WriteLine("Результат вычсиления равен ");
            Console.WriteLine(result3);
        }
    }
}
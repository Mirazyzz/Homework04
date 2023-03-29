namespace Homework04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate the sum of two numbers
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
    }
}
using System;
using System.Data;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            DataTable dt = new DataTable();
            try
            {
                while (true)
                {
                    Console.Write("Введите свое выражение: ");
                    string Expression = Console.ReadLine();
                    Expression = Expression.Replace('\t', '\0');
                    Console.WriteLine("Ответ: " + dt.Compute(Expression, string.Empty));
                }
            }
            catch
            {
                Console.WriteLine("Ошибкааа!!!");
            }

        }

    }
}
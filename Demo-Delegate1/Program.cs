using System;

namespace Demo_Delegate1
{
    delegate int OperationMath(int param1, int param2);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            OperationMath ope = p.Division;
            ope += p.Multiplication;
            ope += p.Addition;
            ope += p.Addition;
            ope?.Invoke(5, 4); 
            Console.WriteLine("Hello World!");
        }

        int Addition(int nb1, int nb2)
        {
            int result = nb1 + nb2;
            Console.WriteLine(result);
            return result;
        }
        int Multiplication(int nb1, int nb2)
        {
            int result = nb1 * nb2;
            Console.WriteLine(result);
            return result;
        }
        int Soustraction(int nb1, int nb2)
        {
            int result = nb1 - nb2;
            Console.WriteLine(result);
            return result;
        }
        int Division(int nb1, int nb2)
        {
            if (nb2 == 0) throw new ArgumentException();
            int result = nb1 / nb2;
            Console.WriteLine(result);
            return result;
        }
    }
}

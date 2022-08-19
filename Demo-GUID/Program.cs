using System;

namespace Demo_GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Guid identifiant = Guid.NewGuid();
                Console.WriteLine(identifiant);
                i++;
            } while (i<100);
        }
    }
}

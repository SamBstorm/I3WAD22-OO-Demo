using System;

namespace Demo_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Transmission t1 = new Transmission("Sam");
            t1.sendMessage("Test");
            t1.Dispose();
            using (Transmission t2 = new Transmission("Maya"))
            {
                t2.sendMessage("Test");
                using (Transmission t3 = new Transmission("Eléonore")) {
                    t3.sendMessage("Copy");
                    t2.sendMessage("Arrête tes conneries!");
                }
            }
        }
    }
}

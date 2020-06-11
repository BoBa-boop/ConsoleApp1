using System;

namespace ConsoleApp1
{
    class Покупатель
    {
        public string FirstName;
        public string LastName;
        public string Otchestvo;
        protected string Address;
        private int BankCard;
        private int BankAcc;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Покупатель p1 = new Покупатель();
            p1.FirstName = "Андрей";
            p1.LastName = "Андреев";
            p1.Otchestvo = "Андреевич";
            
            Console.WriteLine(p1.FirstName);
            Console.WriteLine(p1.LastName);
            Console.WriteLine(p1.Otchestvo);
            Console.ReadKey();
        }
    }
}

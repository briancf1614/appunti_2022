using System;

namespace SportelloBancomat
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bancomat(3,5,7);

            Console.WriteLine("Saldo:\n" + b);

            Console.WriteLine("\nQuanti pezzi da 50 vuoi togliere?");
            if (b.Togli50(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Operazione eseguita correttamente!");
                Console.WriteLine("\nSaldo:\n" + b);
            }
            else
                Console.WriteLine("Operazione fallita!");

            Console.Write("\nInserisci la cifra da prelevare: ");
            int cifra = int.Parse(Console.ReadLine());

            string[] risultati = b.Prelievo(cifra);

            foreach (string s in risultati)
                Console.WriteLine(s);

            Console.WriteLine("\nSaldo:\n"+b);


        }
    }
}

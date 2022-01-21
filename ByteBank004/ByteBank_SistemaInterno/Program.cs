using ByteBank.Modelos;
using System;

namespace ByteBank_SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ContaCorrente conta = new ContaCorrente(123, 456789);

            Console.WriteLine(conta.Saldo);

            conta.Sacar(10);

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}

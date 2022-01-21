using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);
            
            DateTime dataFimPagamento = new DateTime(2022,02,20);

            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(60);
                //dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            string msg = "Vencimento em : " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(msg);

            Console.ReadLine();
        }

    }
}

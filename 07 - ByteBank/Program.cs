using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine("Número da agência: " + conta.Agencia);
            Console.WriteLine("Número da conta: " + conta.Numero);

            ContaCorrente contaDoDunha = new ContaCorrente(867, 86712345);

            Console.WriteLine("Total de contas correntes criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo do " + contaDoBruno.titular + " antes do saque: " + contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine("Resultado do saque: " + resultadoSaque);
            Console.WriteLine("Saldo do " + contaDoBruno.titular + " depois do saque: " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo do "+ contaDoBruno.titular + " depois do depósito: " + contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Resultado transferencia: " + resultadoTransferencia);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            contaDaGabriela.Transferir(150, contaDoBruno);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            

            Console.ReadLine();


        }
    }
}

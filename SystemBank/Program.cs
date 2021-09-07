using System;
using System.Globalization;

namespace SystemBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            //intro
            Console.WriteLine("Bem vindo ao sistema interno SystemBank.");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Abaixo informe dados do cliente.");
            Console.WriteLine();
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            //resposta para pergunta
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial); //caso tenha saldo inicial.
            }
            else
            {
                conta = new ContaBancaria(numero, titular); //caso não tenha saldo inicial, value = 0.
            }

            //exibe dados da conta.
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta); 

            //deposito em conta.
            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            //saque em conta;
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            Console.WriteLine("ATENÇÂO, para saque será cobrado valor de 0,03% do valor em conta.");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}

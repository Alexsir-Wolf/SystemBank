using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBank
{ 
    class ContaBancaria
    {   //atributos
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }



        //construtores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        //deposito
        public void Deposito(Double quantia)
        {
            Saldo += quantia;
        }

        //saque
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= Saldo * 0.03; //custo do saque 0.03% do Saldo.
        }

        public override string ToString()
        {
            return "Conta"
                + " "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}


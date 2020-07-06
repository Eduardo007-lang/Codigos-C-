using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace Course_2
{
    class ContaBancaria
    {
        //Atributos privados
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo  { get; private set; }

        //Construtores de 2 argumentos
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
           
        }
        //Construtores de 3 argumentos utilizando o "this"
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) 
        {
            deposito(depositoInicial);
        } 

        //Outros metodos (Deposito, Saque e override)
        public void deposito(double quantia) 
        {
            Saldo += quantia;
        }
        public void Saque(double quantia) 
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

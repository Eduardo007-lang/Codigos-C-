using System;
using System.Globalization;
namespace Banco
{
    class Conta_Bancaria
    {
        //Atributos Privados
        private int Numero_Conta;
        private string Titular;
        //Propriedades 
        public double Saldo { get; set; }
       

     

        //Construtor de dois Parametros
        public Conta_Bancaria(int numero_conta, string titular) {

            Numero_Conta = numero_conta;
            Titular = titular;
        }

        //Cosntrutor de tres Parametros
        public Conta_Bancaria(int numero_conta, string titular, double saldo) : this( numero_conta, titular) {

            Saldo = saldo;
        }

        //Propriedades customizada
        public int numero_conta
        {

            get { return Numero_Conta; }

            set {

                if (value != 0)
                {

                    Numero_Conta = value;

                }

            }

        }

        //Propriedades customizada
        public string titular
        {

            get { return Titular; }

            set { 
                if (value != null && value.Length > 2)
                {

                    Titular = value;

                }

            }

        }
      
        //Funcao para depositar(adicionar) uma quantidade x na variavel Saldo 
        public void Deposito(double quantia) {

           Saldo += quantia;
        }

        //Funcao para saque(retirar) uma quantia da x da variavel Saldo 
        public void Saque(double quantia)
        {

            Saldo -= quantia + 5.0;
        }

        //Convertendo o objeto para string
        public override string ToString()
        {
            return "Conta: " + Numero_Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

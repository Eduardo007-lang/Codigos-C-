using System;
using System.Globalization;
namespace Banco
{
    class Conta_Bancaria
    {
        //Atributos Privados
        private int Numero_Conta;
        private string Nome;
        //Propriedades 
        public double Deposito_Inicial { get; private set; }
        public double Deposito { get; private set; }

     

        //Construtor de dois Parametros
        public Conta_Bancaria(int numero_conta, string nome) {

            Numero_Conta = numero_conta;
            Nome = nome;
        }

        //Cosntrutor de tres Parametros
        public Conta_Bancaria(int numero_conta, string nome, double deposito) : this( numero_conta, nome) {

            Deposito_Inicial = deposito;
        }

        //Propriedades custo
        public int numero_conta
        {

            get { return Numero_Conta; }

            set {

                if (value != null)
                {

                    Numero_Conta = value;

                }

            }

        }

        //Propriedades custo
        public string _nome
        {

            get { return Nome; }

            set { 



                if (value != null && value.Length > 1)
                {

                    Nome = value;

                }

            }

        }

        public override string ToString()
        {
            return "Conta: " + Numero_Conta + ", Titular: " + Nome + ", Saldo: $ " + Deposito_Inicial.ToString("F2", CultureInfo.InvariantCulture); 
        }

        /*  public double Deposito_Bancario()
          {

              return Deposito_Inicial + Deposito;

          }*/

    }
}

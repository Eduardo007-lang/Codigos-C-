using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculo_de__Salarios
{
    class Funcionario
    {   
        //Atributos Privados
        private string Nome;
        //propriedades autoimplementadas
        public double SalarioBruto { get; set; }
        public double Imposto { get;  set; }

        //Construtores
        public Funcionario() { }

        public Funcionario(string nome, double salariobruto, double imposto ) 
        {
            Nome = nome;
            SalarioBruto = salariobruto;
            Imposto = imposto;
            
        }
        //Propriedades customizadas 
        public string nome 
        {
            get { return Nome; }
            set {if(value != null ) 
                Nome = value; }        
        }
        //Outros metodos da Classe
        public double SalarioLiquido() 
        {
            return SalarioBruto - Imposto;
        
        }
        public double AumentarSalario(double porcentagem) 
        {
            return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

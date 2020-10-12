using System;
using System.Globalization;
namespace Calculo_Triangulo
{
    class Triangulo
    {
        //Atributos da classe
        public double A;
        public double B;
        public double C;

        //Metodo da Classe
        public double CalcularArea() {

            double p = (A + B + C) / 2.0;

            //double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
           
        }

    }
}

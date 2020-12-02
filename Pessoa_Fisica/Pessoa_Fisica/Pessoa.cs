using System;
using System.Globalization;
namespace Pessoa_Fisica
{
    class Pessoa
    {
        //Atributos privados usando metodos get e set
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Altura { get; private set; }

        //Construtor de 3 parametros 
        public Pessoa(string nome, DateTime dataNascimento, double altura) {

            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        //Funcao para calcular a idade Datetime pegado data atual e diminuindo com o ano de nascimento armazenado no atributo DataNascimento
        public int Idade() {

            return DateTime.Today.Year - DataNascimento.Year;
        }
        //Funcao para transformar o objeto em string
        public override string ToString()
        {
            return "Nome: " + Nome + ", Idade: " + Idade() + ", Altura: " + Altura.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

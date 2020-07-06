using System;
using System.Globalization;

namespace Course_2
{
    class Produto
    {   
        //ATRIBUTOS PRIVADOS
        private string _nome;
        //PROPIEDADES AUTOIMPLEMENTADA
        //Auto Propeties 
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //CONSTRUTORES
        //Construtor Padrão
        public Produto(){ }
        //Construtor de 3 Argumentos
        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
           Preco = preco;
            Quantidade = quantidade;
        
        }
        //PROPRIEDADES CUSTOMIZADOS
        //Propeties
        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {

                    _nome = value;
                }
            }
        
        }
        //OUTROS METODOS DA CLASSE
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

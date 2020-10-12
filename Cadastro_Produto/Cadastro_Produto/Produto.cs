using System;
using System.Globalization;
namespace Cadastro_Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade; 

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
    
        }

        public void AdicionarProdutos(int quantidade) {

            Quantidade = Quantidade + quantidade;
                                   
        }
        public void RemoverProdutos(int quantidade)
        {

            Quantidade = Quantidade - quantidade;

        }

        public override string ToString()
        {
            return Nome
                + ", $"
                 + Preco.ToString("F2", CultureInfo.InvariantCulture)
                 + ", " 
                 + Quantidade 
                 + " unidades, Total: $ " 
                 + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

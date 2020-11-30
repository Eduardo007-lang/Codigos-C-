using System;
using System.Globalization;

namespace Udemy_Course
{
    class Produto
    {
    
            
            private string _nome;
            public double Preco { get; private set; }
            public int Quantidade { get; private set; }
            
            
            //Contrutor Padrao
            public Produto()
            {
            }


            //Contrutor de dois parametros
            public Produto(string nome, double preco) : this()
            {
                _nome = nome;
                Preco = preco;

            }

            //Cosntrutor de tres parametros 
            public Produto(string nome, double preco, int quantidade) : this(nome, preco)
            {
                Quantidade = quantidade;
            }

            //Metodo Get para obter a informação do Nome do produto e o Metodo Set para definir um valor para o atributo seguido de uma regra utilizando o condicional if para que o atributo não tenha um valor vazio(null) e menor de 1 caracter
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

         
           

            //Metodo Get para obter a informação da quantidade de Produtos
            


            //Metodo retornando uma multiplicação de dois atributos  
            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }

            //Metodo que não retornara nenhum valor ao usuário, mas modificará o valor do atributo adicionado um valor a mais para o atributo quantidade
            public void AdicionarProdutos(int quantidade)
            {
                Quantidade += quantidade;
            }

            //Metodo que não retornara nenhum valor ao usuário, mas modificará o valor do atributo que será removido um valor  do atributo quantidade
            public void RemoverProdutos(int quantidade)
            {
                Quantidade -= quantidade;
            }

            //Converte os valores para string, reutilização de codigo
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

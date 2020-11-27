using System;
using System.Globalization;

namespace Udemy_Course
{
    class Produto
    {
    
            //Atributos Privados da classe
            private string _nome;
            private double _preco;
            private int _quantidade;

            //Contrutor Padrao
            public Produto()
            {
            }


            //Contrutor de dois parametros
            public Produto(string nome, double preco) : this()
            {
                _nome = nome;
                _preco = preco;

            }

            //Cosntrutor de tres parametros 
            public Produto(string nome, double preco, int quantidade) : this(nome, preco)
            {
                _quantidade = quantidade;
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

            //Metodo Get para obter a informação do Preço do Produto
            public double Preco
            {

                get { return _preco; }
            }

            //Metodo Get para obter a informação da quantidade de Produtos
            public int Quantidade
            {

                get { return _quantidade; }
            }


            //Metodo retornando uma multiplicação de dois atributos  
            public double ValorTotalEmEstoque()
            {
                return _preco * _quantidade;
            }

            //Metodo que não retornara nenhum valor ao usuário, mas modificará o valor do atributo adicionado um valor a mais para o atributo quantidade
            public void AdicionarProdutos(int quantidade)
            {
                _quantidade += quantidade;
            }

            //Metodo que não retornara nenhum valor ao usuário, mas modificará o valor do atributo que será removido um valor  do atributo quantidade
            public void RemoverProdutos(int quantidade)
            {
                _quantidade -= quantidade;
            }

            //Converte os valores para string, reutilização de codigo
            public override string ToString()
            {
                return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            }

        }
    }

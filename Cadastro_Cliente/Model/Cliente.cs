using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente.Model
{
    class Cliente
    {

        private string nome;
        private int cpf;
        private string endereco;

        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }


    }
}

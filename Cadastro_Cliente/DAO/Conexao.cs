using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro_Cliente.DAO
{
    class Conexao

    {
        private MySqlConnection conexao = new MySqlConnection("server =  127.0.0.1; port = 3306; User Id = root; database = Cadastro_Cliente; password = ");
        internal object commandText;
        internal object Parameters;

        public void Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        public bool Checkconection()
        {
            if (conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MySqlConnection Pega_Conexão()
        {
            return conexao;
        }
    }
}

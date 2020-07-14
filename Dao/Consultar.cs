using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using TP1.Model;
using System.Windows.Forms;

namespace TP1.Dao
{
    class Consultar
    {
        private bool Login_Existe = false;
        public Conexao Conexão = new Conexao();

        DataTable TodasDoBanco = new DataTable();


        public bool Entra_Sistema(Login Login)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USERNAME = @usuario OR SENHA = @senha", Conexão.Pega_Conexão());

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Login.Usuario;
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Login.Senha;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    //Verifica se há uma lina no banco com esse Usuário.
                    int retorno = command.ExecuteNonQuery();
                    if (table.Rows.Count > 0)
                    {
                        if (Convert.ToString(table.Rows[0][1]) == Login.Usuario && Convert.ToString(table.Rows[0][2]) == Login.Senha)
                        {
                            Login_Existe = true;
                        }
                    }
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }
            return Login_Existe;
        }

        public DataTable TabelasDoBanco()
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaAbastecimento = "SHOW TABLES;";


                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaAbastecimento;
                    command.Connection = Conexão.Pega_Conexão();

                    adapter.SelectCommand = command;
                    adapter.Fill(TodasDoBanco);

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }

            return TodasDoBanco;
        }

    }
}
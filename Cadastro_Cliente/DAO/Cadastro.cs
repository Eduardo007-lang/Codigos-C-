using Cadastro_Cliente.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Cliente.DAO
{
    class Cadastro
    {
        private Conexao Conexão = new Conexao();
        private bool Cliente_Incluido = false;
        private object cliente;

        public bool Cliente(Controls Controle)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE CPF = @CPF ", Conexão.Pega_Conexão());

                command.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Controle.Cpf;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Usuario Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }
                    if (Conexão.Checkconection())
                    {
                        string InsertAbastecimento = "INSERT INTO USUARIO(NOME, ENDEREÇO, CPF) VALUES (@Nome, @Enderço, @CPF);";

                        MySqlCommand commando = new MySqlCommand(InsertAbastecimento);
                        commando.Connection = Conexão.Pega_Conexão();
                        commando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = Controle.Nome;
                        commando.Parameters.Add("@Enderço", MySqlDbType.VarChar).Value = Controle.Endereco;
                        commando.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Controle.Cpf;
                        int retorno = commando.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Cliente_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Cliente_Incluido;
                    }
                }
                else
                {

                    MessageBox.Show("Usuario já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return Cliente_Incluido;
        }


    }

}

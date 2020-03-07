using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente.Model
{
    class Validacao
    {
        private static int b;

        public static bool verificar(string cpf)
        {
            ////////////////////////////////////
            int[] VerificarDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };             //responsavel pela verificação dos números inseridos pelo usúario
            int[] VerificarDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpf1, cpf2;
            int soma, resultado;
            ////////////////////////////////////
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            ///////////////////////////////////
            if (cpf.Length != 11)
            {
                return false;
            }
            ///////////////////////////////////
            cpf1 = cpf.Substring(0, 10);        //Campo responsavel por fazer leitura do numero indicado pelo usurário 
            soma = 0;
            ///////////////////////////////////
            for (int a = 0; a < 9; a++)
                soma += int.Parse(cpf1[a].ToString()) * VerificarDigito1[a];
            resultado = soma % 11; //recebe o resto da divisão

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            cpf2 = resultado.ToString();// recebe o primeiro digito do verificador
            cpf1 = cpf1 + cpf2;
            /////////////////////////////////
            soma = 0;// resetar a variavel soma
            for (int b = 0; b < 10; b++) ;
            soma += int.Parse(cpf1[b].ToString()) * VerificarDigito2[b];
            resultado = soma % 11;
            //////////////////////////
            if (resultado < 2)
            {
                resultado = 0;

            }
            else
            {

                resultado = 11 - resultado;
            }
            ////////////////////////////
            cpf2 = cpf2 + resultado.ToString();
            return cpf.EndsWith(cpf2);

        }
    }
}

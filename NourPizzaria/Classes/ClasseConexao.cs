using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NourPizzaria.Classes
{

    public class ClasseConexao
    {
#pragma warning disable CS0618 // Type or member is obsolete
        SqlConnection conexao = new SqlConnection();
#pragma warning restore CS0618 // Type or member is obsolete

#pragma warning disable CS0618 // Type or member is obsolete
        public SqlConnection conectar()
#pragma warning restore CS0618 // Type or member is obsolete
        {
            try
            {
                String strConexao = "Password=123; Persist Security Info=True; User ID=sa; Initial Catalog=PizzariaDB; Data Source=" + Environment.MachineName;
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                desconectar();
                MessageBox.Show(""+ ex);
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataTable executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable dt = ds.Tables[0];
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "");
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public bool manutencaoDB(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return false;
            }
            finally
            {
                desconectar();
            }
        }//fim do método manutençãoDB

        public int manutencaoDB_Parametros(SqlCommand comando) //incluir, alterar, excluir com parâmetros
        {
            int retorno = 0;
            try
            {
                comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
                retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
            }
            catch (Exception) { }
            desconectar();
            return retorno;
        }//fim do método manutençãoDB com parâmetros

    }//fim da classeConexao
}


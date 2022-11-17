using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMiniERP.Classes
{
    internal class Produtos
    {
        public string nome;
        public float valor, peso;
        public int idFornecedor;

        public bool Salvar()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transaction = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into produtos values (@nome, @valor, @peso, @idFornecedor)";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@valor", SqlDbType.Float);
            cmd.Parameters.Add("@peso", SqlDbType.Float);
            cmd.Parameters.Add("@idFornecedor", SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = valor;
            cmd.Parameters[2].Value = peso;
            cmd.Parameters[3].Value = idFornecedor;

            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}

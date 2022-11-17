using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMiniERP.Classes
{
    internal class Clientes
    {
        public string nomeCli, cpf;

        public bool Salvar()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transaction = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into clientes values (@nomeCli, @cpf)";
            cmd.Parameters.Add("@nomeCli", SqlDbType.VarChar);
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters[0].Value = nomeCli;
            cmd.Parameters[1].Value = cpf;

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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMiniERP.Classes
{
    internal class Fornecedores
    {
        public string nomeFornecedor, cnpj;

        public bool Salvar()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transaction = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into fornecedores values (@nomeFornecedor, @cnpj)";
            cmd.Parameters.Add("@nomeFornecedor", SqlDbType.VarChar);
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
            cmd.Parameters[0].Value = nomeFornecedor;
            cmd.Parameters[1].Value = cnpj;

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

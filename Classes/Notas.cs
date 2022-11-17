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
    internal class Notas
    {
        public string data;
        public int idCliente, idProd;

        public bool Salvar()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transaction = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into notas values (@data, @idCliente, @idProd)";
            cmd.Parameters.Add("@data", SqlDbType.Date);
            cmd.Parameters.Add("@idCliente", SqlDbType.Int);
            cmd.Parameters.Add("@idProd", SqlDbType.Int);
            cmd.Parameters[0].Value = data;
            cmd.Parameters[1].Value = idCliente;
            cmd.Parameters[2].Value = idProd;

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

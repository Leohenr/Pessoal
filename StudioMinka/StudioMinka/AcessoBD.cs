using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudioMinka
{
    class AcessoBD
    {
        public static string strConexao = string.Empty;

        SqlConnection oConn;
        private void Conectar()
        {
            try
            {
                oConn = new SqlConnection(strConexao);
                oConn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
                if (oConn.State == ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Consultar(string pSql, List<SqlParameter> parametros)
        {
            try
            {
                Conectar();
                SqlCommand oCmd = new SqlCommand(pSql, oConn);
                foreach (SqlParameter p in parametros)
                {
                    oCmd.Parameters.Add(p);
                }
                SqlDataAdapter oAdp = new SqlDataAdapter(oCmd);
                DataSet ds = new DataSet();
                oAdp.Fill(ds, "Table");
                Desconectar();
                return ds.Tables["Table"];

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Executar(string pSql, List<SqlParameter> parametros)
        {
            try
            {
                int intRetorno = 0;
                Conectar();
                SqlCommand oCmd = new SqlCommand(pSql, oConn);
                foreach (SqlParameter p in parametros)
                {
                    oCmd.Parameters.Add(p);
                }
                intRetorno = Convert.ToInt32(oCmd.ExecuteScalar());
                Desconectar();
                return intRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}

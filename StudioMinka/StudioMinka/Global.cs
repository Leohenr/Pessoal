using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioMinka
{
    class Global
    {
        public static int intCodigoUsuario = 0;
        public static string strNomeUsuario = string.Empty;

        public static DataTable ConsultarTelCel()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT tcl_codigo, tcl_nome FROM tb_telcel_tcl";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}

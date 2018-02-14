using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudioMinka
{
    class Login
    {
        public int intCodigo { get; set; }
        public string strUsuario { get; set; }
        public string strSenha { get; set; }

        public Login()
        {
            intCodigo = 0;
            strUsuario = string.Empty;
            strSenha = string.Empty;
        }

        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtFuncionario = new DataTable();
        string strSql = string.Empty;

        public bool AutenticarUsuario()
        {
            try
            {
                strSql = "select usu_usuario, usu_codigo, usu_senha from tb_usuarios_usu \n";
                strSql += "where usu_usuario = @p_usuario";
                oParametros.Clear();
                oParametros.Add(new SqlParameter("@p_usuario", strUsuario));
                dtFuncionario = oAcessoBD.Consultar(strSql, oParametros);
                if (dtFuncionario.Rows.Count != 0)
                {
                    intCodigo = Convert.ToInt32(dtFuncionario.Rows[0]["usu_codigo"]);
                    strUsuario = dtFuncionario.Rows[0]["usu_usuario"].ToString();
                    strSenha = dtFuncionario.Rows[0]["usu_senha"].ToString();

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

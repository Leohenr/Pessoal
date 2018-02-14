using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Burger_Manager
{
    class Situacao
    {
        //select * from tb_pedidosand_and an inner join tb_cliente_cli cli on an.cli_codigo = an.and_codigo




        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtFuncionario = new DataTable();
        string strSql = string.Empty;
    }
}

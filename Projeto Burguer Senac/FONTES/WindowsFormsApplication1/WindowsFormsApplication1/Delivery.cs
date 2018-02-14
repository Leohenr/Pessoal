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
    class Delivery
    {
        public int intCodigo { get; set; }
        public DateTime dtDate { get; set; }
        public int intAndamento { get; set; }

        public int intCliCodigo { get; set; }

        public int intUsuCodigo { get; set; }
        public int intFncCodigo { get; set; }
        public int intPdoCodigo { get; set; }

        public int intProCodigo { get; set; }

        public int intPagCodigo { set; get; }

        public string strTotal { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public Delivery()
        {
            intCodigo = 0;
            dtDate = new DateTime();
            intAndamento = 0;
            intCliCodigo = 0;
            intUsuCodigo = 0;
            intFncCodigo = 0;
            intPdoCodigo = 0;
            intProCodigo = 0;
            intPagCodigo = 0;
            strTotal = string.Empty;


        }

        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtDelivery = new DataTable();
        string strSql = string.Empty;

        public void GAndamento()
        {
            using (TransactionScope transacao = new TransactionScope())
            {
                oParametros.Clear();
                strSql = "UPDATE tb_pedido_pdo set \n";
                strSql += "pdo_andamento = @p_andamento \n";
                strSql += "WHERE pdo_codigo = @p_codigo";
                oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                oParametros.Add(new SqlParameter("@p_andamento", intAndamento));
                oAcessoBD.Executar(strSql, oParametros);

                transacao.Complete();
            }

        }


        public DataTable Consultar()
        {
            try
            {

                oParametros.Clear();
                strSql = "select * from tb_pedido_pdo pdo \n";
                strSql += "left join tb_cliente_cli cli on pdo.cli_codigo = cli.cli_codigo \n";
                strSql += "left join tb_usuario_usu usu on pdo.usu_codigo = usu.usu_codigo \n";
                strSql += "left join tb_pagamento_pag pag on pdo.pag_codigo = pag.pag_codigo \n";
                strSql += "left join tb_funcionario_fnc fnc on pdo.fnc_codigo = fnc.fnc_codigo \n";
                strSql += "left join tb_funcoes_fun fun on fnc.fun_codigo = fun.fun_codigo \n";

                if (intCodigo != 0)
                {
                    strSql += "where pdo_codigo = @p_codigo \n";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (intAndamento != 0)
                {
                    strSql += "where pdo_andamento = @p_andamento \n";
                    oParametros.Add(new SqlParameter("@p_andamento", intAndamento));

                }
                else if (dtDate != new DateTime())
                {
                    strSql += "where pdo_date = @p_data \n";
                    oParametros.Add(new SqlParameter("@p_date", intAndamento));

                }
                else if (strTotal != string.Empty)
                {
                    strSql += "where pdo_total = @p_valor \n";
                    oParametros.Add(new SqlParameter("@p_valor", strTotal));

                }
                else if (intCliCodigo != 0)
                {
                    strSql += "where pdo.cli_codigo = @p_clicodigo \n";
                    oParametros.Add(new SqlParameter("@p_clicodigo", intCliCodigo));

                }
                else if (intUsuCodigo != 0)
                {
                    strSql += "where pdo.usu_codigo = @p_usucodigo \n";
                    oParametros.Add(new SqlParameter("@p_usucodigo", intUsuCodigo));

                }
                else if (intPagCodigo != 0)
                {
                    strSql += "where pdo.pag_codigo = @p_pagcodigo \n";
                    oParametros.Add(new SqlParameter("@p_pagcodigo", intPagCodigo));

                }
                else if (intFncCodigo != 0)
                {
                    strSql += "where pdo.fnc_codigo = @p_fnccodigo \n";
                    oParametros.Add(new SqlParameter("p_fnccodigo", intFncCodigo));

                }
                dtDelivery = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0)
                {
                    intCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pdo_codigo"]);
                    intAndamento = Convert.ToInt32(dtDelivery.Rows[0]["pdo_andamento"]);
                    dtDate = Convert.ToDateTime(dtDelivery.Rows[0]["pdo_date"]);
                    strTotal = dtDelivery.Rows[0]["pdo_andamento"].ToString();
                    intCliCodigo = Convert.ToInt32(dtDelivery.Rows[0]["cli_codigo"]);
                    intUsuCodigo = Convert.ToInt32(dtDelivery.Rows[0]["usu_codigo"]);
                    intPagCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pag_codigo"]);
                    intFncCodigo = Convert.ToInt32(dtDelivery.Rows[0]["fnc_codigo"]);
                }
                oParametros.Clear();
                return dtDelivery;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Gravar()
        {
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {

                    oParametros.Clear();

                    strSql = "insert into tb_pedido_pdo \n";
                    strSql += "(pdo_date, pdo_andamento, pdo_total, pag_codigo, cli_codigo, usu_codigo, fnc_codigo) \n";
                    strSql += "values \n";
                    strSql += "(@p_date, @p_andamento, @p_total, @p_pagcodigo, @p_clicodigo, @p_usucodigo, @p_fnccodigo); select @@identity;";


                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                    oParametros.Add(new SqlParameter("@p_date", dtDate));
                    oParametros.Add(new SqlParameter("@p_andamento", intAndamento));
                    oParametros.Add(new SqlParameter("@p_total", strTotal));
                    oParametros.Add(new SqlParameter("@p_pagcodigo", intPagCodigo));
                    oParametros.Add(new SqlParameter("@p_clicodigo", intCliCodigo));
                    oParametros.Add(new SqlParameter("@p_usucodigo", intUsuCodigo));
                    oParametros.Add(new SqlParameter("@p_fnccodigo", intFncCodigo));


                    intPdoCodigo = oAcessoBD.Executar(strSql, oParametros);

                    foreach (Produto pro in produtos)
                    {
                        oParametros.Clear();


                        strSql = "insert into tb_propedido_ppd \n";
                        strSql += "(pro_codigo, pdo_codigo) \n";
                        strSql += "values \n";
                        strSql += "(@p_procodigo, @p_pdocodigo)";


                        oParametros.Add(new SqlParameter("@p_procodigo", pro.intCodigo));
                        oParametros.Add(new SqlParameter("@p_pdocodigo", intPdoCodigo));

                        oAcessoBD.Executar(strSql, oParametros);
                    }
                    transacao.Complete();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarBairro()
        {
            try
            {

                oParametros.Clear();
                strSql = "select * from tb_pedido_pdo pdo \n";
                strSql += "inner join tb_cliente_cli cli on pdo.cli_codigo = pdo.pdo_codigo \n";
                strSql += "inner join tb_usuario_usu usu on pdo.usu_codigo = pdo.pdo_codigo \n";
                strSql += "inner join tb_propedido_ppd ppd on pdo.ppd_codigo = pdo.pdo_codigo \n";
                strSql += "inner join tb_funcionario_fnc fnc on pdo.fnc_codigo = pdo.pdo_codigo \n";
                strSql += "inner join tb_funcoes_fun fun on fnc.fun_codigo = fnc.fnc_codigo \n";

                if (intCodigo != 0)
                {
                    strSql += "where pdo_codigo = @p_codigo \n";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (intAndamento != 0)
                {
                    strSql += "where pdo_andamento = @p_andamento \n";
                    oParametros.Add(new SqlParameter("@p_andamento", intAndamento));

                }
                else if (dtDate != new DateTime())
                {
                    strSql += "where pdo_date = @p_data \n";
                    oParametros.Add(new SqlParameter("@p_date", intAndamento));

                }
                else if (intCliCodigo != 0)
                {
                    strSql += "where pdo.cli_codigo = @p_clicodigo \n";
                    oParametros.Add(new SqlParameter("@p_clicodigo", intCliCodigo));

                }
                else if (intUsuCodigo != 0)
                {
                    strSql += "where pdo.usu_codigo = @p_usucodigo \n";
                    oParametros.Add(new SqlParameter("@p_usucodigo", intUsuCodigo));

                }

                else if (intFncCodigo != 0)
                {
                    strSql += "where pdo.fnc_codigo = @p_fnccodigo \n";
                    oParametros.Add(new SqlParameter("p_fnccodigo", intFncCodigo));

                }
                dtDelivery = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0)
                {
                    intCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pdo_codigo"]);
                    intAndamento = Convert.ToInt32(dtDelivery.Rows[0]["pdo_andamento"]);
                    dtDate = Convert.ToDateTime(dtDelivery.Rows[0]["pdo_date"]);
                    intCliCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pdo.cli_codigo"]);
                    intUsuCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pdo.usu_codigo"]);
                    intFncCodigo = Convert.ToInt32(dtDelivery.Rows[0]["pdo.fnc_codigo"]);
                }
                oParametros.Clear();
                return dtDelivery;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultarClienteDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "select cli.cli_codigo, cli_nome, cli_cep, cli_endereco, cli_numero, cli_complemento, cli_bairro, tel_numero from tb_telefone_tel tel inner join tb_cliente_cli cli on tel.cli_codigo = tel.tel_codigo";
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

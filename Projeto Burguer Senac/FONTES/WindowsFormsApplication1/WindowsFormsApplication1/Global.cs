using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Burger_Manager
{
    public static class Global
    {
        public static int intCodigoUsuario = 0;
        public static string strNomeUsuario = string.Empty;
        public static DataTable ConsultarCategoria()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT cat_codigo, cat_categoria FROM tb_categoria_cat";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public static DataTable ConsultarFuncao()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT fun_codigo, fun_funcoes FROM tb_funcoes_fun";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public static DataTable ConsultarPaoDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 1";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarBurguerDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 2";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarQueijoDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 3";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarIngredientesDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 4";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarMolhosDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 5";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarAcompanhamentosDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 6";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarBebidasDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 7";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarPontoDelivery()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pro_codigo, pro_nome, pro_venda FROM tb_produto_pro WHERE cat_codigo = 8";

                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarMotoboy()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT fnc_codigo, fnc_nome FROM tb_funcionario_fnc WHERE fun_codigo = 2";
                dt = oAcessoBD.Consultar(strSql, oParametros);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarPagto()
        {
            try
            {
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                DataTable dt = new DataTable();
                string strSql = "SELECT pag_codigo, pag_forma FROM tb_pagamento_pag";
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

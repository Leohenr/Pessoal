using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Burger_Manager
{
    class Produto
    {
        public int intCodigo { get; set; }
        public string strNome { get; set; }
        public string strPreco { get; set; }

        public int intCatCodigo { get; set; }

        public string strCategoria { get; set; }

        public Produto()
        {
            intCodigo = 0;
            strNome = string.Empty;
            strPreco = string.Empty;
            strCategoria = string.Empty;
            intCatCodigo = 0;
        }

        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtProduto = new DataTable();
        string strSql = string.Empty;

        public DataTable Consultar(int intPesquisa)
        {
            try
            {
                oParametros.Clear();
                strSql = "select pro_codigo, pro_nome, pro_venda, cat_categoria from tb_produto_pro pro inner join tb_categoria_cat cat on pro.cat_codigo = cat.cat_codigo \n";

                if (intCodigo != 0)
                {
                    strSql += "where pro_codigo = @p_codigo \n";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (strNome != string.Empty)
                {
                    if (intPesquisa == 0)
                    {
                        strSql += "where pro_nome like @p_nome \n";
                        oParametros.Add(new SqlParameter("@p_nome", "%" + strNome + "%"));
                    }
                    else
                    {
                        strSql += "where pro_nome like @p_nome \n";
                        oParametros.Add(new SqlParameter("@p_nome", strNome + "%"));
                    }
                }
                strSql += "order by cat_categoria \n";
                dtProduto = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0 || (strNome != string.Empty && dtProduto.Rows.Count != 0))
                {
                    intCodigo = Convert.ToInt32(dtProduto.Rows[0]["pro_codigo"]);
                    strNome = dtProduto.Rows[0]["pro_nome"].ToString();
                    strPreco = dtProduto.Rows[0]["pro_venda"].ToString(); 
                    strCategoria = dtProduto.Rows[0]["cat_categoria"].ToString();
                    
                }
                return dtProduto;
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
                oParametros.Clear();
                if (intCodigo == 0)
                {
                    strSql = "insert into tb_produto_pro \n";
                    strSql += "(pro_nome, pro_venda, cat_codigo) \n";
                    strSql += "values \n";
                    strSql += "(@p_nome, @p_preco, @p_catcodigo)";
                }
                else
                {
                    strSql = "update tb_produto_pro set \n";
                    strSql += "pro_nome = @p_nome, \n";
                    strSql += "pro_venda = @p_preco, \n";
                    strSql += "cat_codigo = @p_catcodigo \n";
                    
                    strSql += "where pro_codigo = @p_codigo";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                oParametros.Add(new SqlParameter("@p_nome", strNome));
                oParametros.Add(new SqlParameter("@p_preco", strPreco));
                oParametros.Add(new SqlParameter("@p_catcodigo", intCatCodigo));
                
                oAcessoBD.Executar(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

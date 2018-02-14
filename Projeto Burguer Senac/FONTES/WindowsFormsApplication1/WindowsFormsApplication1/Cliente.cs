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
    class Cliente
    {
        public int intCodigo { get; set; }
        public string strCPF { get; set; }
        public string strCNPJ { get; set; }
        public string strNome { get; set; }
        public string strEndereco { get; set; }
        public string strNumero { get; set; }
        public string strComplemento { get; set; }
        public string strBairro { get; set; }
        public string strCidade { get; set; }
        public string strCEP { get; set; }
        public string strEstado { get; set; }
        public string strTelefone { get; set; }
        public bool blnPF { get; set; }
        public bool blnPJ { get; set; }

        public List<string> strTelefones = new List<string>();

        public Cliente()
        {
            intCodigo = 0;
            strCPF = string.Empty;
            strCNPJ = string.Empty;
            strNome = string.Empty;
            strCEP = string.Empty;
            strEndereco = string.Empty;
            strNumero = string.Empty;
            strComplemento = string.Empty;
            strBairro = string.Empty;
            strCidade = string.Empty;
            strEstado = string.Empty;
            strTelefone = string.Empty;
            strTelefones.Clear();
            blnPF = true;
            blnPF = false;
        }
        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtCliente = new DataTable();
        string strSql = string.Empty;

        public DataTable ConsultarTel()
        {
            try
            {
                oParametros.Clear();
                strSql = "select cli.cli_codigo, cli_nome, tel_numero from tb_cliente_cli cli inner join tb_telefone_tel tel on tel.cli_codigo = cli.cli_codigo \n";
                if (intCodigo != 0)
                {
                    strSql += "where cli.cli_codigo = @p_codigo \n";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (strTelefone != string.Empty)
                {
                    strSql += "where tel_numero = @p_tel \n";
                    oParametros.Add(new SqlParameter("@p_tel", strTelefone));
                }

                dtCliente = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0 || (dtCliente.Rows.Count != 0 && strTelefone != string.Empty))
                {
                    intCodigo = Convert.ToInt32(dtCliente.Rows[0]["cli_codigo"]);
                    foreach (DataRow tel in dtCliente.Rows)
                    {
                        strTelefones.Add(tel["tel_numero"].ToString());
                    }
                    this.Consultar(0);
                }
                oParametros.Clear();
                return dtCliente;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Consultar(int intPesquisa)
        {
            try
            {
                oParametros.Clear();
                strSql = "SELECT cli_codigo, cli_cpf, cli_cnpj, cli_nome, cli_cep, cli_endereco, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_estado, cli_pessoa_fisica \n";
                strSql += "FROM tb_cliente_cli \n";


                if (intCodigo != 0)
                {
                    strSql += "where cli_codigo = @p_codigo";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (strNome != string.Empty)
                {
                    if (intPesquisa == 0)
                    {
                        strSql += "where cli_nome like @p_nome";
                        oParametros.Add(new SqlParameter("@p_nome", "%" + strNome + "%"));
                    }
                    else
                    {
                        strSql += "where cli_nome like @p_nome";
                        oParametros.Add(new SqlParameter("@p_nome", strNome + "%"));


                    }
                }
                else if (strCPF != string.Empty)
                {

                    strSql += "where cli_cpf like @p_cpf";
                    oParametros.Add(new SqlParameter("@p_cpf", strCPF + "%"));

                }
                else if (strCNPJ != string.Empty)
                {
                    strSql += "where cli_cnpj like @p_cnpj";
                    oParametros.Add(new SqlParameter("@p_cnpj", strCNPJ + "%"));

                }
                else if (strBairro != string.Empty)
                {
                    strSql += "where cli_bairro like @p_bairro";
                    if (intPesquisa == 0)
                    {
                        oParametros.Add(new SqlParameter("@p_bairro", "%" + strBairro + "%"));
                    }
                    else
                    {
                        oParametros.Add(new SqlParameter("@p_bairro", strBairro + "%"));
                    }

                }
                dtCliente = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0 || (strCPF != string.Empty && dtCliente.Rows.Count != 0) || (strCNPJ != string.Empty && dtCliente.Rows.Count != 0))
                {
                    intCodigo = Convert.ToInt32(dtCliente.Rows[0]["cli_codigo"]);
                    strCPF = dtCliente.Rows[0]["cli_cpf"].ToString();
                    strCNPJ = dtCliente.Rows[0]["cli_cnpj"].ToString();
                    strNome = dtCliente.Rows[0]["cli_nome"].ToString();
                    strCEP = dtCliente.Rows[0]["cli_cep"].ToString();
                    strEndereco = dtCliente.Rows[0]["cli_endereco"].ToString();
                    strNumero = dtCliente.Rows[0]["cli_numero"].ToString();
                    strComplemento = dtCliente.Rows[0]["cli_complemento"].ToString();
                    strBairro = dtCliente.Rows[0]["cli_bairro"].ToString();
                    strCidade = dtCliente.Rows[0]["cli_cidade"].ToString();
                    strEstado = dtCliente.Rows[0]["cli_estado"].ToString();
                    blnPF = Convert.ToBoolean(dtCliente.Rows[0]["cli_pessoa_fisica"]);

                    oParametros.Clear();

                }


                return dtCliente;
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
                    if (intCodigo == 0)
                    {
                        strSql = "INSERT INTO tb_cliente_cli \n";
                        strSql += "(cli_cpf, cli_cnpj, cli_nome, cli_endereco, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_cep, cli_estado, cli_pessoa_fisica) \n";
                        strSql += "values \n";
                        strSql += "(@p_cpf, @p_cnpj, @p_nome, @p_endereco, @p_numero, @p_complemento, @p_bairro, @p_cidade, @p_cep, @p_estado, @p_pessoa_fisica); select @@identity;";

                    }
                    else
                    {
                        strSql = "UPDATE tb_cliente_cli set \n";
                        strSql += "cli_cpf = @p_cpf, \n";
                        strSql += "cli_cnpj = @p_cnpj, \n";
                        strSql += "cli_nome = @p_nome, \n";
                        strSql += "cli_endereco = @p_endereco, \n";
                        strSql += "cli_numero = @p_numero, \n";
                        strSql += "cli_complemento = @p_complemento, \n";
                        strSql += "cli_bairro = @p_bairro, \n";
                        strSql += "cli_cidade = @p_cidade, \n";
                        strSql += "cli_cep = @p_cep, \n";
                        strSql += "cli_estado = @p_estado, \n";
                        strSql += "cli_pessoa_fisica = @p_pessoa_fisica \n";
                        strSql += "WHERE cli_codigo = @p_codigo";
                        oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                    }

                    oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                    oParametros.Add(new SqlParameter("@p_cnpj", strCNPJ));
                    oParametros.Add(new SqlParameter("@p_nome", strNome));
                    oParametros.Add(new SqlParameter("@p_endereco", strEndereco));
                    oParametros.Add(new SqlParameter("@p_numero", strNumero));
                    oParametros.Add(new SqlParameter("@p_complemento", strComplemento));
                    oParametros.Add(new SqlParameter("@p_bairro", strBairro));
                    oParametros.Add(new SqlParameter("@p_cidade", strCidade));
                    oParametros.Add(new SqlParameter("@p_cep", strCEP));
                    oParametros.Add(new SqlParameter("@p_estado", strEstado));
                    oParametros.Add(new SqlParameter("@p_pessoa_fisica", blnPF));



                    if (intCodigo == 0)
                    {
                        intCodigo = oAcessoBD.Executar(strSql, oParametros);
                    }
                    else
                    {
                        oAcessoBD.Executar(strSql, oParametros);
                    }

                    strSql = "DELETE \n ";
                    strSql += "FROM tb_telefone_tel \n ";
                    strSql += "WHERE cli_codigo = @p_codigo";
                    oParametros.Clear();

                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                    oAcessoBD.Executar(strSql, oParametros);

                    foreach (string tel in strTelefones)
                    {
                        oParametros.Clear();
                        strSql = "INSERT INTO tb_telefone_tel (tel_numero, cli_codigo) values \n";
                        strSql += "(@p_numero, @p_codigo)";
                        oParametros.Add(new SqlParameter("@p_numero", tel));
                        oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
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


    }
}

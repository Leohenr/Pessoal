using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace StudioMinka
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
        public string strTelefone2 { get; set; }
        public string strEmail { get; set; }
        public string strTelCel { get; set; }
        public bool blnPF { get; set; }


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
            strTelefone2 = string.Empty;
            strEmail = string.Empty;
            strTelCel = string.Empty;
            blnPF = false;
        }
        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtCliente = new DataTable();
        string strSql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                oParametros.Clear();
                strSql = "SELECT cli.cli_codigo, cli.cli_cpf, cli.cli_cnpj, cli.cli_nome, cli.cli_email, lgd.lgd_cep, lgd.lgd_endereco, lgd.lgd_numero, lgd.lgd_complemento, lgd.lgd_bairro, lgd.lgd_cidade, lgd.lgd_estado, tel.tel_numero, tel.tel_numero2, cli.cli_pessoa_fisica, tcl.tcl_nome \n" +
                    "FROM tb_logradouro_lgd lgd \n" +
                    "INNER JOIN tb_clientes_cli as cli ON cli.cli_codigo = lgd.cli_codigo \n" +
                    "INNER JOIN tb_telefones_tel as tel ON tel.cli_codigo = lgd.cli_codigo \n" +
                    "INNER JOIN tb_telcel_tcl as tcl on tcl.tcl_codigo = lgd.cli_codigo \n";


                if (intCodigo != 0)
                {
                    strSql += "where cli.cli_codigo = @p_codigo \n";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (strNome != string.Empty)
                {
                    strSql += "where cli.cli_nome like @p_nome";
                    oParametros.Add(new SqlParameter("@p_nome", strNome + "%"));
                }
                else if (strCPF != string.Empty)
                {
                    strSql += "where cli.cli_cpf like @p_cpf";
                    oParametros.Add(new SqlParameter("@p_cpf", strCPF + "%"));
                }
                else if (strCNPJ != string.Empty)
                {
                    strSql += "where cli.cli_cnpj like @p_cnpj";
                    oParametros.Add(new SqlParameter("@p_cnpj", strCNPJ + "%"));
                }
                else if (strEmail != string.Empty)
                {
                    strSql += "where cli.cli_email like @p_email";
                    oParametros.Add(new SqlParameter("@p_email", "%" + strEmail + "%"));
                }
                else if (strEndereco != string.Empty)
                {
                    strSql += "where lgd.lgd_endereco like @p_endereco";
                    oParametros.Add(new SqlParameter("@p_endereco", "%" + strEndereco + "%"));
                }
                else if (strTelefone != string.Empty || strTelefone2 != string.Empty)
                {
                    strSql += "WHERE tel.tel_numero like @p_numero1 \n" +
                              "OR tel.tel_numero2 like @p_numero2";
                    oParametros.Add(new SqlParameter("@p_numero1", strTelefone + "%"));
                    oParametros.Add(new SqlParameter("@p_numero2", strTelefone + "%"));
                }
                dtCliente = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0 || (strCPF != string.Empty && dtCliente.Rows.Count != 0) || (strCNPJ != string.Empty && dtCliente.Rows.Count != 0))
                {
                    intCodigo = Convert.ToInt32(dtCliente.Rows[0]["cli_codigo"]);
                    strCPF = dtCliente.Rows[0]["cli_cpf"].ToString();
                    strCNPJ = dtCliente.Rows[0]["cli_cnpj"].ToString();
                    strNome = dtCliente.Rows[0]["cli_nome"].ToString();
                    strCEP = dtCliente.Rows[0]["lgd_cep"].ToString();
                    strEndereco = dtCliente.Rows[0]["lgd_endereco"].ToString();
                    strNumero = dtCliente.Rows[0]["lgd_numero"].ToString();
                    strComplemento = dtCliente.Rows[0]["lgd_complemento"].ToString();
                    strBairro = dtCliente.Rows[0]["lgd_bairro"].ToString();
                    strCidade = dtCliente.Rows[0]["lgd_cidade"].ToString();
                    strEstado = dtCliente.Rows[0]["lgd_estado"].ToString();
                    strEstado = dtCliente.Rows[0]["tcl_nome"].ToString();
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
                    strSql = string.Empty;
                    oParametros.Clear();
                    if (intCodigo == 0)
                    {
                        strSql = "INSERT INTO tb_clientes_cli \n";
                        strSql += "(cli_cpf, cli_cnpj, cli_nome, cli_email, cli_pessoa_fisica) \n";
                        strSql += "values \n";
                        strSql += "(@p_cpf, @p_cnpj, @p_nome, @p_email, @p_pessoa_fisica); select @@identity;";

                        oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                        oParametros.Add(new SqlParameter("@p_cnpj", strCNPJ));
                        oParametros.Add(new SqlParameter("@p_nome", strNome));
                        oParametros.Add(new SqlParameter("@p_email", strEmail));
                        oParametros.Add(new SqlParameter("@p_pessoa_fisica", blnPF));


                    }
                    else
                    {
                        strSql = "UPDATE tb_clientes_cli set \n";
                        strSql += "cli_cpf = @p_cpf, \n";
                        strSql += "cli_cnpj = @p_cnpj, \n";
                        strSql += "cli_nome = @p_nome, \n";
                        strSql += "cli_email = @p_email, \n";
                        strSql += "cli_pessoa_fisica = @p_pessoa_fisica \n";
                        strSql += "WHERE cli_codigo = @p_codigo \n";

                        strSql += "UPDATE tb_telefones_tel set \n";
                        strSql += "tel_numero = @p_numero1, \n";
                        strSql += "tel_numero2 = @p_numero2, \n";
                        strSql += "cli_codigo = @p_cli_tel, \n";
                        strSql += "fnc_codigo = @p_fnc_tel \n";
                        strSql += "WHERE cli_codigo = @p_codigo \n";

                        strSql += "UPDATE tb_logradouro_lgd set \n";
                        strSql += "lgd_cep = @p_cep, \n";
                        strSql += "lgd_bairro = @p_bairro, \n";
                        strSql += "lgd_endereco = @p_endereco, \n";
                        strSql += "lgd_numero = @p_numero, \n";
                        strSql += "lgd_complemento = @p_complemento, \n";
                        strSql += "lgd_cidade = @p_cidade, \n";
                        strSql += "lgd_estado = @p_estado, \n";
                        strSql += "cli_codigo = @p_cli_lgd, \n";
                        strSql += "fnc_codigo = @p_fnc_lgd \n";
                        strSql += "WHERE cli_codigo = @p_codigo";

                        oParametros.Add(new SqlParameter("@p_codigo", intCodigo));

                        oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                        oParametros.Add(new SqlParameter("@p_cnpj", strCNPJ));
                        oParametros.Add(new SqlParameter("@p_nome", strNome));
                        oParametros.Add(new SqlParameter("@p_email", strEmail));
                        oParametros.Add(new SqlParameter("@p_pessoa_fisica", blnPF));

                        oParametros.Add(new SqlParameter("@p_numero1", strTelefone));
                        oParametros.Add(new SqlParameter("@p_numero2", strTelefone2));
                        oParametros.Add(new SqlParameter("@p_cli_tel", intCodigo));
                        oParametros.Add(new SqlParameter("@p_fnc_tel", DBNull.Value));

                        oParametros.Add(new SqlParameter("@p_cep", strCEP));
                        oParametros.Add(new SqlParameter("@p_bairro", strBairro));
                        oParametros.Add(new SqlParameter("@p_endereco", strEndereco));
                        oParametros.Add(new SqlParameter("@p_numero", strNumero));
                        oParametros.Add(new SqlParameter("@p_complemento", strComplemento));
                        oParametros.Add(new SqlParameter("@p_cidade", strCidade));
                        oParametros.Add(new SqlParameter("@p_estado", strEstado));
                        oParametros.Add(new SqlParameter("@p_cli_lgd", intCodigo));
                        oParametros.Add(new SqlParameter("@p_fnc_lgd", DBNull.Value));


                    }

                    if (intCodigo == 0)
                    {
                        intCodigo = oAcessoBD.Executar(strSql, oParametros);

                        oParametros.Clear();

                        strSql = "INSERT INTO tb_telefones_tel (tel_numero, tel_numero2, cli_codigo, fnc_codigo) values \n";
                        strSql += "(@p_numero1, @p_numero2, @p_cli_tel, @p_fnc_tel) select @@identity;";

                        oParametros.Add(new SqlParameter("@p_numero1", strTelefone));
                        oParametros.Add(new SqlParameter("@p_numero2", strTelefone2));
                        oParametros.Add(new SqlParameter("@p_cli_tel", intCodigo));
                        oParametros.Add(new SqlParameter("@p_fnc_tel", DBNull.Value));
                        oAcessoBD.Executar(strSql, oParametros);

                        oParametros.Clear();
                        strSql = "INSERT INTO tb_logradouro_lgd (lgd_cep, lgd_bairro, lgd_endereco, lgd_numero, lgd_complemento, lgd_cidade, lgd_estado, cli_codigo, fnc_codigo) values \n";
                        strSql += "(@p_cep, @p_bairro, @p_endereco, @p_numero, @p_complemento, @p_cidade, @p_estado, @p_cli_lgd, @p_fnc_lgd) select @@identity;";

                        oParametros.Add(new SqlParameter("@p_cep", strCEP));
                        oParametros.Add(new SqlParameter("@p_bairro", strBairro));
                        oParametros.Add(new SqlParameter("@p_endereco", strEndereco));
                        oParametros.Add(new SqlParameter("@p_numero", strNumero));
                        oParametros.Add(new SqlParameter("@p_complemento", strComplemento));
                        oParametros.Add(new SqlParameter("@p_cidade", strCidade));
                        oParametros.Add(new SqlParameter("@p_estado", strEstado));
                        oParametros.Add(new SqlParameter("@p_cli_lgd", intCodigo));
                        oParametros.Add(new SqlParameter("@p_fnc_lgd", DBNull.Value));
                        oAcessoBD.Executar(strSql, oParametros);

                    }
                    else
                    {
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

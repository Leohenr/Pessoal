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
    class Funcionario
    {
        public int intCodigo { get; set; }
        
        
        //CADASTRO DE USUARIO        
        public string strUsuario { get; set; }
        public string strSenha { get; set; }        
        public bool blnAtivo { get; set; }

        //DADOS
        public string strNome { get; set; }
        public string strCPF { get; set; }
        public string strTelefone { get; set; }
        public string strCEP { get; set; }
        public string strBairro { get; set; }
        public string strEndereco { get; set; }
        public string strNumero { get; set; }
        public string strComplemento { get; set; }
        public int intFuncao { get; set; }
 

        public Funcionario()
        {
            intCodigo = 0;
            strUsuario = string.Empty;
            strSenha = string.Empty;
            strNome = string.Empty;
            strCPF = string.Empty;
            strTelefone = string.Empty;
            strCEP = string.Empty;
            strBairro = string.Empty;
            strEndereco = string.Empty;
            strNumero = string.Empty;
            strComplemento = string.Empty;
            intFuncao = 0;
            blnAtivo = true;
        }

        AcessoBD oAcessoBD = new AcessoBD();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        DataTable dtFuncionario = new DataTable();
        string strSql = string.Empty;

        public bool AutenticarUsuario()
        {
            try
            {
                strSql = "select fnc_nome, usu_usuario, usu_codigo, usu_senha, usu_ativo from tb_usuario_usu usu inner join tb_funcionario_fnc fnc on usu.fnc_codigo = fnc.fnc_codigo \n";
                strSql += "where usu_usuario = @p_usuario";
                oParametros.Clear();
                oParametros.Add(new SqlParameter("@p_usuario", strUsuario));
                dtFuncionario = oAcessoBD.Consultar(strSql, oParametros);
                if (dtFuncionario.Rows.Count != 0)
                {
                    intCodigo = Convert.ToInt32(dtFuncionario.Rows[0]["usu_codigo"]);
                    strNome = dtFuncionario.Rows[0]["fnc_nome"].ToString();
                    strSenha = dtFuncionario.Rows[0]["usu_senha"].ToString();
                    blnAtivo = Convert.ToBoolean(dtFuncionario.Rows[0]["usu_ativo"]);
                    
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
        public DataTable Consultar(int intPesquisa)
        {
            try
            {
                oParametros.Clear();
                strSql = "select * from tb_funcionario_fnc fnc left join tb_usuario_usu usu on fnc.fnc_codigo = usu.fnc_codigo inner join tb_funcoes_fun fun on fnc.fun_codigo = fun.fun_codigo \n";
                if (intCodigo != 0)
                {
                    strSql += "where fnc.fnc_codigo = @p_codigo";
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                }
                else if (strNome != string.Empty)
                {
                    if (intPesquisa == 0)
                    {
                        strSql += "where fnc.fnc_nome like @p_nome \n";
                        oParametros.Add(new SqlParameter("@p_nome", "%" + strNome + "%"));
                    }
                    else
                    {
                        strSql += "where fnc.fnc_nome like @p_nome \n";
                        oParametros.Add(new SqlParameter("@p_nome", strNome + "%"));
                    }
                }
                else if (strUsuario != string.Empty)
                {
                    if (intPesquisa == 0)
                    {
                        strSql += "where usu_usuario like @p_usuario \n";
                        oParametros.Add(new SqlParameter("@p_usuario", "%" + strUsuario + "%"));
                    }
                    else
                    {
                        strSql += "where usu_usuario like @p_usuario";
                        oParametros.Add(new SqlParameter("@p_usuario", strUsuario + "%"));
                    }
                    
                }
                else if (strCPF != string.Empty)
                {
                        strSql += "where fnc_cpf like @p_cpf";
                        oParametros.Add(new SqlParameter("@p_cpf", strCPF + "%"));
                    
                }
                
                dtFuncionario = oAcessoBD.Consultar(strSql, oParametros);
                if (intCodigo != 0 || (strUsuario != string.Empty && dtFuncionario.Rows.Count != 0) || (strCPF != string.Empty && dtFuncionario.Rows.Count != 0))
                {
                   intCodigo = Convert.ToInt32(dtFuncionario.Rows[0]["fnc_codigo"]);
                    strUsuario = dtFuncionario.Rows[0]["usu_usuario"].ToString();
                    strNome = dtFuncionario.Rows[0]["fnc_nome"].ToString();
                    strSenha = dtFuncionario.Rows[0]["usu_senha"].ToString();
                    strCPF = dtFuncionario.Rows[0]["fnc_cpf"].ToString();
                    strTelefone = dtFuncionario.Rows[0]["fnc_telefone"].ToString();
                    strCEP = dtFuncionario.Rows[0]["fnc_cep"].ToString();
                    strBairro = dtFuncionario.Rows[0]["fnc_bairro"].ToString();
                    strEndereco = dtFuncionario.Rows[0]["fnc_endereco"].ToString();
                    strNumero = dtFuncionario.Rows[0]["fnc_numero"].ToString();
                    strComplemento = dtFuncionario.Rows[0]["fnc_complemento"].ToString();
                    intFuncao =Convert.ToInt32(dtFuncionario.Rows[0]["fun_codigo"]);
                    if (strUsuario != string.Empty)
                    {
                        blnAtivo = Convert.ToBoolean(dtFuncionario.Rows[0]["usu_ativo"]);
                    }
                }
                return dtFuncionario;
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
                        strSql = "insert into tb_funcionario_fnc (fnc_cpf, fnc_nome, fnc_endereco, fnc_numero, fnc_complemento, fnc_bairro, fnc_cep, fnc_telefone, fun_codigo) values (@p_cpf, @p_nome, @p_endereco, @p_numero, @p_complemento, @p_bairro, @p_cep, @p_telefone, @p_funcodigo \n); select @@identity;";
                        
                    }
                    else
                    {
                        strSql = "update tb_funcionario_fnc set \n";
                        strSql += "fnc_nome = @p_nome, \n";
                        strSql += "fnc_cpf = @p_cpf, \n";
                        strSql += "fnc_telefone = @p_telefone, \n";
                        strSql += "fnc_cep = @p_cep, \n";
                        strSql += "fnc_bairro = @p_bairro, \n";
                        strSql += "fnc_endereco = @p_endereco, \n";
                        strSql += "fnc_numero = @p_numero, \n";
                        strSql += "fnc_complemento = @p_complemento, \n";
                        strSql += "fun_codigo = @p_funcodigo \n";
                        strSql += "where fnc_codigo = @p_codigo";
                        oParametros.Add(new SqlParameter("@p_codigo", intCodigo));


                    }
                    oParametros.Add(new SqlParameter("@p_nome", strNome));
                    oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                    oParametros.Add(new SqlParameter("@p_telefone", strTelefone));
                    oParametros.Add(new SqlParameter("@p_cep", strCEP));
                    oParametros.Add(new SqlParameter("@p_bairro", strBairro));
                    oParametros.Add(new SqlParameter("@p_endereco", strEndereco));
                    oParametros.Add(new SqlParameter("@p_numero", strNumero));
                    oParametros.Add(new SqlParameter("@p_complemento", strComplemento));
                    oParametros.Add(new SqlParameter("@p_funcodigo", intFuncao));

                    if (intFuncao == 1 || intFuncao == 4)
                    {
                        if (intCodigo == 0)
                        {
                            intCodigo = oAcessoBD.Executar(strSql, oParametros);
                            strSql = "insert into tb_usuario_usu (usu_usuario, usu_senha, usu_ativo, fnc_codigo) values (@p_usuario, @p_senha, @p_ativo, @p_codigo)";
                            oParametros.Clear();
                            oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                            oParametros.Add(new SqlParameter("@p_usuario", strUsuario));
                            oParametros.Add(new SqlParameter("@p_senha", strSenha));
                            oParametros.Add(new SqlParameter("@p_ativo", blnAtivo));
                            oParametros.Add(new SqlParameter("@p_nome", strNome));
                            oAcessoBD.Executar(strSql, oParametros);
                            
                        }
                        else
                        {
                            oAcessoBD.Executar(strSql, oParametros);
                            strSql = "update tb_usuario_usu set \n";
                            strSql += "usu_usuario = @p_usuario, \n";
                            strSql += "usu_senha = @p_senha, \n";
                            strSql += "usu_ativo = @p_ativo, \n";
                            strSql += "where usu_codigo = @p_codigo";

                            oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                            
                        }
                    }
                    else
                    {
                        if (intCodigo == 0)
                        {
                            intCodigo = oAcessoBD.Executar(strSql, oParametros);
                            strSql = "update tb_usuario_usu set \n";
                            strSql += "usu_usuario = @p_usuario, \n";
                            strSql += "usu_senha = @p_senha, \n";
                            strSql += "usu_ativo = @p_ativo, \n";
                            strSql += "where usu_codigo = @p_codigo";

                            oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                            

                        }
                        else
                        {
                            oAcessoBD.Executar(strSql, oParametros);
                        }
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

drop table tb_telefones_tel;
drop table tb_logradouro_lgd;
drop table tb_obras_obr;
drop table tb_clientes_cli;
drop table tb_etapas_etp;
drop table tb_categorias_cat;
drop table tb_tipos_tip;
drop table tb_membros_mem;
drop table tb_equipes_eqp;
drop table tb_usuarios_usu;
drop table tb_funcionarios_fnc;
drop table tb_funcoes_fun;

-----Cadastros-----

create table tb_clientes_cli (
cli_codigo int primary key identity,
cli_nome varchar(100) not null,
cli_cpf varchar(30) null,
cli_cnpj varchar(30) null,
cli_email varchar(50) null,
cli_pessoa_fisica bit not null
)

create table tb_obras_obr (
obr_codigo int primary key identity,
obr_codminka varchar(10) not null,
obr_descricao varchar(200),
cli_codigo int foreign key references tb_clientes_cli(cli_codigo)
)

create table tb_categorias_cat (
cat_codigo int primary key identity,
cat_nome varchar(100) not null
)

create table tb_tipos_tip (
tip_codigo int primary key identity,
tip_nome varchar(100) not null
)

create table tb_etapas_etp (
etp_codigo int primary key identity,
etp_nome varchar(100) not null,
cat_codigo int foreign key references tb_categorias_cat(cat_codigo),
tip_codigo int foreign key references tb_tipos_tip(tip_codigo)
)

create table tb_funcoes_fun (
fun_codigo int primary key identity,
fun_nome varchar(100) not null
)

create table tb_funcionarios_fnc (
fnc_codigo int primary key identity,
fnc_nome varchar(100) not null,
fnc_cpf varchar(16) not null,
fnc_email varchar(50) null,
fun_codigo int foreign key references tb_funcoes_fun(fun_codigo)
)

create table tb_logradouro_lgd (
lgd_codigo int primary key identity,
lgd_cep varchar(10) not null,
lgd_endereco varchar(100) not null,
lgd_bairro varchar(100) not null,
lgd_cidade varchar(100) not null,
lgd_estado varchar(2) not null,
lgd_numero varchar(10) not null,
lgd_complemento varchar(40),
cli_codigo int foreign key references tb_clientes_cli(cli_codigo),
fnc_codigo int foreign key references tb_funcionarios_fnc(fnc_codigo),
obr_codigo int foreign key references tb_obras_obr(obr_codigo)
)

create table tb_telcel_tcl (
tcl_codigo int primary key identity,
tcl_nome varchar(30) not null
)

create table tb_telefones_tel (
tel_codigo int identity primary key,
tel_numero varchar(20) not null,
tel_numero2 varchar(20) null,
cli_codigo int foreign key references tb_clientes_cli(cli_codigo),
fnc_codigo int foreign key references tb_funcionarios_fnc(fnc_codigo),
tcl_codigo int foreign key references tb_telcel_tcl(tcl_codigo)
)

create table tb_equipes_eqp (
eqp_codigo int identity primary key,
eqp_nome varchar(100) not null,
eqp_sigla varchar(5) not null
)

create table tb_membros_mem (
mem_codigo int identity primary key,
mem_nome varchar(100) not null,
eqp_codigo int foreign key references tb_equipes_eqp(eqp_codigo)
)

create table tb_usuarios_usu (
usu_codigo int primary key identity,
usu_usuario varchar(20) not null,
usu_senha varchar(20) not null,
usu_status bit not null,
fnc_codigo int foreign key references tb_funcionarios_fnc(fnc_codigo)
)



-----Inserts-----
insert into tb_clientes_cli (cli_nome, cli_cpf, cli_email, cli_pessoa_fisica, cli_cnpj)
values ('Leo','111.111.111-11','leonardo@hotmail.com', 1, null), ('Marcio', null,'marcio@salmar.com', 0,'00.000.000/0001-00');

insert into tb_funcoes_fun (fun_nome) values ('Arquiteta');

insert into tb_funcionarios_fnc (fnc_nome, fnc_cpf, fnc_email, fun_codigo)
values ('Ana','000.000.000-0','ana@ana.com',1), ('Sonia','020.030.040-0','sonia@sonia.com',1);

insert into tb_obras_obr (obr_codminka, obr_descricao, cli_codigo)
values ('MK001','Construir',1), ('MK002','Pintar',2); 

insert into tb_telcel_tcl values ('Telefones'),('Telefone e/ou Celular'),('Celulares');

insert into tb_telefones_tel (tel_numero, tel_numero2, cli_codigo, fnc_codigo, tcl_codigo)
values ('(11)9.8888-8888','(11)9.8888-8888', 1,NULL, 3), ('(11)2222-2222',null, NULL,1,1), ('(11)3333-3333','(11)5555-5555', 2,NULL,1), ('(11)4444-4444','(11)9.9999-9999', NULL,2,2);

insert into tb_logradouro_lgd (lgd_cep,lgd_endereco,lgd_numero,lgd_complemento,lgd_bairro,lgd_cidade,lgd_estado,cli_codigo,fnc_codigo,obr_codigo)
values ('02735-000','Rua Baião Parente', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','SP',1,null,null),
('02735-000','Rua ADC', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','RJ',null,1,null),
('02735-000','Rua BAD', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','BA',null,null,1),
('02735-000','Av Faria Lima', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','ES',2,null,null),
('02735-000','Rua AIO', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','MG',null,2,null),
('02735-000','Av Braz Leme', '396','Bloco 05 Apartamento 204','Vila Primavera','São Paulo','RS',null,null,2);

insert into tb_usuarios_usu (usu_usuario, usu_senha, usu_status,fnc_codigo)
values ('leo','123',1,1), ('suporte', '321',0,2);
-----Select-----

	--todos	
select * from tb_clientes_cli
select * from tb_telefones_tel
select * from tb_funcionarios_fnc
select * from tb_obras_obr
select * from tb_funcoes_fun

	--funcionario
select * from tb_funcionarios_fnc fnc
join tb_funcoes_fun fun on fun.fun_codigo = fnc.fnc_codigo

	--obras
select * from tb_obras_obr obr
join tb_clientes_cli cli on cli.cli_codigo = obr.cli_codigo

	--telefones
select * from tb_telefones_tel tel
join tb_clientes_cli cli on cli.cli_codigo = tel.cli_codigo

select * from tb_telefones_tel tel
join tb_funcionarios_fnc fnc on fnc.fnc_codigo = tel.fnc_codigo

select tel_codigo, tel_numero, tel.cli_codigo, tel.fnc_codigo, cli.cli_codigo,cli.cli_nome, fnc.fnc_codigo, fnc.fnc_nome 
from tb_telefones_tel tel
left join tb_clientes_cli as cli on cli.cli_codigo = tel.cli_codigo
left join tb_funcionarios_fnc as fnc on fnc.fnc_codigo = tel.fnc_codigo

	--logradouros
select * from tb_logradouro_lgd lgd
join tb_clientes_cli as cli on cli.cli_codigo = lgd.cli_codigo

select * from tb_logradouro_lgd lgd
join tb_clientes_cli as cli on cli.cli_codigo = lgd.cli_codigo
join tb_obras_obr as obr on obr.obr_codigo = lgd.obr_codigo

select * from tb_logradouro_lgd lgd
join tb_funcionarios_fnc as fnc on fnc.fnc_codigo = lgd.fnc_codigo

select * from tb_logradouro_lgd lgd
join tb_obras_obr as obr on obr.obr_codigo = lgd.obr_codigo

select cli.cli_codigo, cli.cli_cpf,cli.cli_cnpj, cli.cli_nome, cli.cli_email, lgd.lgd_cep, lgd.lgd_endereco, lgd.lgd_numero, lgd.lgd_complemento, lgd.lgd_bairro, lgd.lgd_cidade, lgd.lgd_estado, tel.tel_numero, tel.tel_numero2 from tb_logradouro_lgd lgd
inner join tb_clientes_cli as cli on cli.cli_codigo = lgd.cli_codigo
inner join tb_telefones_tel as tel on tel.cli_codigo = lgd.cli_codigo
where tel.tel_numero2 like '1111-1111' or tel.tel_numero like '1111-1111'

select * from tb_logradouro_lgd lgd
left join tb_clientes_cli as cli on cli.cli_codigo = lgd.cli_codigo
left join tb_funcionarios_fnc as fnc on fnc.fnc_codigo = lgd.fnc_codigo
left join tb_obras_obr as obr on obr.obr_codigo = lgd.obr_codigo

select tel.tel_numero2, cli.cli_nome from tb_clientes_cli as cli
inner join tb_telefones_tel as tel on tel.cli_codigo = cli.cli_codigo


SELECT tcl.tcl_nome, cli.cli_codigo, cli.cli_cpf, cli.cli_cnpj, cli.cli_nome, cli.cli_email, lgd.lgd_cep, lgd.lgd_endereco, lgd.lgd_numero, lgd.lgd_complemento, lgd.lgd_bairro, lgd.lgd_cidade, lgd.lgd_estado, tel.tel_numero, tel.tel_numero2, cli.cli_pessoa_fisica 
FROM tb_logradouro_lgd lgd 
INNER JOIN tb_clientes_cli as cli ON cli.cli_codigo = lgd.cli_codigo 
inner JOIN tb_telefones_tel as tel ON tel.cli_codigo = lgd.cli_codigo 
inner join tb_telcel_tcl as tcl on tcl.tcl_codigo = lgd.cli_codigo

select * from tb_clientes_cli cli
join tb_telefones_tel tel on cli.cli_codigo = tel.cli_codigo
UPDATE tb_telefones_tel set tel_numero = '(11)9999-9999', tel_numero2 = null, cli_codigo = 3, fnc_codigo = null
WHERE cli_codigo = 3

select * from tb_telefones_tel
select * from tb_clientes_cli
insert into tb_telefones_tel values ('(11)9999-9999', null, 4,null)
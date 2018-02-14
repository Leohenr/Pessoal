drop table tb_clientes_cli;

create table tb_clientes_cli (
cli_codigo int primary key identity,
cli_nome varchar(100) not null,
cli_rg varchar(12) not null,
cli_telefone varchar(14) not null,
cli_email varchar(50) not null
);

insert into tb_clientes_cli 
values ('Leonardo','00.000.000-0','(11)99999-9999','leonardo@hotmail.com'),('Marcio','11.111.111-1','(11)88888-8888','marcio@hotmail.com'),('Sonia','22.222.222-2','(11)77777-7777','sonia@hotmail.com'),('Ana','33.333.333-3','(11)66666-6666','ana@hotmail.com');

select * from tb_clientes_cli;

create table tb_cliente_cli (
cli_codigo int identity primary key,
cli_cpf varchar(11) not null,
cli_cnpj varchar(14) not null,
cli_nome varchar(100) not null,
cli_endereco varchar(100) not null,
cli_numero varchar(5) not null,
cli_complemento varchar(100),
cli_bairro varchar(50) not null,
cli_cep varchar(15) not null,
cli_cidade varchar(100) not null,
cli_estado varchar(2) not null,
cli_pessoa_fisica bit not null)

create table tb_telefone_tel (
tel_codigo int identity primary key,
tel_numero varchar(15) not null,
cli_codigo int foreign key (cli_codigo)references tb_cliente_cli)

create table tb_pagamento_pag(
pag_codigo int identity primary key,
pag_forma varchar(10))


create table tb_categoria_cat(
cat_codigo int identity primary key,
cat_categoria varchar(50) not null)


create table tb_produto_pro (
pro_codigo int identity primary key,
pro_nome varchar(100) not null,
pro_venda varchar(5) not null,
cat_codigo int foreign key (cat_codigo) references tb_categoria_cat)

create table tb_funcoes_fun (
fun_codigo int identity primary key ,
fun_funcoes varchar(30) not null)

create table tb_funcionario_fnc (
fnc_codigo int identity primary key,
fnc_cpf varchar(11) not null,
fnc_nome varchar(100) not null,
fnc_endereco varchar(100) not null,
fnc_numero varchar(5) not null,
fnc_complemento varchar(50),
fnc_bairro varchar(100) not null,
fnc_cep varchar(8) not null,
fnc_telefone varchar(15) not null,
fun_codigo int foreign key (fun_codigo) references tb_funcoes_fun)

create table tb_usuario_usu (
usu_codigo int identity primary key,
usu_usuario varchar(20) not null,
usu_senha varchar(20) not null,
usu_ativo bit not null,
fnc_codigo int foreign key (fnc_codigo) references tb_funcionario_fnc)


create table tb_pedido_pdo(
pdo_codigo int identity primary key,
pdo_date date not null,
pdo_andamento int not null,
pdo_total varchar(10) not null,
cli_codigo int not null foreign key (cli_codigo) references tb_cliente_cli,
usu_codigo int not null foreign key (usu_codigo) references tb_usuario_usu,
pag_codigo int not null foreign key (pag_codigo) references tb_pagamento_pag,
fnc_codigo int not null foreign key (fnc_codigo) references tb_funcionario_fnc)

create table tb_propedido_ppd(
ppd_codigo int identity primary key,
pro_codigo int foreign key (pro_codigo) references tb_produto_pro,
pdo_codigo int foreign key (pdo_codigo) references tb_pedido_pdo)


insert tb_funcoes_fun (fun_funcoes) values
('Diretoria'),
('Motoboy'),
('Fun s/ Acesso'),
('Administrador')

insert into tb_categoria_cat
(cat_categoria) values
('Pães'),
('Burguers'),
('Queijos'),
('Ingredientes'),
('Molhos'),
('Acompanhamentos'),
('Bebidas'),
('Ponto')
 
insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Pão: Tradicional', 2.00, 1),
('Pão: c/ Gergelim', 2.00, 1),
('Pão: Australiano', 2.00, 1)

insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Burger: Tradicional', 10.00, 2),
('Burger: Picanha', 15.00, 2),
('Burger: Fraldinha', 14.00, 2),
('Burger: Frango', 12.00, 2),
('Burger: Vegetariano', 12.00, 2)

insert into tb_produto_pro
(pro_nome, pro_venda, cat_codigo)
values
('Ponto: Mal Passado', 0.00, 8),
('Ponto: Ao Ponto', 0.00, 8),
('Ponto: Bem Passado', 0.00, 8)


insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Queijo: Prato', 1.50, 3),
('Queijo: Mussarela', 1.50, 3),
('Queijo: Catupiry', 1.50, 3),
('Queijo: Cheddar', 2.00, 3),
('Queijo: Gorgonzola', 2.00, 3)


insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Ing: Alface', 1.00, 4),
('Ing: Tomate', 1.50, 4),
('Ing: Cebola', 2.00, 4),
('Ing: EGG', 1.00, 4),
('Ing: Tomate Seco', 2.00, 4),
('Ing: Rucula', 1.50, 4),
('Ing: Bacon', 2.00, 4),
('Ing: Picles', 2.50, 4)

insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Molho: Agridoce', 2.00, 5),
('Molho: Maionese', 2.00, 5),
('Molho: Barbecue', 2.00,5),
('Molho: Rose', 2.50, 5),
('Molho: Especial', 3.00, 5)


insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo) values
('Acomp: Batata Frita', 5.00, 6),
('Acomp: Orion Ring', 6.00, 6)

insert into tb_produto_pro 
(pro_nome, pro_venda, cat_codigo ) values
('Bebida: Coca Cola', 4.00, 7),
('Bebida: Coca Cola Zero', 4.00, 7),
('Bebida: Guraná', 4.00, 7),
('Bebida: Guaraná Zero', 4.00, 7),
('Bebida: Fanta Uva', 4.00, 7),
('Bebida: Fanta Laranja', 4.00, 7),
('Bebida: Suco Abacaxi', 5.00, 7),
('Bebida: Suco Morango', 5.00, 7),
('Bebida: Suco Maracuja', 5.00, 7),
('Bebida: Suco Limão', 5.00, 7),
('Bebida: Shake Morango', 8.00, 7),
('Bebida: Shake Baunilha', 8.00, 7),
('Bebida: Shake Chocolate', 8.00, 7)

insert into tb_pagamento_pag (pag_forma) values
('Dinheiro'),
('Débito'),
('Crédito')

insert into tb_funcionario_fnc(
fnc_cpf, fnc_nome, fnc_endereco, fnc_numero, fnc_complemento, fnc_bairro, fnc_cep, fnc_telefone, fun_codigo) values
(00000000000, 'Suporte', 'R. Tito', 00, null, 'Lapa', 00000000, 0000000,  4 )

insert into tb_usuario_usu(
usu_ativo,usu_senha, usu_usuario, fnc_codigo) values
(1, '123', 'suporte', 1)

insert into tb_funcionario_fnc
(fnc_cpf, fnc_nome, fnc_endereco,fnc_numero, fnc_bairro, fnc_cep, fnc_telefone, fun_codigo) values
('12345678902', 'Funcionario 1', 'R.Tito', '84', 'Lapa', '01234567', '25414578', 2),
('12341278903', 'Funcionario 2', 'R.Tito', '84', 'Lapa', '01234567', '25214578', 1)


insert into tb_cliente_cli
(cli_cpf, cli_cnpj, cli_nome, cli_endereco, cli_numero, cli_bairro, cli_cep, cli_cidade, cli_estado, cli_pessoa_fisica) values
('12345678900', '1', 'Cliente 1', 'R.Tito', '84', 'Lapa', '01234567', 'São Paulo',  'SP', 1),
('12345678901', '1', 'Cliente 2', 'R.Tito', '84', 'Lapa', '01234567', 'São Paulo',  'SP', 1)

insert into tb_usuario_usu
(usu_usuario, usu_senha, usu_ativo, fnc_codigo)
values
('fun.2', 123, 1, 3) 

insert into tb_telefone_tel 
(tel_numero, cli_codigo)
values
(987654321, 1),
(123456789, 2)

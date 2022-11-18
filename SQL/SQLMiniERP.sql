create table clientes
(
	idCliente integer primary key identity not null,
	nomeCliente varchar(50) not null,
	cpfCliente varchar(20) not null
)

create table fornecedores
(
	idFornecedor integer primary key identity not null,
	nomeFornecedor varchar(100) not null,
	cnpjFornecedor varchar(50) not null
)

create table produtos
(
	idProduto integer primary key identity not null,
	nomeProduto varchar(50) not null,
	valor float not null,
	peso float not null,
	idFornecedor integer not null
)

create table notas
(
	idNotas integer primary key identity not null,
	dataEmissao date not null,
	idCliente integer not null,
	idProduto integer not null
)

alter table notas
add foreign key (idCliente) references clientes(idCliente)

alter table notas
add foreign key (idProduto) references produtos(idProduto)

alter table produtos
add foreign key (idFornecedor) references fornecedores(idFornecedores)
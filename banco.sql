create database 3C1MARIA29;
use 3C1MARIA29;
create table logar(
	id int not null auto_increment primary key,
    email varchar(50),
    senha varchar(6)
)engine = InnoDB;
insert into logar (id, email, senha) values	(null, 'email', 'senha');
create table produtos(
	id int not null auto_increment primary key,
    nome varchar(80) not null,
	preco varchar(100) not null,
    quantidade varchar(100) not null
)engine = InnoDB;
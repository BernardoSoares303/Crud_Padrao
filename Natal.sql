create database Natal;

use Natal;

create table usuarios(
	id_usuario int primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha_usuario varchar(64) not null
);

create table crianca (
	id_crianca int primary key auto_increment,
    nome varchar(45),
    idade varchar (45),
	genero char,
    bomzinho bool,
    constraint chk_genero check(genero in ('F','M','OUTRO'))
);

select * from usuarios;
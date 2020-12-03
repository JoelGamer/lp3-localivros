CREATE DATABASE localivros;

CREATE TABLE USERS(
	uid INT not null IDENTITY(1,1),
	username VARCHAR(24) not null,
	password VARCHAR(24) not null,
	name VARCHAR(80) not null,
	cpf INT not null,
	PRIMARY KEY(uid),
);

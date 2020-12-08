CREATE DATABASE localivros;

/* CRUD */
CREATE TABLE USERS(
	uid INT not null IDENTITY(1,1),
	username VARCHAR(24) not null,
	password VARCHAR(24) not null,
	name VARCHAR(80) not null,
	cpf INT not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE BOOK(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	description VARCHAR(255) not null,
	author INT not null,
	pages INT not null,
	genre INT not null,
	release_date DATE not null,
	price FLOAT not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE AUTHOR(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	birth_date DATE not null,
	death_date DATE,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE GENRE(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE PURCHASES(
	uid INT not null IDENTITY(1,1),
	book_uid INT not null,
	provider_uid INT not null,
	quantity INT not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE SALES(
	uid INT not null IDENTITY(1,1),
	book_uid INT not null,
	client_uid INT not null,
	quantity INT not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE CLIENTS(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	cnpj BIGINT not null,
	address VARCHAR(120) not null,
	address_number VARCHAR(6) not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE PROVIDERS(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	cnpj BIGINT not null,
	address VARCHAR(120) not null,
	address_number VARCHAR(6) not null,
	PRIMARY KEY(uid),
);

/* CRUD */
CREATE TABLE STOCK(
	uid INT not null IDENTITY(1,1),
	book_uid INT not null,
	quantity INT not null,
	PRIMARY KEY(uid),
);

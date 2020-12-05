CREATE DATABASE localivros;

/* CRUD */
CREATE TABLE USERS(
	uid INT not null IDENTITY(1,1),
	username VARCHAR(24) not null,
	password VARCHAR(24) not null,
	name VARCHAR(80) not null,
	cpf INT not null,
	administrator TINYINT not null,
	PRIMARY KEY(uid),
);

CREATE TABLE USER_BOOKS(
	uid INT not null IDENTITY(1,1),
	user_uid INT not null,
	book_uid INT not null,
);

/* CRUD */
CREATE TABLE USER_PAYMENTS(
	uid INT not null,
	user_uid INT not null,
	card_number VARCHAR(16) not null,
	security_number INT not null,
	valid_thru DATE not null,
	card_name VARCHAR(80) not null,
	address VARCHAR(120) not null,
);

/* CRUD */
CREATE TABLE BOOK(
	uid INT not null IDENTITY(1,1),
	name VARCHAR(80) not null,
	description VARCHAR(255) not null,
	author VARCHAR(120) not null,
	pages INT not null,
	genre INT not null,
	release_date DATE not null,
	quantity INT not null,
	price INT not null,
	PRIMARY KEY(uid),
);

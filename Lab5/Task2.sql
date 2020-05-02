CREATE TABLE "dvd" (
	"dvd_id"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"title"	TEXT NOT NULL,
	"production_year"	INTEGER NOT NULL
);

CREATE TABLE "customer" (
	"customer_id"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"first_name"	TEXT NOT NULL,
	"last_name"	TEXT NOT NULL,
	"passport_code"	INTEGER NOT NULL,
	"registration_date"	DATE NOT NULL
);

CREATE TABLE "offer" (
	"offer_id"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"dvd_id"	INTEGER NOT NULL UNIQUE,
	"customer_id"	INTEGER NOT NULL,
	"offer_date"	DATE NOT NULL,
	"return_date"	DATE
);
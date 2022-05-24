DROP DATABASE IF EXISTS project_commerce;
CREATE DATABASE project_commerce;
USE project_commerce;

CREATE TABLE Kunder(
Kunde_ID int NOT NULL AUTO_INCREMENT,
Navn varchar(45) NOT NULL,
Adresse varchar(45) NOT NULL,
Postnr int NOT NULL,
Bynavn varchar(45) NOT NULL,
Telefon varchar(45) NOT NULL,
Email varchar(45) NOT NULL,
Password varchar(45) NOT NULL,
Nyhedsbrev varchar(10) NOT NULL,
Kundedato datetime,
PRIMARY KEY(Kunde_ID)
);

CREATE TABLE Firmaby(
Bynavn_ID int NOT NULL AUTO_INCREMENT,
Postnr int NOT NULL,
Bynavn varchar(45) NOT NULL,
PRIMARY KEY(Bynavn_ID)
);
insert into Firmaby(Postnr, Bynavn) values(6000, 'Kolding');
insert into Firmaby(Postnr, Bynavn) values(7000, 'Fredericia');

CREATE TABLE Firmaadresse(
Firmaadresse_ID int NOT NULL AUTO_INCREMENT,
Adresse varchar(45) NOT NULL,
Telefon varchar(45) NOT NULL,
Email varchar(45) NOT NULL,
Bynavn_ID int NOT NULL,
PRIMARY KEY(Firmaadresse_ID),
FOREIGN KEY (Bynavn_ID) REFERENCES Firmaby(Bynavn_ID)
);
insert into Firmaadresse(Adresse, Telefon, Email, Bynavn_ID) values('Vonsildvej 2', '33445566', 'vonsild-kolding@testfirma.dk', 1);
insert into Firmaadresse(Adresse, Telefon, Email, Bynavn_ID) values('Skovvangen 46', '44556677', 'skovvang-kolding@testfirma.dk', 1);
insert into Firmaadresse(Adresse, Telefon, Email, Bynavn_ID) values('Vejlevej 106', '55667788', 'fredericia@testfirma.dk', 2);

CREATE TABLE Lokationer(
Lokation_ID int NOT NULL AUTO_INCREMENT,
Lokationsnr int NOT NULL,
Firmaadresse_ID int NOT NULL,
PRIMARY KEY(Lokation_ID),
FOREIGN KEY (Firmaadresse_ID) REFERENCES Firmaadresse(Firmaadresse_ID)
);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(10, 1);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(20, 1);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(30, 1);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(40, 1);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(50, 1);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(10, 2);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(20, 2);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(30, 2);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(40, 2);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(50, 2);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(10, 3);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(20, 3);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(30, 3);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(40, 3);
insert into Lokationer(Lokationsnr, Firmaadresse_ID) values(50, 3);

CREATE TABLE Reoler(
Reol_ID int NOT NULL AUTO_INCREMENT,
Reolnr int NOT NULL,
Lokation_ID int NOT NULL,
PRIMARY KEY(Reol_ID),
FOREIGN KEY (Lokation_ID) REFERENCES Lokationer(Lokation_ID)
);
insert into Reoler(Reolnr, Lokation_ID) values(1, 2);
insert into Reoler(Reolnr, Lokation_ID) values(2, 2);
insert into Reoler(Reolnr, Lokation_ID) values(2, 7);
insert into Reoler(Reolnr, Lokation_ID) values(2, 12);
insert into Reoler(Reolnr, Lokation_ID) values(3, 14);
insert into Reoler(Reolnr, Lokation_ID) values(2, 2);
insert into Reoler(Reolnr, Lokation_ID) values(2, 7);
insert into Reoler(Reolnr, Lokation_ID) values(2, 12);
insert into Reoler(Reolnr, Lokation_ID) values(1, 7);
insert into Reoler(Reolnr, Lokation_ID) values(1, 12);
insert into Reoler(Reolnr, Lokation_ID) values(3, 4);
insert into Reoler(Reolnr, Lokation_ID) values(3, 9);
insert into Reoler(Reolnr, Lokation_ID) values(2, 5);
insert into Reoler(Reolnr, Lokation_ID) values(2, 10);
insert into Reoler(Reolnr, Lokation_ID) values(2, 15);
insert into Reoler(Reolnr, Lokation_ID) values(3, 5);
insert into Reoler(Reolnr, Lokation_ID) values(3, 10);
insert into Reoler(Reolnr, Lokation_ID) values(3, 15);
insert into Reoler(Reolnr, Lokation_ID) values(2, 2);
insert into Reoler(Reolnr, Lokation_ID) values(2, 7);
insert into Reoler(Reolnr, Lokation_ID) values(2, 12);
insert into Reoler(Reolnr, Lokation_ID) values(2, 2);
insert into Reoler(Reolnr, Lokation_ID) values(2, 7);
insert into Reoler(Reolnr, Lokation_ID) values(2, 12);
insert into Reoler(Reolnr, Lokation_ID) values(4, 5);
insert into Reoler(Reolnr, Lokation_ID) values(4, 10);
insert into Reoler(Reolnr, Lokation_ID) values(4, 15);
insert into Reoler(Reolnr, Lokation_ID) values(2, 4);
insert into Reoler(Reolnr, Lokation_ID) values(2, 9);
insert into Reoler(Reolnr, Lokation_ID) values(2, 14);

CREATE TABLE Produkter(
Produkt_ID int NOT NULL AUTO_INCREMENT,
Varenummer int NOT NULL,
Navn varchar(45) NOT NULL,
Lagerbeholdning int NOT NULL,
Enhedsbetegnelse varchar(10) NOT NULL,
Enhedspris float NOT NULL,
Produktdato datetime,
PRIMARY KEY(Produkt_ID)
);
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(2017043, 'CARAMBA RENSESPRAY', 100, 'STK', 9.95, '2021-04-01T10:20:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(1521026, 'MILLARCO SEKUNDLIM 30ML', 200, 'STK', 15.95, '2021-05-01T12:40:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(5186000, 'LOCTITE GLUE PRECISION 5G', 150, 'STK', 19.95, '2021-06-01T14:50:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(2002369, 'DANA RUSTIK LETSPARTEL 636', 50, 'SP', 79.95, '2021-07-01T16:20:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(1721060, 'DANA LETSPARTEL VÅDRUM 626 1LT', 50, 'SP', 69.95, '2021-08-01T15:30:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(5890383, 'DANA TRÆLIM PU 421 LYS 750ML', 120, 'FL', 39.95, '2021-09-01T16:10:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(3447448, 'DANA KLAR KONTAKTLIM 284 40ML', 200, 'TB', 24.95, '2021-10-01T08:45:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(1675321, 'DANA SEKUNDLIM 351 5G', 90, 'FL', 59.95, '2021-11-01T09:35:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(1281345, 'DANA MS MONTAGE EKSTRA 292', 20, 'PTR', 69.95, '2021-12-01T10:15:00');
insert into Produkter(Varenummer, Navn, Lagerbeholdning, Enhedsbetegnelse, Enhedspris, Produktdato) values(1938299, 'XTRAPROFF NBS HELÅRSSKUM 750ML', 30, 'DÅS', 74.95, '2021-12-14T12:15:35');

CREATE TABLE Lagerstatus(
Lagerstatus_ID int NOT NULL AUTO_INCREMENT,
Status varchar(45) NOT NULL,
PRIMARY KEY(Lagerstatus_ID)
);
insert into Lagerstatus(Status) values('OK');
insert into Lagerstatus(Status) values('Kontakt butiksmedarbejder');
insert into Lagerstatus(Status) values('Ikke på lager');
insert into Lagerstatus(Status) values('Udgået');

CREATE TABLE Hylder(
Hylde_ID int NOT NULL AUTO_INCREMENT,
Hyldenr int NOT NULL,
Reol_ID int NOT NULL,
Produkt_ID int NOT NULL,
Antal int NOT NULL,
Lagerstatus_ID int NOT NULL,
PRIMARY KEY(Hylde_ID),
FOREIGN KEY (Reol_ID) REFERENCES Reoler(Reol_ID),
FOREIGN KEY (Produkt_ID) REFERENCES Produkter(Produkt_ID),
FOREIGN KEY (Lagerstatus_ID) REFERENCES Lagerstatus(Lagerstatus_ID)
);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 1, 1, 6, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 2, 2, 2, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 3, 2, 4, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 4, 2, 3, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 5, 3, 3, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 6, 6, 5, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 7, 6, 5, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 8, 6, 7, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 9, 1, 6, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 10, 1, 8, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 11, 3, 3, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 12, 3, 2, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 13, 4, 10, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 14, 4, 11, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 15, 4, 14, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 16, 5, 20, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 17, 5, 18, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(2, 18, 5, 16, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 19, 7, 14, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 20, 7, 13, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(3, 21, 7, 17, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(4, 22, 8, 19, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(4, 23, 8, 15, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(4, 24, 8, 9, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(5, 25, 9, 6, 2);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(5, 26, 9, 2, 2);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(5, 27, 9, 1, 2);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 28, 10, 12, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 29, 10, 17, 1);
insert into Hylder(Hyldenr, Reol_ID, Produkt_ID, Antal, Lagerstatus_ID) values(1, 30, 10, 0, 3);

CREATE TABLE Leveringsdatoer(
Leveringsdato_ID int NOT NULL AUTO_INCREMENT,
Leveringsdato date,
Hylde_ID int NOT NULL,
PRIMARY KEY(Leveringsdato_ID),
FOREIGN KEY (Hylde_ID) REFERENCES Hylder(Hylde_ID)
);
insert into Leveringsdatoer(Leveringsdato, Hylde_ID) values('2022-06-20', 30);

CREATE TABLE Ordrer(
Ordre_ID int NOT NULL AUTO_INCREMENT,
Kunde_ID int NOT NULL, 
Ordredato datetime,
Firmaadresse_ID int NOT NULL,
PRIMARY KEY(Ordre_ID),
FOREIGN KEY (Kunde_ID) REFERENCES Kunder(Kunde_ID),
FOREIGN KEY (Firmaadresse_ID) REFERENCES Firmaadresse(Firmaadresse_ID)
);

CREATE TABLE Ordrelinjer(
Ordrelinje_ID int NOT NULL AUTO_INCREMENT,
Ordre_ID int NOT NULL,
Produkt_ID int NOT NULL,
Antal int NOT NULL,
Pris float NOT NULL,
PRIMARY KEY(Ordrelinje_ID),
FOREIGN KEY (Ordre_ID) REFERENCES Ordrer(Ordre_ID) ON DELETE CASCADE,
FOREIGN KEY (Produkt_ID) REFERENCES Produkter(Produkt_ID)
);

CREATE TABLE Kundelog (
ID int NOT NULL AUTO_INCREMENT,
Kunde_ID int NOT NULL,
Navn varchar(45) NOT NULL,
Adresse varchar(45) NOT NULL,
Postnr int NOT NULL,
Bynavn varchar(45) NOT NULL,
Telefon varchar(45) NOT NULL,
Email varchar(45) NOT NULL,
Password varchar(45) NOT NULL,
Nyhedsbrev varchar(10) NOT NULL,
Kundedato datetime,
Aendringsdato DATETIME DEFAULT NULL,
action VARCHAR(50) DEFAULT NULL,
PRIMARY KEY(ID)
);

CREATE TRIGGER before_kunde_update
BEFORE UPDATE ON Kunder
FOR EACH ROW 
INSERT INTO Kundelog
SET action = 'update', Kunde_ID=OLD.Kunde_ID, Navn=OLD.Navn, Adresse = OLD.Adresse, Postnr = OLD.Postnr, Bynavn = OLD.Bynavn, Telefon = OLD.Telefon, Email = OLD.Email, Password = OLD.Password, Nyhedsbrev = OLD.Nyhedsbrev, Kundedato = OLD.Kundedato, Aendringsdato = NOW();

CREATE TRIGGER before_kunde_delete
BEFORE DELETE ON Kunder
FOR EACH ROW 
INSERT INTO Kundelog
SET action = 'delete', Kunde_ID=OLD.Kunde_ID, Navn=OLD.Navn, Adresse = OLD.Adresse, Postnr = OLD.Postnr, Bynavn = OLD.Bynavn, Telefon = OLD.Telefon, Email = OLD.Email, Password = OLD.Password, Nyhedsbrev = OLD.Nyhedsbrev, Kundedato = OLD.Kundedato, Aendringsdato = NOW();

CREATE TRIGGER before_kunde_insert
BEFORE INSERT ON Kunder
FOR EACH ROW 
INSERT INTO Kundelog
SET action = 'insert', Kunde_ID=NEW.Kunde_ID, Navn=NEW.Navn, Adresse = NEW.Adresse, Postnr = NEW.Postnr, Bynavn = NEW.Bynavn, Telefon = NEW.Telefon, Email = NEW.Email, Password = NEW.Password, Nyhedsbrev = NEW.Nyhedsbrev, Kundedato = NEW.Kundedato, Aendringsdato = NOW();

CREATE TABLE Ordrelog (
ID int NOT NULL AUTO_INCREMENT,
Ordre_ID int NOT NULL,
Kunde_ID int DEFAULT NULL,
Ordredato datetime DEFAULT NULL,
Firmaadresse_ID int NOT NULL,
Aendringsdato DATETIME DEFAULT NULL,
action VARCHAR(50) DEFAULT NULL,
PRIMARY KEY(ID)
);

CREATE TRIGGER before_order_update
BEFORE UPDATE ON Ordrer
FOR EACH ROW 
INSERT INTO Ordrelog
SET action = 'update', Ordre_ID=OLD.Ordre_ID, Kunde_ID=OLD.Kunde_ID, Ordredato = OLD.Ordredato, Firmaadresse_ID = OLD.Firmaadresse_ID, Aendringsdato = NOW();

CREATE TRIGGER before_order_delete
BEFORE DELETE ON Ordrer
FOR EACH ROW 
INSERT INTO Ordrelog
SET action = 'delete', Ordre_ID=OLD.Ordre_ID, Kunde_ID=OLD.Kunde_ID, Ordredato = OLD.Ordredato, Firmaadresse_ID = OLD.Firmaadresse_ID, Aendringsdato = NOW();

CREATE TRIGGER before_order_insert
BEFORE INSERT ON Ordrer
FOR EACH ROW 
INSERT INTO Ordrelog
SET action = 'insert', Ordre_ID=NEW.Ordre_ID, Kunde_ID=NEW.Kunde_ID, Ordredato = NEW.Ordredato, Firmaadresse_ID = NEW.Firmaadresse_ID, Aendringsdato = NOW();

CREATE TABLE Produktlog (
ID int NOT NULL AUTO_INCREMENT,
Produkt_ID int NOT NULL,
Varenummer int NOT NULL,
Navn varchar(45) NOT NULL,
Lagerbeholdning int NOT NULL,
Enhedsbetegnelse varchar(45) NOT NULL,
Enhedspris float NOT NULL,
Produktdato datetime,
Aendringsdato DATETIME DEFAULT NULL,
action VARCHAR(50) DEFAULT NULL,
PRIMARY KEY(ID)
);

CREATE TRIGGER before_product_update
BEFORE UPDATE ON Produkter
FOR EACH ROW 
INSERT INTO Produktlog
SET action = 'update', Produkt_ID=OLD.Produkt_ID, Varenummer = OLD.Varenummer, Navn = OLD.Navn, Lagerbeholdning = OLD.Lagerbeholdning, Enhedsbetegnelse = OLD.Enhedsbetegnelse, Enhedspris = OLD.Enhedspris, Produktdato = OLD.Produktdato, Aendringsdato = NOW();

CREATE TRIGGER before_product_delete
BEFORE DELETE ON Produkter
FOR EACH ROW 
INSERT INTO Produktlog
SET action = 'delete', Produkt_ID=OLD.Produkt_ID, Varenummer = OLD.Varenummer, Navn = OLD.Navn, Lagerbeholdning = OLD.Lagerbeholdning, Enhedsbetegnelse = OLD.Enhedsbetegnelse, Enhedspris = OLD.Enhedspris, Produktdato = OLD.Produktdato, Aendringsdato = NOW();

CREATE TRIGGER before_product_insert
BEFORE INSERT ON Produkter
FOR EACH ROW 
INSERT INTO Produktlog
SET action = 'insert', Produkt_ID=NEW.Produkt_ID, Varenummer = NEW.Varenummer, Navn = NEW.Navn, Lagerbeholdning = NEW.Lagerbeholdning, Enhedsbetegnelse = NEW.Enhedsbetegnelse, Enhedspris = NEW.Enhedspris, Produktdato = NEW.Produktdato, Aendringsdato = NOW();

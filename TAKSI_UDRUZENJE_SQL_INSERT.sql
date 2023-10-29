
---------------Dodavanje Vozaca u bazu podataka------------------------------------------------
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, Kategorija, BrVDozvole)
VALUES('5618819209125', 'Ilija', 'D', 'Jovic', 'Stutgartova 15', '0641234453', 'Vozac','B','001234562');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, Kategorija, BrVDozvole)
VALUES('1430019209172', 'Strahinja', 'C', 'Aleksic', 'Ucitelj Tasina 2', '0612231191', 'Vozac', 'B','019101123');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, Kategorija, BrVDozvole)
VALUES('9081119002356', 'Veljko', 'M', 'Djordjevic', 'Marsala Tita 27', '063333412', 'Vozac', 'B','100381257');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, Kategorija, BrVDozvole)
VALUES('0019375788122', 'Marko', 'G', 'Jankovic', 'Duvanska 23', '0621774144', 'Vozac','B','180454328');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, Kategorija, BrVDozvole)
VALUES('2777819935191', 'Matija', 'Z', 'Joksimovic', 'Obilicev venac 61', '0605111923', 'Vozac', 'B', '000991255');
------------------------------------------------------------------------------------------------

---------------Dodavanje Administrativnog Osoblja u bazu podataka--------------------------------
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, StrucnaSprema)
VALUES('1232222235188','Vukasin','G','Velickovic','Kneza Lazara 58','0630099185', 'Admin', 'VŠS viša škola');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, StrucnaSprema)
VALUES('0023351237771','Milica','R','Krstic','Hajduk Stanka 34','0606559221', 'Admin', 'Osnovne četvorogodišnje akademske studije');
INSERT INTO Zaposleni (JMBG, LIme, SSlovo, Prezime, Adresa, BrojTelefona, TipZaposleni, StrucnaSprema)
VALUES('3331111998235','Ivan','G','Damjanovic','Knjazevacka 76','0630099185', 'Admin', 'Osnovne trogodišnje strukovne studije');
-------------------------------------------------------------------------------------------------

---------------Dodavanje Sopstvenih Vozila u bazu podataka--------------------------------
INSERT INTO Sopstveno_Vozilo(JMBG_Vozaca, TipVozila, Boja, Marka, DatumOd, DatumDo)
VALUES('9081119002356','Subcompact','Red','Ford', TO_DATE('13.05.2007','DD.MM.RRRR'),TO_DATE('15.08.2012','DD.MM.RRRR'));
INSERT INTO Sopstveno_Vozilo(JMBG_Vozaca, TipVozila, Boja, Marka, DatumOd, DatumDo)
VALUES('1430019209172','Mid-size','Black','Peugeot', TO_DATE('19.02.2014','DD.MM.RRRR'),TO_DATE('20.09.2021','DD.MM.RRRR'));
INSERT INTO Sopstveno_Vozilo(JMBG_Vozaca, TipVozila, Boja, Marka, DatumOd)
VALUES('9081119002356','Mid-size','Yellow','Audi', TO_DATE('24.06.2014','DD.MM.RRRR'));
------------------------------------------------------------------------------------------

--------------Dodavanje TAXI_VOZILO u bazu podataka--------------------------------
INSERT INTO Taxi_Vozilo (RegOznaka, Marka, Tip, DatumIstekaReg, GodinaProizvodnje)
VALUES('NI1202RE','Tesla','Mid-size',TO_DATE('23.09.2026','DD.MM.RRRR'), 2018);
INSERT INTO Taxi_Vozilo (RegOznaka, Marka, Tip, DatumIstekaReg, GodinaProizvodnje)
VALUES('NS2019KD','Toyota','Compact',TO_DATE('12.11.2025','DD.MM.RRRR'), 2016);
INSERT INTO Taxi_Vozilo (RegOznaka, Marka, Tip, DatumIstekaReg, GodinaProizvodnje)
VALUES('BG8877TR','Mercedes','Compact',TO_DATE('09.10.2023','DD.MM.RRRR'), 2011);
INSERT INTO Taxi_Vozilo (RegOznaka, Marka, Tip, DatumIstekaReg, GodinaProizvodnje)
VALUES('NI911TT','Hyundai','Large',TO_DATE('15.04.2024','DD.MM.RRRR'), 2014);
INSERT INTO Taxi_Vozilo (RegOznaka, Marka, Tip, DatumIstekaReg, GodinaProizvodnje)
VALUES('KG3311PZ','KIA','Hybrid',TO_DATE('17.03.2028','DD.MM.RRRR'), 2020);
-----------------------------------------------------------------------------------

-----------------Dodavanje DODELJENO u bazu podataka---------------------------
INSERT INTO Dodeljeno (RegOznaka, JMBG_Vozaca, DatumOd, DatumDo)
VALUES('BG8877TR','0019375788122',TO_DATE('11.07.2019','DD.MM.RRRR'),TO_DATE('12.03.2021','DD.MM.RRRR'));
INSERT INTO Dodeljeno (RegOznaka, JMBG_Vozaca, DatumOd)
VALUES('KG3311PZ','5618819209125',TO_DATE('05.10.2020','DD.MM.RRRR'));
---------------------------------------------------------------------------------

-----------------Dodavanje REDOVNA_MUSTERIJA u bazu podataka---------------------
INSERT INTO Redovna_Musterija (Adresa, BrojKoriscenihVoznji)
VALUES ('Cara Dusana 97', 24);
INSERT INTO Redovna_Musterija (Adresa, BrojKoriscenihVoznji)
VALUES ('Knjazevacka 50', 12);
INSERT INTO Redovna_Musterija (Adresa, BrojKoriscenihVoznji)
VALUES ('Gabrovacka 30', 7);
INSERT INTO Redovna_Musterija (Adresa, BrojKoriscenihVoznji)
VALUES ('Filipa Visnjica', 9);
---------------------------------------------------------------------------------

---------------------Dodavanje VOZNJA u bazu podataka------------------------------------------------
INSERT INTO Voznja (PStanica, KStanica, PVreme, KVreme, BrojPoziva, VremePrimPoziva, JMBG_V, JMBG_A, ID_Musterija)
VALUES ('Generala Boze Jankovica 16','Aleksandra Medvedeva 14', TO_TIMESTAMP('09.03.2021 14:16:32', 'DD.MM.RRRR HH24:MI:SS'),TO_TIMESTAMP('09.03.2021 14:27:22', 'DD.MM.RRRR HH24:MI:SS'), '0601128817', TO_TIMESTAMP('09.03.2021 14:10:17', 'DD.MM.RRRR HH24:MI:SS'),'5618819209125','0023351237771',1);
INSERT INTO Voznja (PStanica, KStanica, PVreme, KVreme, BrojPoziva, VremePrimPoziva, JMBG_V, JMBG_A)
VALUES ('Karlovacka 71','Dr Zoran Djindjic Boulevard 81', TO_TIMESTAMP('18.11.2020 09:10:32', 'DD.MM.RRRR HH24:MI:SS'),TO_TIMESTAMP('18.11.2020 09:20:22', 'DD.MM.RRRR HH24:MI:SS'), '0636678111',TO_TIMESTAMP('18.11.2020 09:04:10', 'DD.MM.RRRR HH24:MI:SS'),'0019375788122','3331111998235');
INSERT INTO Voznja (PStanica, KStanica, PVreme, KVreme, BrojPoziva, VremePrimPoziva, JMBG_V, JMBG_A, ID_Musterija)
VALUES ('Ucitelj Tasina 8','Nikole Pasica 38', TO_TIMESTAMP('20.04.2019 15:05:12', 'DD.MM.RRRR HH24:MI:SS'),TO_TIMESTAMP('20.04.2019 15:17:34', 'DD.MM.RRRR HH24:MI:SS'), '0658869112',TO_TIMESTAMP('20.04.2019 14:58:34', 'DD.MM.RRRR HH24:MI:SS'),'5618819209125','0023351237771', 2);
INSERT INTO Voznja (PStanica, KStanica, PVreme, KVreme, BrojPoziva, VremePrimPoziva, JMBG_V, JMBG_A)
VALUES ('Oblacinska 4','Vojvode Misica 2', TO_TIMESTAMP('25.06.2018 12:02:16', 'DD.MM.RRRR HH24:MI:SS'),TO_TIMESTAMP('25.06.2018 12:18:22', 'DD.MM.RRRR HH24:MI:SS'), '062290010',TO_TIMESTAMP('25.06.2018 11:55:41', 'DD.MM.RRRR HH24:MI:SS'),'9081119002356','3331111998235');
INSERT INTO Voznja (PStanica, KStanica, PVreme, KVreme, BrojPoziva, JMBG_V, JMBG_A, ID_Musterija)
VALUES ('Mokranjceva 10','Aleksandra Medvedeva 14', TO_TIMESTAMP('12.07.2019 10:08:07', 'DD.MM.RRRR HH24:MI:SS'),TO_TIMESTAMP('12.07.2019 10:17:45', 'DD.MM.RRRR HH24:MI:SS'), '0662277817','1430019209172','1232222235188',4);
-----------------------------------------------------------------------------------------------------

---------------------Dodavanje BROJ_TELEFONA u bazu podataka---------------------------
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (1, '0601128817');
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (2, '0633311126');
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (1, '018339223');
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (4, '0658869112');
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (3,'0622818123');
INSERT INTO Broj_Telefona (ID_Musterija, BrojTelefona)
VALUES (3,'0662277817');
-------------------------------------------------------------------------------------











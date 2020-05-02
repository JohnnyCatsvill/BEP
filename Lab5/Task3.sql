INSERT INTO dvd (title, production_year)
VALUES ('Хатико: Самый верный друг', 2009);

INSERT INTO dvd (title, production_year)
VALUES ('Пеле: Рождение легенды', 2016);

INSERT INTO dvd (title, production_year)
VALUES ('Майкл Джексон: Вот и всё', 2009);

INSERT INTO dvd (title, production_year)
VALUES ('Вольт', 2008);

INSERT INTO dvd (title, production_year)
VALUES ('Океаны', 2009);

INSERT INTO dvd (title, production_year)
VALUES ('Меня зовут Кхан', 2010);

INSERT INTO dvd (title, production_year)
VALUES ('Гонка', 2013);

INSERT INTO dvd (title, production_year)
VALUES ('Как приручить дракона', 2010);

INSERT INTO dvd (title, production_year)
VALUES ('Чудо', 2017);

INSERT INTO dvd (title, production_year)
VALUES ('Медведь Йоги', 2010);

INSERT INTO dvd (title, production_year)
VALUES ('Зверополис', 2016);

INSERT INTO dvd (title, production_year)
VALUES ('1+1', 2012);

INSERT INTO dvd (title, production_year)
VALUES ('Гнездо жаворонка', 2008);

INSERT INTO dvd (title, production_year)
VALUES ('Одарённая', 2017);

INSERT INTO dvd (title, production_year)
VALUES ('Шёпот сердца', 2009);

INSERT INTO dvd (title, production_year)
VALUES ('Король Лев 3D', 2012);

INSERT INTO dvd (title, production_year)
VALUES ('История дельфина', 2011);

INSERT INTO dvd (title, production_year)
VALUES ('Элегия', 2008);

INSERT INTO dvd (title, production_year)
VALUES ('Приключения Паддингтона 2', 2018);

INSERT INTO dvd (title, production_year)
VALUES ('Ford против Ferrari', 2019);



INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Руслан', 'Повалий', 5444877382, '2006-09-06');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Ираклий', 'Зварыч', 7924242067, '2007-01-27');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Эдуард', 'Сыпченко', 4788792772, '2014-11-21');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Леонид', 'Афанасьев', 1994145430, '2014-12-07');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Илья', 'Макаров', 8605102918, '2016-12-04');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Евстахий', 'Зайцев', 2532175352, '2013-11-08');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Нестор', 'Спивак', 9561496378, '2018-12-04');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Бронислав', 'Ларионов', 6623764339, '2014-04-19');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Цефас', 'Выговский', 2181737630, '2010-03-26');

INSERT INTO customer (first_name, last_name, passport_code, registration_date)
VALUES ('Ян', 'Кондратьев', 8783040342, '2005-05-17');



INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (4, 2, '2020-01-22', '2020-02-15');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (13, 3, '2015-03-02', '2015-04-11');

INSERT INTO offer (dvd_id, customer_id, offer_date)
VALUES (7, 1, '2014-05-03');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (1, 5, '2017-06-04', '2017-10-28');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (9, 9, '2018-03-30', '2018-10-07');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (11, 7, '2019-02-14', '2019-05-05');

INSERT INTO offer (dvd_id, customer_id, offer_date)
VALUES (18, 2, '2014-11-01');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (15, 1, '2011-10-11', '2011-11-11');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (5, 2, '2015-10-20', '2016-06-21');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (8, 9, '2016-08-08', '2017-08-28');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (12, 6, '2018-02-10', '2018-04-08');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (17, 8, '2014-10-12', '2015-01-31');

INSERT INTO offer (dvd_id, customer_id, offer_date)
VALUES (10, 5, '2020-02-10');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (6, 10, '2011-07-31', '2012-03-06');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES (3, 9, '2013-02-17', '2014-04-09');
DROP TABLE Ranks;
DROP TABLE Price_list;
DROP TABLE Znaki;
DROP SEQUENCE ZNAKI_ZNAK_KACH_ID_SEQ;
DROP TABLE Ship_companies;
DROP SEQUENCE SHIP_COMPANIES_SHIP_COMP_ID_SEQ;
DROP TABLE purchases;
DROP SEQUENCE PURCHASES_PURCHASE_ID_SEQ;
DROP TABLE Tovaru;
DROP SEQUENCE TOVARU_TOVAR_ID_SEQ;
DROP TABLE Employees_c;
DROP SEQUENCE EMPLOYEES_C_EMPLOYEE_ID_SEQ;
DROP TABLE Shops;
DROP SEQUENCE SHOPS_SHOP_ID_SEQ;
DROP TABLE Jobs_c;
DROP SEQUENCE JOBS_C_JOB_ID_SEQ;
DROP TABLE Locations_c;
DROP SEQUENCE LOCATIONS_C_LOCATION_ID_SEQ;


CREATE TABLE Locations_c (
	location_id NUMBER(10) NOT NULL,
	country VARCHAR2(20) NOT NULL,
	region VARCHAR2(20) NOT NULL,
	city VARCHAR2(20) NOT NULL,
	address VARCHAR2(50) NOT NULL,
	constraint LOCATIONS_C_PK PRIMARY KEY (location_id));

CREATE sequence LOCATIONS_C_LOCATION_ID_SEQ;


CREATE TABLE Jobs_c (
	job_id NUMBER(10) NOT NULL,
	job_name VARCHAR2(25) UNIQUE NOT NULL,
	constraint JOBS_C_PK PRIMARY KEY (job_id));

CREATE sequence JOBS_C_JOB_ID_SEQ;


CREATE TABLE Shops (
	shop_id NUMBER(10) NOT NULL,
	shop_name VARCHAR2(25) NOT NULL,
	location_id NUMBER(10) NOT NULL,
	opening_date DATE NOT NULL,
	rent_price NUMBER(10),
	phone_num VARCHAR2(20) NOT NULL,
	constraint SHOPS_PK PRIMARY KEY (shop_id));

ALTER TABLE Shops ADD CONSTRAINT Shops_fk0 FOREIGN KEY (location_id) REFERENCES Locations_c(location_id);

CREATE sequence SHOPS_SHOP_ID_SEQ;


CREATE TABLE Employees_c (
	employee_id NUMBER(10) NOT NULL,
	first_name VARCHAR2(15) NOT NULL,
	last_name VARCHAR2(15) NOT NULL,
	shop_id NUMBER(10) NOT NULL,
	job_id NUMBER(10) NOT NULL,
	salary NUMBER(10) NOT NULL,
	manager_id NUMBER(10),
	constraint EMPLOYEES_C_PK PRIMARY KEY (employee_id));

ALTER TABLE Employees_c ADD CONSTRAINT Employees_c_fk0 FOREIGN KEY (shop_id) REFERENCES Shops(shop_id);
ALTER TABLE Employees_c ADD CONSTRAINT Employees_c_fk1 FOREIGN KEY (job_id) REFERENCES Jobs_c(job_id);
ALTER TABLE Employees_c ADD CONSTRAINT Employees_c_fk2 FOREIGN KEY (manager_id) REFERENCES Employees_c(employee_id);

CREATE sequence EMPLOYEES_C_EMPLOYEE_ID_SEQ;


CREATE TABLE Tovaru (
	tovar_id NUMBER(10) NOT NULL,
	tovar_name VARCHAR2(25) NOT NULL,
	characters VARCHAR2(200) NOT NULL,
	constraint TOVARU_PK PRIMARY KEY (tovar_id));

CREATE sequence TOVARU_TOVAR_ID_SEQ;


CREATE TABLE purchases (
	purchase_id NUMBER(15) NOT NULL,
	tovar_id NUMBER(10) NOT NULL,
	kolvo NUMBER(10) NOT NULL,
	purch_date DATE NOT NULL,
	constraint PURCHASES_PK PRIMARY KEY (purchase_id,tovar_id));

ALTER TABLE purchases ADD CONSTRAINT purchases_fk0 FOREIGN KEY (tovar_id) REFERENCES Tovaru(tovar_id);

CREATE sequence PURCHASES_PURCHASE_ID_SEQ;


CREATE TABLE Ship_companies (
	ship_comp_id NUMBER(10) NOT NULL,
	comp_name VARCHAR2(40) NOT NULL,
	phone_number VARCHAR2(20) NOT NULL,
	manager_fio VARCHAR2(40) NOT NULL,
	constraint SHIP_COMPANIES_PK PRIMARY KEY (ship_comp_id));

CREATE sequence SHIP_COMPANIES_SHIP_COMP_ID_SEQ;


CREATE TABLE Znaki (
	znak_kach_id NUMBER(10) NOT NULL,
	znak_kach_name VARCHAR2(50) NOT NULL,
	info VARCHAR2(200) NOT NULL,
	constraint ZNAKI_PK PRIMARY KEY (znak_kach_id));

CREATE sequence ZNAKI_ZNAK_KACH_ID_SEQ;


CREATE TABLE Price_list (
	shop_id NUMBER(10) NOT NULL,
	tovar_id NUMBER(10) NOT NULL,
	ship_date DATE NOT NULL,
	our_price NUMBER(10) NOT NULL,
	sell_price NUMBER(10) NOT NULL,
	kolvo NUMBER(10) NOT NULL,
	ship_comp_id NUMBER(10) NOT NULL,
	constraint PRICE_LIST_PK PRIMARY KEY (shop_id,tovar_id,ship_date));

ALTER TABLE Price_list ADD CONSTRAINT Price_list_fk0 FOREIGN KEY (shop_id) REFERENCES Shops(shop_id);
ALTER TABLE Price_list ADD CONSTRAINT Price_list_fk1 FOREIGN KEY (tovar_id) REFERENCES Tovaru(tovar_id);
ALTER TABLE Price_list ADD CONSTRAINT Price_list_fk2 FOREIGN KEY (ship_comp_id) REFERENCES Ship_companies(ship_comp_id);


CREATE TABLE Ranks (
	ship_comp_id NUMBER(10) NOT NULL,
	znak_kach_id NUMBER(10) NOT NULL,
	constraint RANKS_PK PRIMARY KEY (ship_comp_id,znak_kach_id));

ALTER TABLE Ranks ADD CONSTRAINT Ranks_fk0 FOREIGN KEY (ship_comp_id) REFERENCES Ship_companies(ship_comp_id);
ALTER TABLE Ranks ADD CONSTRAINT Ranks_fk1 FOREIGN KEY (znak_kach_id) REFERENCES Znaki(znak_kach_id);

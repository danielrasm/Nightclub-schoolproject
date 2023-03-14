CREATE DATABASE Project_NightClub
GO

USE Project_NightClub
GO


CREATE TABLE CITIES
( 
	City                 char(30)  NOT NULL 
)
go

CREATE TABLE CLUBS
( 
	Club_ID              integer IDENTITY(1,1)  NOT NULL ,
	ClubName             char(40)  NULL ,
	City                 char(30)  NOT NULL ,
	Country              char(30)  NOT NULL 
)
go

CREATE TABLE COUNTRIES
( 
	Country              char(30)  NOT NULL 
)
go

CREATE TABLE ENTRY
( 
	Entry_ID             integer IDENTITY(1,1)  NOT NULL ,
	TimeOfEntry          datetime  NULL ,
	ID_Number            integer  NOT NULL ,
	Club_ID              integer  NULL 
)
go

CREATE TABLE MEMBERS
( 
	ID_Number            integer  NOT NULL ,
	FirstName            char(18)  NULL ,
	LastName             char(18)  NULL ,
	Orientation          char(18)  NULL ,
	Sex                  char(18)  NULL ,
	Membership_ID        integer  NOT NULL ,
	Country              char(30)  NOT NULL 
)
go

CREATE TABLE MEMBERSHIP
( 
	Membership_ID        integer  NOT NULL ,
	Price                money  NULL ,
	MembershipName       char(18)  NULL 
)
go

CREATE TABLE TIMELOG
( 
	RegistrationDate     datetime  NULL ,
	ID_Number            integer  NOT NULL 
)
go

ALTER TABLE CITIES
	ADD PRIMARY KEY  CLUSTERED (City ASC)
go

ALTER TABLE CLUBS
	ADD PRIMARY KEY  CLUSTERED (Club_ID ASC)
go

ALTER TABLE COUNTRIES
	ADD PRIMARY KEY  CLUSTERED (Country ASC)
go

ALTER TABLE ENTRY
	ADD PRIMARY KEY  CLUSTERED (Entry_ID ASC)
go

ALTER TABLE MEMBERS
	ADD PRIMARY KEY  CLUSTERED (ID_Number ASC)
go

ALTER TABLE MEMBERSHIP
	ADD PRIMARY KEY  CLUSTERED (Membership_ID ASC)
go

ALTER TABLE TIMELOG
	ADD PRIMARY KEY  CLUSTERED (ID_Number ASC)
go


ALTER TABLE CLUBS
	ADD  FOREIGN KEY (City) REFERENCES CITIES(City)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE CLUBS
	ADD  FOREIGN KEY (Country) REFERENCES COUNTRIES(Country)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE ENTRY
	ADD  FOREIGN KEY (ID_Number) REFERENCES MEMBERS(ID_Number)
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go

ALTER TABLE ENTRY
	ADD  FOREIGN KEY (Club_ID) REFERENCES CLUBS(Club_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE MEMBERS
	ADD  FOREIGN KEY (Membership_ID) REFERENCES MEMBERSHIP(Membership_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE MEMBERS
	ADD  FOREIGN KEY (Country) REFERENCES COUNTRIES(Country)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE TIMELOG
	ADD  FOREIGN KEY (ID_Number) REFERENCES MEMBERS(ID_Number)
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go



-------------------------------------------------------------------------------------------------------------------
--------------------------------------Insert into, triggers and USPs:----------------------------------------------
-------------------------------------------------------------------------------------------------------------------

INSERT INTO CITIES
VALUES
	('London'),
	('Berlin'),
	('New York'),
	('Paris'),
	('Rio de Janeiro');
GO

INSERT INTO COUNTRIES
VALUES
('Afghanistan'),
('Aland Islands'),
('Albania'),
('Algeria'),
('American Samoa'),
('Andorra'),
('Angola'),
('Anguilla'),
('Antarctica'),
('Antigua and Barbuda'),
('Argentina'),
('Armenia'),
('Aruba'),
('Australia'),
('Austria'),
('Azerbaijan'),
('Bahamas'),
('Bahrain'),
('Bangladesh'),
('Barbados'),
('Belarus'),
('Belgium'),
('Belize'),
('Benin'),
('Bermuda'),
('Bhutan'),
('Bolivia'),
('Bosnia and Herzegovina'),
('Botswana'),
('Bouvet Island'),
('Brazil'),
('British Indian Ocean Territory'),
('Brunei Darussalam'),
('Bulgaria'),
('Burkina Faso'),
('Burundi'),
('Cambodia'),
('Cameroon'),
('Canada'),
('Cape Verde'),
('Cayman Islands'),
('Central African Republic'),
('Chad'),
('Chile'),
('China'),
('Christmas Island'),
('Colombia'),
('Comoros'),
('Congo'),
('Cook Islands'),
('Costa Rica'),
('Ivoire'),
('Croatia'),
('Cuba'),
('Curacao'),
('Cyprus'),
('Czech Republic'),
('Denmark'),
('Djibouti'),
('Dominica'),
('Dominican Republic'),
('Ecuador'),
('Egypt'),
('El Salvador'),
('Equatorial Guinea'),
('Eritrea'),
('Estonia'),
('Ethiopia'),
('Falkland Islands'),
('Faroe Islands'),
('Fiji'),
('Finland'),
('France'),
('French Guiana'),
('French Polynesia'),
('French Southern Territories'),
('Gabon'),
('Gambia'),
('Georgia'),
('Germany'),
('Ghana'),
('Gibraltar'),
('Greece'),
('Greenland'),
('Grenada'),
('Guadeloupe'),
('Guam'),
('Guatemala'),
('Guernsey'),
('Guinea'),
('Guinea-Bissau'),
('Guyana'),
('Haiti'),
('Vatican City'),
('Honduras'),
('Hong Kong'),
('Hungary'),
('Iceland'),
('India'),
('Indonesia'),
('Iran'),
('Iraq'),
('Ireland'),
('Isle [of] Man'),
('Israel'),
('Italy'),
('Jamaica'),
('Japan'),
('Jersey'),
('Jordan'),
('Kazakhstan'),
('Kenya'),
('Kiribati'),
('Korea'),
('Kosovo'),
('Kuwait'),
('Kyrgyzstan'),
('Latvia'),
('Lebanon'),
('Lesotho'),
('Liberia'),
('Libyan Arab Jamahiriya'),
('Liechtenstein'),
('Lithuania'),
('Luxembourg'),
('Macao'),
('Macedonia'),
('Madagascar'),
('Malawi'),
('Malaysia'),
('Maldives'),
('Mali'),
('Malta'),
('Marshall Islands'),
('Martinique'),
('Mauritania'),
('Mauritius'),
('Mayotte'),
('Mexico'),
('Micronesia'),
('Moldova'),
('Monaco'),
('Mongolia'),
('Montenegro'),
('Montserrat'),
('Morocco'),
('Mozambique'),
('Myanmar'),
('Namibia'),
('Nauru'),
('Nepal'),
('Netherlands'),
('Netherlands Antilles'),
('New Caledonia'),
('New Zealand'),
('Nicaragua'),
('Niger'),
('Nigeria'),
('Niue'),
('Norfolk Island'),
('Northern Mariana Islands'),
('Norway'),
('Oman'),
('Pakistan'),
('Palau'),
('Palestinia'),
('Panama'),
('Papua New Guinea'),
('Paraguay'),
('Peru'),
('Philippines'),
('Pitcairn'),
('Poland'),
('Portugal'),
('Puerto Rico'),
('Qatar'),
('Reunion'),
('Romania'),
('Russian Federation'),
('Rwanda'),
('Saint Barthelemy'),
('Saint Helena'),
('Saint Kitts [and] Nevis'),
('Saint Lucia'),
('Saint Martin'),
('Saint Pierre [and] Miquelon'),
('Samoa'),
('San Marino'),
('Sao Tome [and] Principe'),
('Saudi Arabia'),
('Senegal'),
('Serbia'),
('Serbia [and] Montenegro'),
('Seychelles'),
('Sierra Leone'),
('Singapore'),
('Sint Maarten'),
('Slovakia'),
('Slovenia'),
('Solomon Islands'),
('Somalia'),
('South Africa'),
('South Sudan'),
('Spain'),
('Sri Lanka'),
('Sudan'),
('Suriname'),
('Svalbard [and] Jan Mayen'),
('Swaziland'),
('Sweden'),
('Switzerland'),
('Syrian Arab Republic'),
('Taiwan'),
('Tajikistan'),
('Tanzania'),
('Thailand'),
('Timor-Leste'),
('Togo'),
('Tokelau'),
('Tonga'),
('Trinidad'),
('Tunisia'),
('Turkey'),
('Turkmenistan'),
('Turks'),
('Tuvalu'),
('Uganda'),
('Ukraine'),
('United Arab Emirates'),
('United Kingdom'),
('United States'),
('Uruguay'),
('Uzbekistan'),
('Vanuatu'),
('Venezuela'),
('Viet Nam'),
('Virgin Islands, British'),
('Virgin Islands, U.s.'),
('Wallis [and] Futuna'),
('Western Sahara'),
('Yemen'),
('Zambia'),
('Zimbabwe')
GO

INSERT INTO CLUBS (ClubName, City, Country)
VALUES
	('Fabric', 'London', 'United Kingdom'),
	('Berghain', 'Berlin', 'Germany'),
	('Paradise Club', 'New York', 'United States'),
	('Le Sacrè', 'Paris', 'France'),
	('Casablanca', 'Rio de Janeiro', 'Brazil');
GO

INSERT INTO MEMBERSHIP (Membership_ID, Price, MembershipName)
VALUES 
		(1, 500.00, 'Standard'),
		(2, 10000.00, 'VIP');
GO


CREATE TRIGGER LogTimeOfRegistration ON MEMBERS
AFTER INSERT
AS
	DECLARE @ID_Number int
	DECLARE @registrationDate datetime

	SELECT @ID_Number = ID_Number FROM INSERTED
	SELECT @registrationDate = CURRENT_TIMESTAMP

	INSERT INTO TIMELOG (ID_Number, RegistrationDate)
	VALUES (@ID_Number, @registrationDate)
GO


CREATE PROCEDURE uspRegisterClubEntry 
@id_Number int, @club_ID int
AS
INSERT INTO [ENTRY] (TimeOfEntry, ID_Number, Club_ID)
VALUES (GETDATE(), @id_Number, @club_ID)
GO


CREATE PROCEDURE uspRegisterMember
@firstName varchar (40), @lastName varchar (40), @orientation varchar(40), @sex varchar(40),
@id_Number int, @country varchar(40), @membership_ID int
AS
INSERT INTO [MEMBERS] (FirstName, LastName, Orientation, Sex, ID_Number, Country, Membership_ID)
VALUES (@firstName, @lastName, @orientation, @sex, @id_Number, @country, @membership_ID)
GO



CREATE PROCEDURE uspRegisterMembership
@membership_ID int, @price money, @membershipName varchar (18)
AS
INSERT INTO [MEMBERSHIP] (Membership_ID, Price, MembershipName)
VALUES (@membership_ID, @price, @membershipName)
GO



CREATE PROCEDURE uspDeleteMember
@id_Number int
AS
DELETE FROM [TIMELOG]
WHERE ID_Number = @id_Number
DELETE FROM [ENTRY]
WHERE ID_Number = @id_Number
DELETE FROM [MEMBERS]
WHERE ID_Number = @id_Number
GO


CREATE PROCEDURE uspCheckIfMemberIsRegistered
@id_Number int
AS
SELECT ID_Number FROM [MEMBERS]
WHERE ID_Number = @id_Number
GO


CREATE PROCEDURE uspGetMemberInfoList
@member_ID int
AS
SELECT FirstName, LastName, Orientation, Sex, Country, Membership_ID, ID_Number
FROM MEMBERS
WHERE ID_Number = @member_ID
GO

CREATE PROCEDURE uspGetClubInfo
@club_ID int
AS
SELECT Club_ID, ClubName, City, Country
FROM CLUBS
WHERE Club_ID = @club_ID
GO

CREATE PROCEDURE uspGetClubID
@clubName varchar(40)
AS
SELECT Club_ID
FROM CLUBS
WHERE ClubName = @clubName
GO

CREATE PROCEDURE uspCheckIfMemberIsVIP
@id_Number int
AS
SELECT Membership_ID FROM [MEMBERS]
WHERE ID_Number = @id_Number
GO


CREATE VIEW [dbo].[ClubEntry] AS 
SELECT ClubName, [ENTRY].TimeOfEntry
FROM CLUBS, [ENTRY]
WHERE CLUBS.Club_ID = [ENTRY].Club_ID
GO

SELECT *
FROM dbo.ClubEntry
ORDER BY ClubEntry.TimeOfEntry
GO

SELECT [ENTRY].TimeOfEntry
FROM [ENTRY]
WHERE ID_Number = 5 AND Club_ID = 2


SELECT [ENTRY].TimeOfEntry, CLUBS.ClubName
FROM [ENTRY] INNER JOIN CLUBS
ON [ENTRY].Club_ID = CLUBS.Club_ID
WHERE ID_Number = 5
ORDER BY ClubName ASC



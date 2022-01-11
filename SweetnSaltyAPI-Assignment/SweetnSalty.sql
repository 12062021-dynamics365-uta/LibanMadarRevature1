USE SweetnSalty;

CREATE TABLE Person(
	PersonId INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName nvarchar(30) NOT NULL,
	LastName nvarchar(30) NOT NULL
);
CREATE TABLE Flavor(
	FlavorId INT PRIMARY KEY IDENTITY NOT NULL,
	FlavorName nvarchar(30) NOT NULL
);

CREATE TABLE Person_Flavors(

	Person_FlavorID INT PRIMARY KEY NOT NULL,
);
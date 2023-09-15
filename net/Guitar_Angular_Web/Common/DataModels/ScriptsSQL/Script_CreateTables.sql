

CREATE TABLE Users (
	Id BIGINT identity(1,1) NOT NULL,
	GUID VARCHAR(255) NOT NULL,
	CreatedAt DATETIME NOT NULL,
	UserName VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	EmailAddress VARCHAR(255) NOT NULL,
	PhoneNumber VARCHAR(255) NOT NULL,
	UpdatedAt datetime NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE Guitars (
	Id BIGINT identity(1,1) NOT NULL,
	GUID VARCHAR(255) NOT NULL,
	CreatedAt DATETIME NOT NULL,
	Name VARCHAR(255) NOT NULL,
	Brand VARCHAR(255) NOT NULL,
	Description VARCHAR(255) NOT NULL,
	UpdatedAt datetime NOT NULL,
	Price DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (Id)
);

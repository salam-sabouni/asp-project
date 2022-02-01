use webbased
CREATE TABLE Shipments (
    Id int IDENTITY(1,1) PRIMARY KEY,
	TypeOfShipment nvarchar(64) NOT NULL,
	PackageWeight float(2) NOT NULL,
	PackageDx float(2) NOT NULL,
	PackageDy float(2) NOT NULL,
	PackageDz float(2) NOT NULL,
	Price	  float(2) NOT NULL,
	SenderFirstName nvarchar(64) NOT NULL,
    SenderLastName nvarchar(64) NOT NULL,
	SenderCity nvarchar(64) NOT NULL,
	RecieverFirstName nvarchar(64) NOT NULL,
    RecieverLastName nvarchar(64) NOT NULL, 
	RecieverCity nvarchar(64) NOT NULL,
	CurrentStatus nvarchar(64) NOT NULL,
	Sdate dateTIME NOT NULL,
	Rdate dateTIME 
);
CREATE TABLE Employee (
    Id int IDENTITY(1,1) PRIMARY KEY,
	LastName nvarchar(64) NOT NULL,
	FirstName nvarchar(64) NOT NULL,
	UserName nvarchar(64) NOT NULL,
	UserPassword nvarchar(64) NOT NULL,
	UserRole nvarchar(64) NOT NULL
);
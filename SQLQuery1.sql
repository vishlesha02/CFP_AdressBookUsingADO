CREATE DATABASE AddressBooK

use AddressBooK;

CREATE TABLE contacts(
ID int Identity(1,1),
FirstName varchar(50),
LastName varchar(50),
Email varchar(50),
PhoneNumber varchar(50),
City varchar(50),
SState varchar(50),
Zip varchar(50),
)

SELECT * From contacts
DELETE FROM contacts WHERE FirstName = NULL;

--DROP DATABASE AddressBook

ALTER TABLE contacts
ADD ID int Identity(1,1);

-----------------AddByStoreProcedure-----------------------

CREATE PROCEDURE AddContact
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@City VARCHAR(50),
	@SState VARCHAR(50),
	@Zip VARCHAR(50)

	AS
	BEGIN
		INSERT INTO Contacts VALUES(@FirstName,@LastName,@Email,@PhoneNumber,@City,@SState,@Zip) 
	END

	EXEC AddContact

	--------------------DisplayByStoreProcedure-------------
	CREATE PROCEDURE DisplayContact
		AS
		BEGIN
			SELECT * FROM contacts
		END

		EXEC DisplayContact
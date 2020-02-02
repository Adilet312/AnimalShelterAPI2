# Animal Shelter

###### By Adilet Momunaliev 02/01/2020  
#
## Description
_C#/.NET project. Includes full CRUD functionality and successful return responses to API calls._

## Setup/Installation Requirements

1.) Clone this repo:
```
$ git clone https://github.com/Adilet312/AnimalShelterAPI
```
2.) Navagate to root directory (AnimalShelterAPI)
```
$ cd AnimalShelterAPI
$ dotnet restore
$ dotnet build
```
## Checkout MySql Table Script

```
DROP DATABASE IF EXISTS animal_shelter_api;
CREATE DATABASE animal_shelter_api;
CREATE TABLE animal_shelter_api.Animals(
			AnimalId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
            AnimalName VARCHAR(255) NOT NULL,
            AnimalType VARCHAR(255) NOT NULL,
            ArrivalDate DATE NOT NULL
			
            
);
```

## Support and contact details
adiletm@hotmail.com


## Technologies Used
- C# 
- ASP.NET Core MVC
- MySQLite 
- Entity Framework Core
- Swagger
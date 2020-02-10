# Animal Shelter

###### By Adilet Momunaliev 02/01/2020  
#
## Description
_The program includes full CRUD functionality and successful returns responses to API calls.It gives Users functionalities to query animals by name, type,and arrivalDate.In addition, it was documented by using Swagger._

## Setup/Installation Requirements

1.) Clone this repo:
```
$ git clone https://github.com/Adilet312/AnimalShelterAPI2
```
2.) Navagate to root directory (AnimalShelterAPI)
```
$ cd AnimalShelterAPI
$ dotnet restore
$ dotnet build
```

3) Run and enter path to the Swagger in order to do queries
```
$ dotnet run and put URL into browser: localhost:5000/swagger
```
```
[GET ] Input: http://localhost:5000/api/Animals?name=Tom => 
Output:   
{
    "animalId": 1,
    "animalName": "Tom",
    "animalType": "Dog",
    "arrivalDate": "2019-12-10T00:00:00"
} 
```
```
[GET ]Input: http://localhost:5000/api/Animals?type=Dog =>
Output:
  {
    "animalId": 1,
    "animalName": "Tom",
    "animalType": "Dog",
    "arrivalDate": "2019-12-10T00:00:00"
  },
  {
    "animalId": 4,
    "animalName": "Jim",
    "animalType": "Dog",
    "arrivalDate": "2016-10-10T00:00:00"
  }
```
```
[GET ]Input: http://localhost:5000/api/Animals?arrivalDate=2016-10-10 =>
Output:
 {
    "animalId": 4,
    "animalName": "Jim",
    "animalType": "Dog",
    "arrivalDate": "2016-10-10T00:00:00"
 }
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
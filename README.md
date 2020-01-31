# _Anita Kemp's SW US National and State Parks API and MVC Application_

#### _As part of the week 13 code review for Epicodus, 11/1/19_

#### By _Anita Kemp_

## Description
_This API is a database of the state and national parks of the SW United States. Currently, the API contains a list of the national parks (and some of the state parks) for New Mexico and Colorado. With the MVC application, the user will be able to see the list of current parks and their details._

## Setup/Installation Requirements

#### To use the MVC application:
* _Clone this repository_
* _Navigate to the "Parks" directory, and run: "dotnet ef database update" in order to update the database in MySQL_
* _Then run the command: "dotnet run"_
* _In a separate terminal, navigate to the ParksClient directory
* _Run the command: "dotnet run"_
* _Navigate to localhost:5004_

### API Endpoint: localhost:5000/api/ParksApi 

* _To make specific requests, one can use Postman or another service and enter: localhost:5000/api/ParksApi?{*then choose from*: parkId, name, land, state}={your search query}_


### API Response Examples: 

* _Or, you can navigate to localhost:5000/swagger in order to see all functionality for this API_

## Support and contact details

_Please leave a comment on this repository if there are any questions._

## Technologies Used

_C#, .NET, MVC, MySQL, Entity, Swagger_

### License

*MIT*

Copyright (c) 2019 **_Anita Kemp_**

# Animal Shelter API

#### An basic API for an animal shelter that can be used to list avaiable cats and dogs at the shelter available for adoption. 

#### **By Shane Graff**

#### Table of Contents

1. [Technologies Used](#technologies)
2. [Setup/Installation Requirements](#setup)
3. [Api Info/Endpoinst](#api)
4. [Known Bugs](#bugs)
5. [License](#license)
6. [Contact Information](#contact)

## Technologies Used <a id="technologies"></a>

* C#
* ASP.Net Core
* ASP.NET MVC
* [Entity Framework](https://docs.microsoft.com/en-us/aspnet/entity-framework)
* MySql Database
* Dotnet-ef
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0&viewFallbackFrom=aspnetcore-50) 

## Setup/Installation Requirements <a id="setup"></a>

1. If you don't already have C# and .NET installed on your computer, you can get the Software Develment Kit or SDK for Mac here: [Dot.Net for Mac](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer) and for Windows here: [Dot.Net for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0). Follow the instructions detailed in both links above for set up.
2. If not already installed, download: [MySql Community](https://dev.mysql.com/downloads/mysql/)
3. If not already installed, download: [MySql Workbench](https://www.mysql.com/products/workbench/)
4. Follow the instruction [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql) for configuring MySql. 
5. Open the terminal on your local machine and navigate to where you want to clone the project
6. Run the following command: git clone https://github.com/ShanGGraff/AnimalShelter.Solution.
7. 
8. Navigate to the ```AnimalShelter/``` directory and create a file named: ```appsettings.json```. In this file, add the folling configuration to be able to create the table used by the application: 
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
9. If you don't already of migragtions installed for creating the table, add the package with the following:  ```dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0``` on the command line in the AnimalShelter main directory. 
10. In the SweetAndSavory main directory run ```dotnet build``` on the command line to check for errors
11. Next run ```dotnet ef migrations add Initial```. Note when making changes to the schema (i.e. making changes in the models that affect the database such as adding a new attribute, you would change "Initial" to something more descriptive of what change you are making to the table.
12. Nex run ```dotnet ef database update``` to update the table/s. I've included values in the AnimalShelterContext.cs to seed the database with some animal entries for testing.
13. Run ```dotnet build``` again to make sure there are no errors.
14. If everything builds correctly, run ```dotnet run``` on the command line to start the AnimalShelter API.

## Api Endpoints/Documentation <a id="api"></a>
* Once the API is running, you can test the API endpoints on the index page: https://localhost:5001/index.html using Swagger.

The API enpoints are the following:
```
GET /api/Animals (returns a list of the animals at the shelter)
POST /api/Animals (allows user to add new animal to the database)
GET /api/Animals/{id} (list an animal by a specific id)
PUT /api/Animals/{id} (change information about a specific animal)
DELETE /api/Animals/{id} (delete a specific animal by id)
```

Here is an example of available user queries:

* A basic list of all the animals at the shelter:

```
https://localhost:5001/api/Animals/
```
* Listing an animal by id:

```
http://localhost:5000/api/Animals/2
```
* Searching by multiple attributes

```
http://localhost:5000/api/animals/?species=cat&gender=female&age=1
```

## Known Bugs <a id="bugs"></a>
* No known

## License
* [MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2021 Creators 

## Contact Information <a id="contact"></a>

* Shane Graff <copellius@gmail.com>
* Github page: [ShanGGraff](https://github.com/ShanGGraff)
* LinkedIn: [Shane Graff](https://www.linkedin.com/in/shanegraff)


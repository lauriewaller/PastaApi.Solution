# Pasta Application

#### A RESTful API using full CRUD functionality. Provides data for types of pasta and their origin location. 

#### By **Laurie Waller**

## Technologies Used

* C#
* ASP.NET Core MVC
* Entity Framework Core
* .NET 5.0
* MySQL 
* MySQL Workbench

## Description
This API follows RESTful principles and provides create, read, update, and delete functionality. Developers can filter GET requests using Origin and SauceType parameters. This API is a practice application written for homework exercises for Epicodus coding school. To view the UI for this API, see the [PastaClient.Solution repo](https://github.com/lauriewaller/PastaClient.Solution). 

## Prerequisites

* [.Net Framework](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484914)
* [MySQL WorkBench](https://dev.mysql.com/downloads/file/?id=484391)
* dotnet script 
  `dotnet tool install -g dotnet-script`
* Entity Framework Core
  `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  `dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0`

## Setup/Installation Requirements

  1. Go to the main page of the repository (https://github.com/lauriewaller/PastaApi.Solution).
  2. In the top righthand corner of the list of files, click the Code dropdown menu.
  3. Click on the clipboard icon to copy the URL to the GitHub repo.
  4. On your computer, open Terminal and navigate to the folder where you plan to clone the repo folder.
  5. Type in `git clone` and then paste the URL you copied: `git clone https://github.com/lauriewaller/PastaApi.Solution`. Press Enter.
  6. To open your files in [Visual Studio Code](https://code.visualstudio.com/),
  navigate to Parks.Solution in Terminal, type `code .`, and press Enter. This will open the application files in VS Code.
  7. In the Parks directory, create the file `appsettings.json`. Add the following code and save the file:

    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=laurie_waller;uid={INSERT_USERNAME};pwd={INSERT_PASSWORD};"
      }
    }
  
  8. Still in the Parks directory, type in `dotnet restore` and `dotnet build` to restore dependencies and compile code.
  9. To set up the migration, and run the following commands in the Parks directory:
  
  * `dotnet tool install --global dotnet-ef`
  * `dotnet ef database update` (applies the migration in Workbench)
 
  10. In the Parks directory, type in `dotnet run` to run the program. 


## Known Bugs

* No known errors

## License

MIT

Copyright (c) 2021 by Laurie Waller

## Contact Information

_Laurie Waller (lauriewaller7@gmail.com)_

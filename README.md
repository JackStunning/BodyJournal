# BodyJournal

#### Personalized Fitness 04/06/2020

#### By Andrew Philott

## Description

An API that allows users to GET and POST reviews about various state and national parks

## Specs

### Installation and Configuration:

- Download .NET application version 3.1
- Download MySql version 8.15
- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the BodyJournalAPI directory, within BodyJournal.Solution
- \$dotnet restore
- \$dotnet ef migrations add Initial
- \$dotnet ef database update
- \$dotnet watch run
- Open seperate terminal
- Change directory to the BodyJournalClient directory, within BodyJournal.Solution
- \$dotnet restore
- \$dotnet watch run
- Call the api using Postman or by running the web application

<details>
  <summary>Click to expand!</summary>
API
| HTTP Method | URL Path | Purpose |
| :--------- | :------- | :------- |

| GET | /exercises | Retrieve all exercises |

| GET | /exercise/{id} | Retrieve an exercise by it's id |

| GET | /exercise/{name} | Retrieve a list of exercises by name |

</details>

## Known Bugs

No bugs

## Support and contact details

For feedback, questions and/or ideas, please email <andrewphilpott92@gmail.com>

## Technologies Used

- .NET Core
- C#
- ASP.NET Core MVC
- Entity Framework
- MySQL Workbench
- CSS
- HTML

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **Andrew Philott**

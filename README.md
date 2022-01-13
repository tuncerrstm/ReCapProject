# ReCapProject - Backend

## C# ( .Net Core ) Car Rental Project

<br />
<p align="center">
  <a href="https://github.com/tuncerrstm/ReCapProject">
    <img width=220 src="https://i.imgur.com/XeaXr9l.gif" alt="ReCap Project">
  </a>
  <h2 align="center">ReCapProject - Backend Project</h2>
  <p align="center">
    Car Rental project with N-Layer Architecture.
    <br />
    <br />
  </p>
</p>


## Hi there, I'm Tundzher. :blush:

### | Software Engineer | 
#### | C#, Java, React Developer |

<font color="red"> Coffee is how I keep up with! `<code />` </font>


### Reach out to me!!

[<img width="22" src="https://unpkg.com/simple-icons@v4/icons/twitter.svg" align="left" />][twitter]
[<img width="22" src="https://unpkg.com/simple-icons@v4/icons/linkedin.svg" align="left" />][linkedin]
[<img width="22" src="https://unpkg.com/simple-icons@v4/icons/instagram.svg" align="left" />][instagram]


<br/>
<br/>

### Tech I Use

<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/csharp/csharp.png" width="25" height="25" /><img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/react/react.png" width="25" height="25" />
<img src="https://camo.githubusercontent.com/2be6c13639334e6be86614b7914afe1c34e76d49f361d515bac94bd7e21e2b49/68747470733a2f2f696d616765732e766578656c732e636f6d2f6d656469612f75736572732f332f3136363430312f69736f6c617465642f707265766965772f62383261613761633366373336646437383537306464336661336661396532342d6a6176612d70726f6772616d6d696e672d6c616e67756167652d69636f6e2d62792d766578656c732e706e67" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/javascript/javascript.png" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/python/python.png" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/css/css.png" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/git/git.png" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/html/html.png" width="25" height="25" />
<img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/typescript/typescript.png" width="25" height="25" />



<br />

<details>
<summary>:bulb: Github Stats</summary>
<img src="https://github-readme-stats.vercel.app/api?username=tuncerrstm&theme=radical" >
</details>
<details>
<summary>:bulb: Most Used Languages</summary>
<img src="https://github-readme-stats.vercel.app/api/top-langs/?username=tuncerrstm&layout=compact" >
</details>
<summary>:bulb: Most Used Languages</summary>
<img src="https://github-readme-stats.vercel.app/api/top-langs/?username=enescerrahoglu&langs_count=8" >
</details>

[twitter]: https://twitter.com/tuncerRstm
[linkedin]: https://www.linkedin.com/in/tuncer-r%C3%BCstemo%C4%9Flu-74917b187/
[instagram]:https://www.instagram.com/toniochmuzi/

<img src="https://media.giphy.com/media/l0M82b7IOZIgunA5Rc/giphy.gif" align ="left" width="310" height="310">

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



# About The Project

## Built With

[![C-Sharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Asp-net](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![MSSQL](https://img.shields.io/badge/MSSQL-004880?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=2)
[![Entity-Framework](https://img.shields.io/badge/Entity%20Framework-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![Autofac](https://img.shields.io/badge/Autofac-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://autofac.org/)
[![Fluent-Validation](https://img.shields.io/badge/Fluent%20Validation-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://fluentvalidation.net/)

## Specifications

<details>
  <summary>Toggle Content</summary>

### Cars

#### Public Operations

- Get all cars
  - Searching Cars By Brand, Color
  - Caching
- Get a single car
  - Caching

#### Private Operations

- Add a New Car
  - Authorized users only
  - Field validation
- Edit a Car
  - Authorized users only
  - Field Validation
- Delete a Car
  - Authorized users only

### Car Images

#### Public Operations

- Get a car image
  - Caching
- Get all
  - Searching Car Image By Car
  - Caching

#### Private Operations

- Add (Upload) a New Car Image
  - Authorized users only
  - Save on Disk
- Edit a Car Image
  - Authorized users only
  - Edit on Disk
- Delete a Car Image
  - Authorized users only
  - Delete on Disk

### Brands

#### Public Operations

- Get all brands
- Get a brand

#### Private Operations

- Add a Brand
  - Authorized users only
- Edit a Brand
  - Authorized users only
- Delete a Brand
  - Authorized users only

### Color

#### Public Operations

- Get All Colors
- Get Single Color

#### Private Operations

- Add a Color
  - Authorized users only
- Edit a Color
  - Authorized users only
- Delete a Color
  - Authorized users only

### Customer

#### Public Operations

- Add a Customer

#### Private Operations

- Get All Customers
  - Authorized users only
- Get Single Customer
  - Authorized users only
- Edit a Customer
  - Authorized users only
- Delete a Customer
  - Authorized users only

### Rental

#### Public Operations

- Get All Rentals
  - Searching Rental By Car
  - Logged users only
- Get Single Rental
  - Logged users only
- Add a Rental
  - Logged users only
- Check Car is Rentable
- Check Findeks Score Sufficiency

#### Private Operations

- Edit a Rental
  - Authorized users only
- Delete a Rental
  - Authorized users only

### Users

#### Public Operations

- Get User Detail By Mail
- Add a User
- Update User Details
  - Logged users only

#### Private Operations

- Get a User
  - Searching user by mail
  - Authorized users only
- Get all Users
  - Authorized users only
- Edit a User
  - Authorized users only
- Delete a User
  - Authorized users only

### Authentication

Requests are authenticated using the `Authorization` header and value `Bearer {{token}}`. with a valid JWT.

- Authentication Strategy : JWT
  - JWT Expiration : 10 Minutes For Testing Api
- Registration
  - User can register as a "Admin" or simply "User"
  - Password Salt
  - Password Hash
  - Token includes : "id", "email", "name" and "roles"
  <!-- - Token Are Stored In Cookie -->
- Login
  - User can login with "email" and "password"
  - Everytime a user login, new Token are sent to to client

#### Public Operations

- Login
  - Logged users only
  - Create Access Token
- Register new user
  - Create Access Token
- Check User Exists
- Check user is authenticated
  - Logged users only

#### Private Operations

- Encryption
- Hashing
- JWT

### Operation Claim

#### Public Operations

- Get a Operation Claim
  - Searching Operation Claim by name
- Get all Operation Claim

#### Private Operations

- Add a Operation Claim
  - Authorized users only
- Edit a Operation Claim
  - Authorized users only
- Delete a Operation Claim
  - Authorized users only

### User Operation Claim

#### Public Operations

- Add 'User' Claim

#### Private Operations

- Get a User Operation Claim
  - Authorized users only
- Get all User Operation Claim
  - Authorized users only
- Add a User Operation Claim
  - Authorized users only
- Edit a User Operation Claim
  - Authorized users only
- Delete a User Operation Claim
  - Authorized users only

### Credit Card (Test)

#### Public Operations

- Get a Credit Card
  - Logged users only
- Get all Users
  - Logged users only
  - Searching Credit Card by Customer
- Add a Credit Card
  - Logged users only
- Delete User Details
  - Logged users only

### Payment (Test)

#### Public Operations

- Payment (Fake)

### Findeks (Test)

#### Public Operations

- Searching Findeks by Customer
  - Logged users only
- Add a Findeks
  - Logged users only
- Update a Findeks
  - Logged users only
- Calculate Findeks Score (Fake)

#### Private Operations

- Get a Findeks
  - Authorized users only
- Get all
  - Authorized users only
- Update findeks
  - Authorized users only
- Delete findeks
  - Authorized users only

</details><p></p>

## Layers

<details>
  <summary>Toggle Content</summary>

### Business

Business Layer created to process or control the incoming information according to the required conditions.

### Core

Core layer containing various particles independent of the project.

### DataAccess

Data Access Layer created to perform database CRUD operations.

### Entities

Entities Layer created for database tables.

### WebAPI

Web API Layer that opens the business layer to the internet.

</details><p></p>

## Models

<details>
  <summary>Toggle Content</summary>

### Brands

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

### Car Images

| Name      | Data Type     | Allow Nulls | Default |
| :-------- | :------------ | :---------- | :------ |
| Id        | int           | False       |         |
| CarId     | int           | False       |         |
| ImagePath | nvarchar(MAX) | False       |         |
| Date      | datetime      | False       |         |

### Car

| Name            | Data Type     | Allow Nulls | Default |
| :-------------- | :------------ | :---------- | :------ |
| Id              | int           | False       |         |
| Name            | nvarchar(50)  | False       |         |
| BrandId         | int           | False       |         |
| ColorId         | int           | False       |         |
| DailyPrice      | decimal(18,0) | False       |         |
| ModelYear       | smallint      | False       |         |
| Description     | nvarchar(50)  | True        |         |
| MinFindeksScore | smallint      | False       | ((0))   |

### Color

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | nvarchar(25) | False       |         |

### Credit Card (Test)

| Name        | Data Type     | Allow Nulls | Default |
| :---------- | :------------ | :---------- | :------ |
| Id          | int           | False       |         |
| CustomerId  | int           | False       |         |
| NameSurname | nvarchar(100) | False       |         |
| CardNumber  | nvarchar(25)  | False       |         |
| ExpMonth    | tinyint       | False       |         |
| ExpYear     | tinyint       | False       |         |
| Cvc         | nvarchar(3)   | False       |         |
| CardType    | nvarchar(20)  | False       |         |

### Customer

| Name        | Data Type    | Allow Nulls | Default |
| :---------- | :----------- | :---------- | :------ |
| Id          | int          | False       |         |
| UserId      | int          | False       |         |
| CompanyName | nvarchar(50) | True        |         |

### Findeks (Test)

| Name             | Data Type    | Allow Nulls | Default |
| :--------------- | :----------- | :---------- | :------ |
| Id               | int          | False       |         |
| CustomerId       | int          | False       |         |
| NationalIdentity | nvarchar(50) | False       |         |
| Score            | smallint     | False       | ((0))   |

### OperationClaims

| Name | Data Type    | Allow Nulls | Default |
| :--- | :----------- | :---------- | :------ |
| Id   | int          | False       |         |
| Name | varchar(250) | False       |         |

### Rental

| Name          | Data Type | Allow Nulls | Default |
| :------------ | :-------- | :---------- | :------ |
| Id            | int       | False       |         |
| CarId         | int       | False       |         |
| CustomerId    | int       | False       |         |
| RentStartDate | datetime  | False       |         |
| RentEndDate   | datetime  | False       |         |
| ReturnDate    | datetime  | True        |         |

### UserOperationClaims

| Name             | Data Type | Allow Nulls | Default |
| :--------------- | :-------- | :---------- | :------ |
| Id               | int       | False       |         |
| UserId           | int       | False       |         |
| OperationClaimId | int       | False       |         |

### Users

| Name         | Data Type      | Allow Nulls | Default |
| :----------- | :------------- | :---------- | :------ |
| Id           | int            | False       |         |
| FirstName    | nvarchar(50)   | False       |         |
| LastName     | nvarchar(50)   | False       |         |
| Email        | nvarchar(50)   | False       |         |
| PasswordHash | varbinary(500) | False       |         |
| PasswordSalt | varbinary(500) | False       |         |
| Status       | bit            | False       |         |

</details><p></p>

# Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

# License

Distributed under the MIT License. See `LICENSE` for more information.

# Contact

Tundzher Tunay RYUSTEM - [Linkedin](https://www.linkedin.com/in/tuncer-r%C3%BCstemo%C4%9Flu-74917b187//)

Project Link: [https://github.com/tuncerrstm/ReCapProject](https://github.com/tuncerrstm/ReCapProject)

# Acknowledgements

- [engindemirog](https://www.linkedin.com/in/engindemirog/)

[contributors-shield]: https://img.shields.io/github/contributors/maziz-create/ReCapProject-Backend.svg?style=for-the-badge
[contributors-url]: https://github.com/maziz-create/ReCapProject-Backend/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/maziz-create/ReCapProject-Backend.svg?style=for-the-badge
[forks-url]: https://github.com/maziz-create/ReCapProject-Backend/network/members
[stars-shield]: https://img.shields.io/github/stars/maziz-create/ReCapProject-Backend.svg?style=for-the-badge
[stars-url]: https://github.com/maziz-create/ReCapProject-Backend/stargazers
[issues-shield]: https://img.shields.io/github/issues/maziz-create/ReCapProject-Backend.svg?style=for-the-badge
[issues-url]: https://github.com/maziz-create/ReCapProject-Backend/issues
[linkedin-shield]: https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white
[linkedin-url]: https://linkedin.com/in/maziz-create

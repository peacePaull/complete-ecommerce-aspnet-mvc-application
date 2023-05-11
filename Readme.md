﻿# PPA-Cinemas Ecommerce web application

The primary objective of this project is to enhance coding skills and gain a comprehensive understanding of the complete end-to-end implementation of an ASP.NET MVC Core web application using .NET 6. The focus is on developing a robust e-commerce solution with seamless online payment checkout functionality. The application encompasses separate menus for both administrators and customers. For data storage, a SQL database is employed, and Entity Framework facilitates efficient data interaction. Additionally, the project involves learning how to utilize Entity Framework migrations to update the database schema, perform CRUD operations (Create, Read, Update, Delete) such as adding, retrieving, updating, and deleting data.


### Technologies Involved
language : C# .NET Framework, NUnit Framework
IDE      : Visual Studio 2022

# How it works ?
The application is designed in very extensible way.
Currently the application has only management layer, which consist of four differnt endpoints.

### 1. Actors
    * Can create Actor profile.
    * Can view Actor profile.
    * Can update Actor profile.
    * Can delete Actor profile.
    
### Class Diagram of Actor  (initial design)
![Class diagram](https://user-images.githubusercontent.com/67691782/236080347-ef365929-b845-4fc4-987c-5f490a694f54.jpg)
![Actors page](https://user-images.githubusercontent.com/67691782/236079589-deaba4ca-a599-4d18-bdcf-d43cbba3ef35.jpg)

Details of Actor profile.
![Details page](https://user-images.githubusercontent.com/67691782/236079737-22a01c09-5798-4681-b9e9-e89e1488bde3.jpg)


### 2. Producers
    * Can create Producer profile.
    * Can view Producer profile.
    * Can update Producer profile.
    * Can delete Producer profile.
![Producers page](https://user-images.githubusercontent.com/67691782/236079609-e3cf6afb-fbd4-4659-85d5-28a16d30e942.jpg)


### 3. Cinemas
    * Can add Cinema theaters.
    * Can view, update and delete.

![Cinemas page](https://user-images.githubusercontent.com/67691782/236079621-df2e59a2-4554-4728-b0da-073fad2b5e50.jpg)

### 4. Movies(Home)
    * Can add Movies.
    * Can view list of movies.
    * Can delete Movies.
    * Can update Movies.

![Home page](https://user-images.githubusercontent.com/67691782/236079631-43320d67-7db9-4811-9fc7-66b054f690f1.jpg)


## Upcomming Enhancements
1. Add functionality for Movies ticket booking.
2. Online payment integration.
3. Azure cloud deployment.

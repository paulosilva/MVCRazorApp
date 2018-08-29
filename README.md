# MVCRazorApp
Developing an ASP .NET MVC 5.2 web application that uses MySQL and Entity Framework on macOS

# 7Up the project

## 1º Create the mono_app database on MySQl Server

```
--
-- mono_app
--
CREATE USER 'mono_app'@'localhost' IDENTIFIED BY 'mono_app!2015';
CREATE USER 'mono_app'@'127.0.0.1' IDENTIFIED BY 'mono_app!2015';
CREATE USER 'mono_app'@'%' IDENTIFIED BY 'mono_app!2015';

CREATE DATABASE `mono_app` CHARACTER SET utf8;

GRANT ALL PRIVILEGES ON `mono_app`.* TO 'mono_app'@'localhost';
GRANT ALL PRIVILEGES ON `mono_app`.* TO 'mono_app'@'127.0.0.1';
GRANT ALL PRIVILEGES ON `mono_app`.* TO 'mono_app'@'%';

```

## 2º Create the database movies table, using the sql code in the script file: 
- mono_app.sql

## 3º Build and run the dotnet MVCRazorApp project
- See it in action on [youtube](https://youtu.be/kfMK62o3Fbw)


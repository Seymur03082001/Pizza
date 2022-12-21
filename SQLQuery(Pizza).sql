CREATE DATABASE PIZZA
USE PIZZA

CREATE TABLE Pizzas
(
ID int identity primary key,
Name nvarchar(25) unique not null,
Img varchar(150) unique
)
CREATE TABLE Sizes
(
ID int identity primary key,
Name nvarchar(25) unique not null
)
CREATE TABLE Ingredients
(
ID int identity primary key,
Name nvarchar(25) unique not null
)
CREATE TABLE Buskets
(
ID int identity primary key,
TotalPrice decimal(6,2) not null
)
CREATE TABLE PizzaSizes
(
ID int identity primary key,
SizeID int REFERENCES Sizes(ID),
PizzaID int REFERENCES Pizzas(ID),
Price decimal (6,2) not null
)
CREATE TABLE PizzaIngredients
(
ID int identity primary key,
IngredientID int REFERENCES Ingredients(ID),
PizzaID int REFERENCES Pizzas(ID)
)
CREATE TABLE BusketItem
(
ID int identity primary key,
Count int,
PizzaID int REFERENCES Pizzas(ID),
BusketID int REFERENCES Buskets(ID)
)
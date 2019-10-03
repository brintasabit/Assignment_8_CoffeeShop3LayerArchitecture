create database CoffeeShop
create table Customers (ID int identity (1,1),Name varchar(20),Contact varchar(20),Address varchar(20),Item varchar(20),Quantity int,Price float)
create table Items (ID int identity(1,1),Name varchar(30),Price float)
insert into Customers (Name,Contact,Address,Item,Quantity) values ('Bob','01750810474','LA','Hot',3)
insert into Items values('Hot',120)
select * from Customers
select * from Items
select * from Orders

update Customer set Name='Dev',Contact='0934',Address='CA',Item='Cold',Quantity=4 where ID=7
drop table Customer
drop table Item
drop table Orders
update Item set Name='Alu',Price=25 where ID=5
select * from Item where Name='Onion'
create table Orders (ID int Identity(1,1),Name varchar(30),Item varchar(30),Quantity int,Total_Price float)
select * from OrderItem
select Name from Item where Name='Hot'


















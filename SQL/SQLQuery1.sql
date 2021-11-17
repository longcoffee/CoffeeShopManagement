create database CoffeeShop
go

use CoffeeShop
go
/*
Note: By LongCoffee
1. In order to avoid errors in updating data, please delete all and reconnect the database.
2. Due to the complicated update process, users only update the data when they are sure that the correct edits are made.
*/

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

create table TableTest
(
	id int identity primary key,
	name nvarchar (100) not null default N'Chưa đặt tên',
	status nvarchar (100) not null default N'Trống' -- emty or sloted
);
go

create table Account
(
	-- id int identity primary key, placed at UserName
	UserName nvarchar (100)not null primary key,
	DisplayName nvarchar (100) not null default N'Nam Long',
	PassWord nvarchar (1000)not null default 0,
	Type int not null default 0 -- 1 is admin & 0 is staff
);
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar (100) not null default N'Chưa đặt tên'
);
go

create table Food
(
	id int identity primary  key,
	name nvarchar (100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0
	foreign key (idCategory) references dbo.FoodCategory(id)
);
go

create table Bill
(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date ,
	idTable int not null,
	status int not null -- pay or not yet
	foreign key (idTable) references dbo.TableTest(id)
);
go

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
);
go

-- Add & get Account
/*
--UserName - nvarchar(100)
--DisplayName - nvarchar(100)
--PassWord - nvarchar(1000)
--Type - int
*/
INSERT INTO dbo.Account ( UserName , DisplayName , PassWord , Type )
VALUES					( N'adminlong' , N'NamLong' , N'4444' , 1 )
INSERT INTO dbo.Account ( UserName , DisplayName , PassWord , Type )
VALUES					( N'stafflong' , N'Long' , N'1' , 0 )
GO
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
EXEC dbo.USP_GetAccountByUserName @userName = N'adminlong' -- nvarchar(100)
GO
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

-- Add & get Table (TableTest)
/*
SET IDENTITY_INSERT [dbo].[TableTest] ON
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (1,  N'Bàn 00', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (2,  N'Bàn 01', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (3,  N'Bàn 02', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (4,  N'Bàn 03', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (5,  N'Bàn 04', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (6,  N'Bàn 05', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (7,  N'Bàn 06', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (8,  N'Bàn 07', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (9,  N'Bàn 08', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (10, N'Bàn 09', N'Trống')
INSERT [dbo].[TableTest] ([id], [name], [status]) VALUES (11, N'Bàn 10', N'Trống')
SET IDENTITY_INSERT [dbo].[TableTest] OFF
*/
DECLARE @i INT = 1
WHILE @i <= 44
BEGIN
	INSERT dbo.TableTest (name, status) VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)), N'Trống' )
	SET @i = @i + 1
END
GO
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableTest
GO
EXEC dbo.USP_GetTableList
GO

-- Add & get Category
/*
--name - nvarchar(100)
*/
INSERT dbo.FoodCategory ( name ) VALUES ( N'Cà phê truyền thống - Vietnamese Coffee' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Cà phê pha máy - Italy Coffee' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Trà - Tea' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Sữa - Milk' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Đá xay - Iceblended')
INSERT dbo.FoodCategory ( name ) VALUES ( N'Nước ép - Juice' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Sinh tố - Smoothies' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Soda & Mojito' )
INSERT dbo.FoodCategory ( name ) VALUES ( N'Thức ăn nhẹ - Food' )
GO

-- Add & Food
/*
--name - nvarchar(100)
--idCategory - int
--price - float
*/
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê đen - Black Coffee' , 1 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê nâu - Brown Coffee', 1 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê sữa - Milk Coffee', 1 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê trứng - Egg Coffee', 1 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê cốt dừa - Coconut Coffee', 1 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Bạc sỉu - White Coffee', 1 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Americano ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Arabica ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cappuccino ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Flat white ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Expresso ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Latte', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mocha', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Robusta  ', 2 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà xanh - Green Tea ', 3 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà đen - Black Tea ', 3 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà lá - Loose Leaf Tea  ', 3 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà không xay - Decaf Tea  ', 3 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà chanh - Lemon Tea  ', 3 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà trái cây - Fruit Tea  ', 3 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà bạc hà - Peppermin Tea  ', 3 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà quế - Cinnamon Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà thảo mộc - Herbal Tea ', 3 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà hoa cúc - Daisy Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà hoa hồng - Rose Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà hoa lài - Jasmine tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà hoa đậu biếc - Butterfly Pea Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà A-ti-sô - Artiso Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà oải hương - Lavender Tea  ', 3 , 22000 ) 
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà dâm bụt - Hibiscus Tea  ', 3 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà thải độc - Detox Tea  ', 3 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà giảm cân - Skinny Tea  ', 3 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà an thần - Sleepy Time Tea  ', 3 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Hồng trà sữa ', 4 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Lục trà sữa ', 4 , 22000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà sữa Olong', 4 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà sữa Matcha', 4 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà sữa Matcha đậu đỏ', 4 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà sữa Truyền thống ', 4 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Trà sữa Đặc biệt ', 4 , 35000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sữa nóng ', 4 , 18000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sữa tươi trân châu đường đen ', 4 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Cà phê Đá xay - Frappuccino Iceblended ', 5 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Bích quy Đá xay - Cookies & Cream Iceblended ', 5 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Matcha Đá xay - Matcha Freeze Iceblended ', 5 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sô-cô-la Đá xay - Chocolate Freeze Iceblended ', 5 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sữa chua đá xay - Yogurt Iceblended ', 5 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước ép Cam - Orange ', 6 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước ép Cà rốt - Carrot ', 6 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước ép Chanh dây  ', 6 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước ép Dưa hấu -Water Melon ', 6 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước ép Dứa - Pineapple ', 6 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước Dừa - Coconut ', 6 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Nước Chanh - Lemonade ', 6 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sinh tố Bơ - Avocado Smoothy', 7 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sinh tố Dừa - Coconut Smoothy', 7 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sinh tố Một loại - Single Smoothy', 7 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Sinh tố Hai loại - Mix Smoothy', 7 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Xanh - Blue ', 8 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Đỏ -  Blue ', 8 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Bạc hà - Mint ', 8 , 36000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Chanh - Lemon ', 8 , 36000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Chanh dây ', 8 , 36000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Việt quất ', 8 , 36000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Dâu tây - Stawberry ', 8 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Bưởi - Grapefruit ', 8 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mojito Vải - ', 8 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Hạt dưa  ', 9 , 15000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Hạt hướng dương  ', 9, 15000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Hạt bí  ', 9 , 15000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mứt nho  ', 9 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mứt vỏ quýt  ', 9 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mứt gừng  ', 9 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mứt dừa  ', 9 , 20000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Bánh vòng - Donut  ', 9 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Bánh sừng bò  ', 9 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Bánh su kem  ', 9 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Táo  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Xoài  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Dâu tây  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Chanh dây  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Việt quất  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Sô-cô-la trắng  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Bạc hà  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Mousse Hoa đậu biếc  ', 9 , 39000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Tiramisu  ', 9 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Khô bò  ', 9 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Khô gà  ', 9 , 25000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Da heo cháy tỏi  ', 9 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Rong biển cháy tỏi cháy tỏi  ', 9 , 30000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Snack Khoai tây ống Lays ', 9 , 45000 )
INSERT dbo.Food ( name , idCategory , price ) VALUES  ( N'Snack Khoai tây gói Lays', 9 , 25000 )
GO

-- Add Bill
/*
-- DateCheckIn - date
-- DateCheckOut - date
-- idTable - int
-- status - int
*/
INSERT	dbo.Bill ( DateCheckIn , DateCheckOut , idTable , status ) VALUES  ( GETDATE() , null , 3 , 0 )
INSERT	dbo.Bill ( DateCheckIn , DateCheckOut , idTable , status ) VALUES  ( GETDATE() , null , 4 , 0 )
INSERT	dbo.Bill ( DateCheckIn , DateCheckOut , idTable , status ) VALUES  ( GETDATE() , GETDATE() , 5 , 1 )
INSERT	dbo.Bill ( DateCheckIn , DateCheckOut , idTable , status ) VALUES  ( GETDATE() , GETDATE() , 6 , 1 )
GO

-- Add BillInfo
/*
-- idBill - int
-- idFood - int
-- count - int
*/
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 1 , 1 , 2 )
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 1 , 3 , 4 )
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 1 , 5 , 1 )
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 2 , 1 , 2 )
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 2 , 6 , 2 )
INSERT	dbo.BillInfo ( idBill , idFood , count ) VALUES ( 3 , 5 , 2 )         
GO

SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 3

SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory
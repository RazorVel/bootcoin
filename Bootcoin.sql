IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'bootcoin')
  BEGIN 
	create database bootcoin
  end

go

use bootcoin

go

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='user' and xtype='U')
begin
	create table [user] (
		id int identity(1, 1) primary key,
		name varchar(255) default 'Agent',
		email varchar(255) not null,
		password varchar(255) not null,
		role varchar(255) default 'participant',
		balance int default 0
	)
end

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='profile' and xtype='U')
begin
	create table profile (
		userId int primary key,
		foreign key (userId) references [user](id),

		department varchar(255),
		avatar varbinary(max),
		mbti varchar(255),
		zodiac varchar(255),
		favoriteFood varchar(255),
		funFact varchar(255)
	)
end

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='transactionHeader' and xtype='U')
begin
	create table transactionHeader (
		id int identity(1,1) primary key,
		data date,
		type varchar(255)
	)
end 

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='transactionDetail' and xtype='U')
begin
	create table transactionDetail (
		transactionId int primary key,
		foreign key (transactionId) references transactionHeader(id),
    
		amount int,
		balanceAfter int
	)
end
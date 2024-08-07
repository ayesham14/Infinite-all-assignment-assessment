CREATE DATABASE railwayDB;

USE railwayDB;

	CREATE TABLE Train 
	(
		tno INT PRIMARY KEY,
		tname VARCHAR(100),
		[from] VARCHAR(100),
		dest VARCHAR(100),
		price DECIMAL(10, 2),
		class_of_travel VARCHAR(50),
		train_status VARCHAR(10),
		seats_available INT
	)

	CREATE TABLE Users 
	 (
		userId INT PRIMARY KEY IDENTITY(1,1),
		username VARCHAR(100) UNIQUE,
		password VARCHAR(100),
		role VARCHAR(10) -- either 'admin' or 'user'
	 )



	CREATE TABLE Bookings 
	(
		bookingId INT PRIMARY KEY IDENTITY(1,1),
		userId INT,
		tno INT,
		seats_booked INT,
		booking_date DATETIME,
		FOREIGN KEY (userId) REFERENCES Users(userId),
		FOREIGN KEY (tno) REFERENCES Train(tno)
	)

	CREATE TABLE Cancellations 
	(
		cancellationId INT PRIMARY KEY IDENTITY(1,1),
		bookingId INT,
		seats_cancelled INT,
		cancellation_date DATETIME,
		FOREIGN KEY (bookingId) REFERENCES Bookings(bookingId)
	)



	INSERT INTO Train (tno, tname, [from], dest, price, class_of_travel, train_status, seats_available)
	VALUES 
		(1221,  'VandeBharath', 'Chennai', 'Bangalore', 2345, '1AC', 'inactive', 120),
		(14543, 'Rajdhani exp', 'Chennai', 'Delhi',	3500, '1AC', 'active', 24),
		(14546, 'Rajdhani exp', 'Chennai', 'Delhi',	3000, '2AC', 'active', 54);


SELECT * FROM Train;

INSERT INTO Users values('Ayesha','aayesha','user');

SELECT * FROM Users;

INSERT INTO Users values('Admin','Admin','admin');
create database TrainBookingDB

CREATE TABLE Trains (
    TrainID INT PRIMARY KEY IDENTITY,
    TrainName NVARCHAR(100),
    Destination NVARCHAR(100),
    StartingLocation NVARCHAR(100),
    SeatsAvailable INT,
    PricePerSeat DECIMAL(10, 2)
)

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50),
    Password NVARCHAR(50),
    IsAdmin BIT
)
 
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY,
    UserID INT,
    TrainID INT,
    SeatsBooked INT,
    BookingDate DATETIME,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TrainID) REFERENCES Trains(TrainID)
)
 
USE TrainBookingDB;
 
CREATE TABLE Cancellations (
    CancellationID INT PRIMARY KEY IDENTITY,
    BookingID INT,
    CancellationDate DATETIME,
    RefundAmount DECIMAL(10, 2),
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
)
  
INSERT INTO Users (Username, Password, IsAdmin)
VALUES ('admin1', 'password1A', 1), 
('u1', 'pass1', 0), ('u2', 'pass', 0),
('us3', 'pass3', 0), ('u4', 'pass4', 0),(
'u5', 'pass5', 0), ('u6', 'pass6', 0), 
('u7', 'pass7', 0), ('u8', 'pass8', 0), 
('u9', 'pass9', 0)

INSERT INTO Trains (TrainName, Destination, StartingLocation, SeatsAvailable, PricePerSeat) 
VALUES ('Rajdhani Express', 'Delhi', 'Mumbai', 300, 2000.00),
('Shatabdi Express', 'Bangalore', 'Chennai', 250, 1500.00),
('Duronto Express', 'Kolkata', 'Delhi', 280, 1800.00),
('Garib Rath', 'Mumbai', 'Delhi', 320, 1200.00),
('Nandigram Express', 'Hyderabad', 'Bangalore', 260, 1400.00),
('Jan Shatabdi', 'Chennai', 'Madurai', 240, 1000.00)

 
select * from Trains
Select * from Users
select * from Bookings
select * from Cancellations
 
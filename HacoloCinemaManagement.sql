DROP TABLE MovieGenre;
DROP TABLE PromotionalMaterials;
DROP TABLE WalletTransactions;
DROP TABLE OrderDetailCombo;
DROP TABLE Tickets;
DROP TABLE Wallet;
DROP TABLE Combos;
DROP TABLE Orders;
DROP TABLE Payment;
DROP TABLE Customers;
DROP TABLE Showtimes;
DROP TABLE PricingSchedule;
DROP TABLE Theaters;
DROP TABLE Genres;
DROP TABLE Movies;
DROP TABLE Seats;

CREATE TABLE Genres (
    GenreId INT PRIMARY KEY,
    GenreName NVARCHAR(255),
    [Description] TEXT
);
CREATE TABLE Movies (
    MovieId INT PRIMARY KEY,
    MovieName NVARCHAR(255),
    [Description] TEXT,
    Duration INT NOT NULL,
    ReleaseDay DATE,
    LimitAge INT,
    [Cast] TEXT,
    Director VARCHAR(255),
    [Status] BIT,
    [Image] varbinary(MAX)
);
CREATE TABLE MovieGenre (
    MovieId INT,
    GenreId INT,
    PRIMARY KEY (MovieId, GenreId),
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId),
    FOREIGN KEY (GenreId) REFERENCES Genres(GenreId)
);
CREATE TABLE Theaters (
    TheaterId INT PRIMARY KEY,
    TheaterName nvarchar(255)
);
CREATE TABLE Seats (
    SeatId INT PRIMARY KEY,
    SeatPosition VARCHAR(255),
);
CREATE TABLE PricingSchedule (
    PricingScheduleId INT PRIMARY KEY,
    [Description] TEXT,
    Price DECIMAL(10, 0),
);
CREATE TABLE Showtimes (
    ShowtimeId INT PRIMARY KEY,
    MovieId INT NOT NULL,
    TheaterId INT NOT NULL,
    PricingScheduleID INT,
    ShowDate DATE NOT NULL,
    StartTime TIME NOT NULL,
	ShowtimeStatus BIT NOT NULL,
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId),
    FOREIGN KEY (TheaterId) REFERENCES Theaters(TheaterId),
    FOREIGN KEY (PricingScheduleID) REFERENCES PricingSchedule(PricingScheduleId)
);

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY,
    Email VARCHAR(255),
    CustomerName NVARCHAR(255),
    [Password] VARCHAR(255),
    PhoneNumber VARCHAR(20)
);
CREATE TABLE Payment (
    PaymentId INT PRIMARY KEY,
    PaymentMethod VARCHAR(255),
);
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY,
    CustomerId INT,
    OrderDate DATETIME,
    TotalPrice DECIMAL(10, 0),
    PaymentId INT,
    OrderStatus TINYINT,
	IsPrinted BIT NOT NULL,
    FOREIGN KEY (PaymentId) REFERENCES Payment(PaymentId),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
CREATE TABLE Tickets (
    TicketId INT PRIMARY KEY,
    OrderId INT,
    ShowtimeId INT,
    SeatId INT,
    TicketPrice DECIMAL(10, 0),
    IsSold BIT,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ShowtimeId) REFERENCES Showtimes(ShowtimeId),
    FOREIGN KEY (SeatId) REFERENCES Seats(SeatId)
);
CREATE TABLE Combos (
    ComboId INT PRIMARY KEY,
    ComboName NVARCHAR(255),
    ComboPrice DECIMAL(10, 0)
);
CREATE TABLE OrderDetailCombo (
    OrderId INT,
    ComboId INT,
    Quantity INT,
    PRIMARY KEY (OrderId, ComboId),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ComboId) REFERENCES Combos(ComboId)
);
CREATE TABLE Wallet (
    WalletId INT PRIMARY KEY,
    CustomerId INT,
    WalletBalance DECIMAL(10, 0),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
CREATE TABLE WalletTransactions (
    WalletTransactionId INT PRIMARY KEY,
    WalletId INT,
    TransactionAmount DECIMAL(10, 0),
    TransactionDate DATETIME,
    FOREIGN KEY (WalletId) REFERENCES Wallet(WalletId)
);
CREATE TABLE PromotionalMaterials (
    MaterialID INT PRIMARY KEY,
    MovieID INT,
    FilePath VARCHAR(255),
    Type VARCHAR(255)
);
-- Inserting more data into the Genres table
INSERT INTO Genres (GenreId, GenreName, [Description])
VALUES (3, 'Romance', 'Romantic love stories'),
       (4, 'Horror', 'Scary and thrilling movies'),
       (5, 'Sci-Fi', 'Science fiction movies');

-- Inserting more data into the Movies table
INSERT INTO Movies (MovieId, MovieName, [Description], Duration, ReleaseDay, LimitAge, [Cast], Director, [Status]) VALUES 
(1, 'Avatar - Ngự khí sư cuối cùng', 'Epic romance and disaster film', 195, '1997-12-19', 13, 'Leonardo DiCaprio, Kate Winslet', 'James Cameron', 0),
(2, 'Cung đấu hoàng cung', 'Epic romance and disaster film', 195, '1997-12-19', 13, 'Leonardo DiCaprio, Kate Winslet', 'James Cameron', 1),
(3, 'Titanic', 'Epic romance and disaster film', 195, '1997-12-19', 13, 'Leonardo DiCaprio, Kate Winslet', 'James Cameron', 1),
(4, 'The Conjuring', 'Supernatural horror film', 112, '2013-07-19', 18, 'Vera Farmiga, Patrick Wilson', 'James Wan', 1),
(5, 'Interstellar', 'Epic science fiction film', 169, '2014-11-07', 13, 'Matthew McConaughey, Anne Hathaway', 'Christopher Nolan', 1);

-- Inserting more data into the MovieGenre table
INSERT INTO MovieGenre (MovieId, GenreId)
VALUES (1, 4),
	   (2,3),
	   (3, 3),
       (4, 4),
       (5, 5);

-- Inserting more data into the Theaters table
INSERT INTO Theaters (TheaterId, TheaterName)
VALUES (3, 'Theater 3'),
       (4, 'Theater 4'),
       (5, 'Theater 5');

-- Inserting more data into the Seats table
INSERT INTO Seats (SeatId, SeatPosition) VALUES
(1, 'A1'),
(2, 'A2'),
(3, 'A3'),
(4, 'A4'),
(5, 'A5'),
(6, 'A6'),
(7, 'A7'),
(8, 'A8'),
(9, 'A9'),
(10, 'A10'),
(11, 'B1'),
(12, 'B2'),
(13, 'B3'),
(14, 'B4'),
(15, 'B5'),
(16, 'B6'),
(17, 'B7'),
(18, 'B8'),
(19, 'B9'),
(20, 'B10'),
(21, 'C1'),
(22, 'C2'),
(23, 'C3'),
(24, 'C4'),
(25, 'C5'),
(26, 'C6'),
(27, 'C7'),
(28, 'C8'),
(29, 'C9'),
(30, 'C10'),
(31, 'D1'),
(32, 'D2'),
(33, 'D3'),
(34, 'D4'),
(35, 'D5'),
(36, 'D6'),
(37, 'D7'),
(38, 'D8'),
(39, 'D9'),
(40, 'D10'),
(41, 'E1'),
(42, 'E2'),
(43, 'E3'),
(44, 'E4'),
(45, 'E5'),
(46, 'E6'),
(47, 'E7'),
(48, 'E8'),
(49, 'E9'),
(50, 'E10'),
(51, 'F1'),
(52, 'F2'),
(53, 'F3'),
(54, 'F4'),
(55, 'F5'),
(56, 'F6'),
(57, 'F7'),
(58, 'F8'),
(59, 'F9'),
(60, 'F10'),
(61, 'G1'),
(62, 'G2'),
(63, 'G3'),
(64, 'G4'),
(65, 'G5'),
(66, 'G6'),
(67, 'G7'),
(68, 'G8'),
(69, 'G9'),
(70, 'G10'),
(71, 'H1'),
(72, 'H2'),
(73, 'H3'),
(74, 'H4'),
(75, 'H5'),
(76, 'H6'),
(77, 'H7'),
(78, 'H8'),
(79, 'H9'),
(80, 'H10'),
(81, 'I1'),
(82, 'I2'),
(83, 'I3'),
(84, 'I4'),
(85, 'I5'),
(86, 'I6'),
(87, 'I7'),
(88, 'I8'),
(89, 'I9'),
(90, 'I10'),
(91, 'K1'),
(92, 'K2'),
(93, 'K3'),
(94, 'K4'),
(95, 'K5'),
(96, 'K6'),
(97, 'K7'),
(98, 'K8'),
(99, 'K9'),
(100, 'K10');

-- Inserting more data into the PricingSchedule table
INSERT INTO PricingSchedule (PricingScheduleId, [Description], Price)
VALUES (3, 'Holiday', 20),
       (4, 'Weekend', 25),
       (5, 'Special day', 30);

-- Inserting more data into the Showtimes table
INSERT INTO Showtimes (ShowtimeId, MovieId, TheaterId, PricingScheduleID, ShowDate, StartTime, ShowtimeStatus)
VALUES (3, 3, 3, 3, '2024-03-24', '16:00:00', 0),
       (4, 4, 4, 4, '2024-03-25', '19:00:00', 0),
       (5, 5, 5, 5, '2024-03-26', '21:00:00', 0);

-- Inserting more data into the Customers table
INSERT INTO Customers (CustomerId, Email, CustomerName, Password, PhoneNumber)
VALUES 
(1, 'customer1@example.com', 'Hoàng', 'password3', '1112223330'),
(2, 'customer2@example.com', 'Huynh', 'password3', '1112223330'),
(3, 'customer3@example.com', 'Customer 3', 'password3', '1112223330'),
(4, 'customer4@example.com', 'Customer 4', 'password4', '4445556660'),
(5, 'customer5@example.com', 'Customer 5', 'password5', '7778889990');

-- Inserting more data into the Payment table
INSERT INTO Payment (PaymentId, PaymentMethod)
VALUES (1, 'Cash'),
       (2, 'Bank Transfer'),
       (3, 'Electronic wallet');

-- Inserting more data into the Orders table
INSERT INTO Orders (OrderId, CustomerId, OrderDate, TotalPrice, PaymentId, OrderStatus, IsPrinted)
VALUES (3, 3, GETDATE(), 20, 1, 3, 0),
       (4, 4, GETDATE(), 25, 2, 3, 1),
       (5, 5, GETDATE(), 30, 3, 3, 0);

-- Inserting more data into the Tickets table
INSERT INTO Tickets (TicketId, OrderId, ShowtimeId, SeatId, TicketPrice, IsSold)
VALUES (3, 3, 3, 5, 20, 1),
       (4, 4, 4, 6, 25, 1),
       (5, 5, 5, 7, 30, 1);

-- Inserting more data into the Combos table
INSERT INTO Combos (ComboId, ComboName, ComboPrice)
VALUES (3, 'Combo 3', 10),
       (4, 'Combo 4', 12),
       (5, 'Combo 5', 15);

-- Inserting more data into the OrderDetailCombo table
INSERT INTO OrderDetailCombo (OrderId, ComboId, Quantity)
VALUES (3, 3, 1),
       (4, 4, 2),
       (5, 5, 1);

-- Inserting more data into the Wallet table
INSERT INTO Wallet (WalletId, CustomerId, WalletBalance)
VALUES (3, 3, 300),
       (4, 4, 400),
       (5, 5, 500);

-- Inserting more data into the WalletTransactions table
INSERT INTO WalletTransactions (WalletTransactionId, WalletId, TransactionAmount, TransactionDate)
VALUES (3, 3, 20, GETDATE()),
       (4, 4, 25, GETDATE()),
       (5, 5, 30, GETDATE());

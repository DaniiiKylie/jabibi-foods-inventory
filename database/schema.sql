-- Tables for jabibi.accdb, from the final term lesson (1:13:20).
-- PasswordHash is TEXT(255): the stored hash string is 82 characters, too long for TEXT(64).
-- Username has a unique index, so two accounts never share a name.

CREATE TABLE Users (
    UserID COUNTER CONSTRAINT PK_Users PRIMARY KEY,
    Username TEXT(50) NOT NULL,
    PasswordHash TEXT(255) NOT NULL,
    FullName TEXT(100) NOT NULL,
    UserRole TEXT(20) NOT NULL,
    IsActive YESNO NOT NULL
);

CREATE UNIQUE INDEX UX_Users_Username ON Users (Username);

CREATE TABLE Products (
    ProductID COUNTER CONSTRAINT PK_Products PRIMARY KEY,
    ProductName TEXT(120) NOT NULL,
    Category TEXT(80),
    Description MEMO,
    UnitPrice CURRENCY NOT NULL,
    Quantity LONG NOT NULL,
    ReorderLevel LONG NOT NULL,
    CreatedAt DATETIME
);

CREATE TABLE StockTransactions (
    TransactionID COUNTER CONSTRAINT PK_StockTransactions PRIMARY KEY,
    ProductID LONG NOT NULL,
    TransactionType TEXT(20) NOT NULL,
    Quantity LONG NOT NULL,
    ReferenceNote TEXT(255),
    TransactionDate DATETIME NOT NULL,
    CreatedBy TEXT(50) NOT NULL
);

CREATE TABLE ActivityLogs (
    LogID COUNTER CONSTRAINT PK_ActivityLogs PRIMARY KEY,
    Username TEXT(50),
    ActionName TEXT(60),
    Details TEXT(255),
    ActionAt DATETIME
);

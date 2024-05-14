-- Create Database if not exists
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'vpndata')
CREATE DATABASE vpndata;
GO

-- Use Database
USE vpndata;
GO

-- Table for storing user information
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(255) NOT NULL,
    [Key] NVARCHAR(14) NOT NULL,
    CONSTRAINT Unique_Username UNIQUE (Username)
);
GO

-- Table for storing VPN information
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VPNInfo]') AND type in (N'U'))
CREATE TABLE VPNInfo (
    VPNID INT IDENTITY(1,1) PRIMARY KEY,
    Country NVARCHAR(255) NOT NULL,
    ServerIP NVARCHAR(255) NOT NULL,
    Port INT NOT NULL,
    Username NVARCHAR(255) NOT NULL,
    [Password] NVARCHAR(255) NOT NULL,
    UserID INT,
    CONSTRAINT FK_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- Sample data for Users table
INSERT INTO Users (Username, [Key]) VALUES
('user1', '12345678901234'),
('user2', '98765432109876');
GO

-- Sample data for VPNInfo table
INSERT INTO VPNInfo (Country, ServerIP, Port, Username, [Password], UserID) VALUES
('USA', '192.168.1.100', 1194, 'vpnuser1', 'vpnpassword1', 1),
('UK', '192.168.1.101', 443, 'vpnuser2', 'vpnpassword2', 2);
GO

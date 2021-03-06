﻿--
-- Script was generated by Devart dbForge Studio 2020 for MySQL, Version 9.0.304.0
-- Product home page: http://www.devart.com/dbforge/mysql/studio
-- Script date 8/21/2020 7:24:59 PM
-- Server version: 10.4.13
-- Client version: 4.1
--

-- 
-- Disable foreign keys
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Set SQL mode
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8';

--
-- Set default database
--
USE btcoreframeworkdb;

--
-- Drop table `tblmdepartment`
--
DROP TABLE IF EXISTS tblmdepartment;

--
-- Drop table `tblmdesignation`
--
DROP TABLE IF EXISTS tblmdesignation;

--
-- Drop table `tblmdevice`
--
DROP TABLE IF EXISTS tblmdevice;

--
-- Drop table `tblmemployee`
--
DROP TABLE IF EXISTS tblmemployee;

--
-- Drop table `tblmholidaygroup`
--
DROP TABLE IF EXISTS tblmholidaygroup;

--
-- Drop table `tblmleavegroup`
--
DROP TABLE IF EXISTS tblmleavegroup;

--
-- Drop table `tblmleavetype`
--
DROP TABLE IF EXISTS tblmleavetype;

--
-- Drop table `tblmoutype`
--
DROP TABLE IF EXISTS tblmoutype;

--
-- Drop table `tblmshift`
--
DROP TABLE IF EXISTS tblmshift;

--
-- Drop table `tblou`
--
DROP TABLE IF EXISTS tblou;

--
-- Drop table `tblrdeviceouassignment`
--
DROP TABLE IF EXISTS tblrdeviceouassignment;

--
-- Drop table `tblremployeeouassignment`
--
DROP TABLE IF EXISTS tblremployeeouassignment;

--
-- Drop table `tblrholidaygroupassignment`
--
DROP TABLE IF EXISTS tblrholidaygroupassignment;

--
-- Drop table `tblrleavegroupassignment`
--
DROP TABLE IF EXISTS tblrleavegroupassignment;

--
-- Drop table `tbltdevicestatus`
--
DROP TABLE IF EXISTS tbltdevicestatus;

--
-- Drop table `tbltholiday`
--
DROP TABLE IF EXISTS tbltholiday;

--
-- Drop table `tbltleaveadjustment`
--
DROP TABLE IF EXISTS tbltleaveadjustment;

--
-- Drop table `tbltleaveapplication`
--
DROP TABLE IF EXISTS tbltleaveapplication;

--
-- Drop table `tbltleavebalance`
--
DROP TABLE IF EXISTS tbltleavebalance;

--
-- Drop table `tbltleaveupdaterule`
--
DROP TABLE IF EXISTS tbltleaveupdaterule;

--
-- Drop table `tbltprocessingyear`
--
DROP TABLE IF EXISTS tbltprocessingyear;

--
-- Drop table `tblttoursiteduty`
--
DROP TABLE IF EXISTS tblttoursiteduty;

--
-- Set default database
--
USE btcoreframeworkdb;

--
-- Create table `tblttoursiteduty`
--
CREATE TABLE tblttoursiteduty (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeID int(11) NOT NULL,
  FromDate datetime NOT NULL,
  ToDate datetime NOT NULL,
  FromTime timestamp NULL DEFAULT NULL,
  ToTime timestamp NULL DEFAULT NULL,
  Reason varchar(50) NOT NULL DEFAULT '',
  ProcessLevel int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Tour Site Duty';

--
-- Create table `tbltprocessingyear`
--
CREATE TABLE tbltprocessingyear (
  ID int(11) NOT NULL AUTO_INCREMENT,
  FromDate datetime NOT NULL,
  ToDate datetime NOT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Processing Year';

--
-- Create table `tbltleaveupdaterule`
--
CREATE TABLE tbltleaveupdaterule (
  ID int(11) NOT NULL AUTO_INCREMENT,
  LeaveGroupAssignmentID int(11) NOT NULL,
  TimeOfUpdate varchar(50) NOT NULL DEFAULT '',
  AddPeriod varchar(50) DEFAULT NULL,
  UpdateRule varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Leave Update Rule';

--
-- Create table `tbltleavebalance`
--
CREATE TABLE tbltleavebalance (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeID int(11) NOT NULL,
  ProcessingYearID int(11) NOT NULL,
  OpenBalance int(11) NOT NULL,
  Balance int(11) NOT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Employeee Leave Balance';

--
-- Create table `tbltleaveapplication`
--
CREATE TABLE tbltleaveapplication (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeID int(11) NOT NULL,
  FromDate datetime NOT NULL,
  ToDate datetime NOT NULL,
  FromTime timestamp NULL DEFAULT NULL,
  ToTime timestamp NULL DEFAULT NULL,
  Reason varchar(50) NOT NULL DEFAULT '',
  ProcessLevel int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Leave Application';

--
-- Create table `tbltleaveadjustment`
--
CREATE TABLE tbltleaveadjustment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeID int(11) NOT NULL,
  TrDate datetime NOT NULL,
  AdjustmentType varchar(50) NOT NULL DEFAULT '',
  Reason varchar(50) NOT NULL DEFAULT '',
  ProcessLevel int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Leave Adjustment';

--
-- Create table `tbltholiday`
--
CREATE TABLE tbltholiday (
  ID int(11) NOT NULL AUTO_INCREMENT,
  From_Date datetime NOT NULL,
  To_Date datetime NOT NULL,
  Reason varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tbltdevicestatus`
--
CREATE TABLE tbltdevicestatus (
  ID int(11) NOT NULL AUTO_INCREMENT,
  IPAddress varchar(50) DEFAULT NULL,
  CPUID varchar(50) NOT NULL DEFAULT '',
  DeviceType varchar(50) NOT NULL DEFAULT '',
  Firmware varchar(50) DEFAULT NULL,
  LastSyncTime datetime NOT NULL,
  CreatedOn datetime NOT NULL,
  ClosedOn datetime DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Device Health Status';

--
-- Create table `tblrleavegroupassignment`
--
CREATE TABLE tblrleavegroupassignment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  LeaveGroupID int(11) NOT NULL,
  LeaveTypeID int(11) NOT NULL,
  YearlyMaximum int(11) DEFAULT NULL,
  MinPerApplicaation int(11) DEFAULT NULL,
  MaxPerApplication int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  ClosedOn datetime DEFAULT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Leave and Group Assignment';

--
-- Create table `tblrholidaygroupassignment`
--
CREATE TABLE tblrholidaygroupassignment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  HolidayGroupId int(11) NOT NULL,
  HolidayId int(11) NOT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Holiday and Group Assignment';

--
-- Create table `tblremployeeouassignment`
--
CREATE TABLE tblremployeeouassignment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeID int(11) NOT NULL,
  OUID int(11) NOT NULL,
  CreatedOn datetime NOT NULL,
  ClosedOn int(11) DEFAULT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Employee OU Assignment';

--
-- Create table `tblrdeviceouassignment`
--
CREATE TABLE tblrdeviceouassignment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  OUID int(11) NOT NULL,
  DeviceID int(11) NOT NULL,
  CreatedOn datetime NOT NULL,
  ClosedOn datetime DEFAULT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Device and OU assignment';

--
-- Create table `tblou`
--
CREATE TABLE tblou (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(50) NOT NULL DEFAULT '',
  OUTypeID int(11) NOT NULL,
  ParenetOUID int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT 0,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Organisation Unit';

--
-- Create table `tblmshift`
--
CREATE TABLE tblmshift (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Code varbinary(10) NOT NULL DEFAULT '',
  Name varchar(50) DEFAULT NULL,
  StartTime timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP,
  EndTime timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  BreakFrom timestamp NULL DEFAULT NULL,
  BreakTill timestamp NULL DEFAULT NULL,
  CreatedOn datetime DEFAULT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmoutype`
--
CREATE TABLE tblmoutype (
  ID int(11) NOT NULL AUTO_INCREMENT,
  TypeName varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 2,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Master for OU Type like Company, Branch, Location';

--
-- Create table `tblmleavetype`
--
CREATE TABLE tblmleavetype (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(5) NOT NULL DEFAULT '',
  Description varchar(50) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmleavegroup`
--
CREATE TABLE tblmleavegroup (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(50) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) NOT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmholidaygroup`
--
CREATE TABLE tblmholidaygroup (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmemployee`
--
CREATE TABLE tblmemployee (
  ID int(11) NOT NULL AUTO_INCREMENT,
  EmployeeNo varchar(50) NOT NULL DEFAULT '',
  CardID varchar(50) NOT NULL DEFAULT '',
  Name varchar(50) NOT NULL DEFAULT '',
  DepartmentID int(11) DEFAULT NULL,
  DesignationID int(11) DEFAULT NULL,
  ShiftType varchar(50) NOT NULL DEFAULT '',
  WeeklyOff varchar(50) DEFAULT NULL,
  HolidayGroupID int(11) DEFAULT NULL,
  LeaveGroupID int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci,
COMMENT = 'Employee Master';

--
-- Create table `tblmdevice`
--
CREATE TABLE tblmdevice (
  ID int(11) NOT NULL AUTO_INCREMENT,
  CPUID varchar(50) NOT NULL DEFAULT '',
  IPAddress varchar(50) DEFAULT NULL,
  Name varchar(50) DEFAULT NULL,
  OUID int(11) DEFAULT NULL,
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmdesignation`
--
CREATE TABLE tblmdesignation (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `tblmdepartment`
--
CREATE TABLE tblmdepartment (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Name varchar(50) NOT NULL DEFAULT '',
  CreatedOn datetime NOT NULL,
  CreatedBy int(11) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

-- 
-- Dumping data for table tblttoursiteduty
--
-- Table timeattendance.tblttoursiteduty does not contain any data (it is empty)

-- 
-- Dumping data for table tbltprocessingyear
--
-- Table timeattendance.tbltprocessingyear does not contain any data (it is empty)

-- 
-- Dumping data for table tbltleaveupdaterule
--
-- Table timeattendance.tbltleaveupdaterule does not contain any data (it is empty)

-- 
-- Dumping data for table tbltleavebalance
--
-- Table timeattendance.tbltleavebalance does not contain any data (it is empty)

-- 
-- Dumping data for table tbltleaveapplication
--
-- Table timeattendance.tbltleaveapplication does not contain any data (it is empty)

-- 
-- Dumping data for table tbltleaveadjustment
--
-- Table timeattendance.tbltleaveadjustment does not contain any data (it is empty)

-- 
-- Dumping data for table tbltholiday
--
-- Table timeattendance.tbltholiday does not contain any data (it is empty)

-- 
-- Dumping data for table tbltdevicestatus
--
-- Table timeattendance.tbltdevicestatus does not contain any data (it is empty)

-- 
-- Dumping data for table tblrleavegroupassignment
--
-- Table timeattendance.tblrleavegroupassignment does not contain any data (it is empty)

-- 
-- Dumping data for table tblrholidaygroupassignment
--
-- Table timeattendance.tblrholidaygroupassignment does not contain any data (it is empty)

-- 
-- Dumping data for table tblremployeeouassignment
--
-- Table timeattendance.tblremployeeouassignment does not contain any data (it is empty)

-- 
-- Dumping data for table tblrdeviceouassignment
--
-- Table timeattendance.tblrdeviceouassignment does not contain any data (it is empty)

-- 
-- Dumping data for table tblou
--
-- Table timeattendance.tblou does not contain any data (it is empty)

-- 
-- Dumping data for table tblmshift
--
-- Table timeattendance.tblmshift does not contain any data (it is empty)

-- 
-- Dumping data for table tblmoutype
--
INSERT INTO tblmoutype VALUES
(1, 'COMPANY', '2020-08-11 00:00:00', NULL);

-- 
-- Dumping data for table tblmleavetype
--
-- Table timeattendance.tblmleavetype does not contain any data (it is empty)

-- 
-- Dumping data for table tblmleavegroup
--
-- Table timeattendance.tblmleavegroup does not contain any data (it is empty)

-- 
-- Dumping data for table tblmholidaygroup
--
-- Table timeattendance.tblmholidaygroup does not contain any data (it is empty)

-- 
-- Dumping data for table tblmemployee
--
-- Table timeattendance.tblmemployee does not contain any data (it is empty)

-- 
-- Dumping data for table tblmdevice
--
-- Table timeattendance.tblmdevice does not contain any data (it is empty)

-- 
-- Dumping data for table tblmdesignation
--
-- Table timeattendance.tblmdesignation does not contain any data (it is empty)

-- 
-- Dumping data for table tblmdepartment
--
-- Table timeattendance.tblmdepartment does not contain any data (it is empty)

-- 
-- Restore previous SQL mode
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Enable foreign keys
-- 
/*!40014 SET FOREIGN_KEY_CHECKS = @OLD_FOREIGN_KEY_CHECKS */;
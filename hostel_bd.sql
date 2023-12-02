-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: hostel
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `authorization`
--

DROP TABLE IF EXISTS `authorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorization` (
  `idauthorization` int NOT NULL,
  `idemployer` int NOT NULL,
  `login` varchar(20) NOT NULL,
  `password_1` varchar(20) NOT NULL,
  `idpost` int NOT NULL,
  PRIMARY KEY (`idauthorization`),
  UNIQUE KEY `login_UNIQUE` (`login`),
  KEY `idpost_idx` (`idpost`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorization`
--

LOCK TABLES `authorization` WRITE;
/*!40000 ALTER TABLE `authorization` DISABLE KEYS */;
INSERT INTO `authorization` VALUES (1,1,'ivanov','ivanov',1),(2,2,'kazakov','kazakov',2),(3,3,'lebedeva','lebedeva',2),(4,4,'shashkova','shashkova',3);
/*!40000 ALTER TABLE `authorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cleanning`
--

DROP TABLE IF EXISTS `cleanning`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cleanning` (
  `idcleanning` int NOT NULL AUTO_INCREMENT,
  `cleanning_date` datetime(2) NOT NULL,
  `idemployer` int NOT NULL,
  `idschedule` int NOT NULL,
  PRIMARY KEY (`idcleanning`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cleanning`
--

LOCK TABLES `cleanning` WRITE;
/*!40000 ALTER TABLE `cleanning` DISABLE KEYS */;
/*!40000 ALTER TABLE `cleanning` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employer`
--

DROP TABLE IF EXISTS `employer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employer` (
  `idemployer` int NOT NULL AUTO_INCREMENT,
  `idhostels` int NOT NULL,
  `employer_lastname` varchar(30) NOT NULL,
  `employer_firstname` varchar(30) NOT NULL,
  `employer_birthday` date NOT NULL,
  `employer_status` varchar(50) NOT NULL,
  `employercol` varchar(11) NOT NULL,
  `idpost` int NOT NULL,
  `idschedule` int(10) unsigned zerofill DEFAULT NULL,
  PRIMARY KEY (`idemployer`),
  KEY `idpost_idx` (`idpost`),
  KEY `idhostels_idx` (`idhostels`),
  KEY `idschedule_idx` (`idschedule`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employer`
--

LOCK TABLES `employer` WRITE;
/*!40000 ALTER TABLE `employer` DISABLE KEYS */;
INSERT INTO `employer` VALUES (1,1,'Иванов','Иван','1975-04-25','работает','89371234567',1,0000000001),(2,1,'Казаков','Федор','1994-06-29','работает','89651234567',2,0000000002),(3,1,'Лебедеваа','Анастасия','1996-01-16','в отпуске','89458621975',2,0000000003),(4,1,'Шашкова','Анастасия','1989-10-20','работает','89657321984',3,0000000000);
/*!40000 ALTER TABLE `employer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `extension`
--

DROP TABLE IF EXISTS `extension`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `extension` (
  `idextension` int NOT NULL AUTO_INCREMENT,
  `extensionname` varchar(45) NOT NULL,
  PRIMARY KEY (`idextension`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `extension`
--

LOCK TABLES `extension` WRITE;
/*!40000 ALTER TABLE `extension` DISABLE KEYS */;
INSERT INTO `extension` VALUES (1,'телевизор'),(2,'холодильник'),(3,'балкон'),(4,'телевизор, холодильник'),(5,'холодильник, балкон'),(6,'телевизор, холодильник, балкон');
/*!40000 ALTER TABLE `extension` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hostels`
--

DROP TABLE IF EXISTS `hostels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hostels` (
  `idhostels` int NOT NULL AUTO_INCREMENT,
  `hostelsname` varchar(30) NOT NULL,
  `hostelscol` varchar(11) NOT NULL,
  `hostelsemail` varchar(45) NOT NULL,
  `hostelsaddress` varchar(50) NOT NULL,
  `hostelssite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idhostels`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hostels`
--

LOCK TABLES `hostels` WRITE;
/*!40000 ALTER TABLE `hostels` DISABLE KEYS */;
INSERT INTO `hostels` VALUES (1,'Браво','89997654321','bravo1.samara@mail.com','г. Самара, ул.Молодогвардейская, 1','bravo1Samara.ru'),(2,'Браво','89991234567','bravo2.samara@mail.com','г. Самара, ул.Запарожская,240','bravo2Samara.ru'),(3,'Браво','89008765432','bravo3.samara@mail.com','г. Самара, ул.Азонова, 68',NULL);
/*!40000 ALTER TABLE `hostels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `number`
--

DROP TABLE IF EXISTS `number`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `number` (
  `idnumber` int NOT NULL AUTO_INCREMENT,
  `idhostels` int NOT NULL,
  `idtype` int NOT NULL,
  `idextension` int DEFAULT NULL,
  `idcleaning` int DEFAULT NULL,
  PRIMARY KEY (`idnumber`),
  KEY `idhostels_idx` (`idhostels`),
  KEY `idtype_idx` (`idtype`),
  KEY `idcleanning_idx` (`idcleaning`),
  KEY `idextension_idx` (`idextension`),
  CONSTRAINT `idcleanning` FOREIGN KEY (`idcleaning`) REFERENCES `cleanning` (`idcleanning`),
  CONSTRAINT `idextension` FOREIGN KEY (`idextension`) REFERENCES `extension` (`idextension`),
  CONSTRAINT `idhostels` FOREIGN KEY (`idhostels`) REFERENCES `hostels` (`idhostels`),
  CONSTRAINT `idtype` FOREIGN KEY (`idtype`) REFERENCES `type` (`idtype`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `number`
--

LOCK TABLES `number` WRITE;
/*!40000 ALTER TABLE `number` DISABLE KEYS */;
INSERT INTO `number` VALUES (1,1,1,2,NULL),(2,1,1,2,NULL),(3,1,1,2,NULL),(4,1,1,2,NULL),(5,1,1,2,NULL),(6,1,1,2,NULL),(7,1,1,2,NULL),(8,1,1,2,NULL),(9,1,1,2,NULL),(10,1,1,2,NULL),(11,1,2,2,NULL),(12,1,2,2,NULL),(13,1,2,2,NULL),(14,1,2,2,NULL),(15,1,2,2,NULL),(16,1,2,2,NULL),(17,1,2,2,NULL),(18,1,2,2,NULL),(19,1,2,2,NULL),(20,1,2,2,NULL),(21,1,2,2,NULL),(22,1,2,2,NULL),(23,1,2,2,NULL),(24,1,2,2,NULL),(25,1,2,2,NULL),(26,1,2,2,NULL),(27,1,2,2,NULL),(28,1,2,2,NULL),(29,1,2,2,NULL),(30,1,2,2,NULL),(31,1,3,4,NULL),(32,1,3,4,NULL),(33,1,3,4,NULL),(34,1,3,4,NULL),(35,1,3,4,NULL),(36,1,3,4,NULL),(37,1,3,4,NULL),(38,1,3,4,NULL),(39,1,3,4,NULL),(40,1,3,4,NULL),(41,1,3,4,NULL),(42,1,3,4,NULL),(43,1,3,4,NULL),(44,1,3,4,NULL),(45,1,3,4,NULL),(46,1,3,4,NULL),(47,1,3,4,NULL),(48,1,3,4,NULL),(49,1,3,4,NULL),(50,1,3,4,NULL),(51,1,4,4,NULL),(52,1,4,4,NULL),(53,1,4,4,NULL),(54,1,4,4,NULL),(55,1,4,4,NULL),(56,1,4,4,NULL),(57,1,4,4,NULL),(58,1,4,4,NULL),(59,1,4,4,NULL),(60,1,4,4,NULL),(61,1,4,4,NULL),(62,1,4,4,NULL),(63,1,4,4,NULL),(64,1,4,4,NULL),(65,1,4,4,NULL),(66,1,4,4,NULL),(67,1,4,4,NULL),(68,1,4,4,NULL),(69,1,4,4,NULL),(70,1,4,4,NULL),(71,1,5,2,NULL),(72,1,5,2,NULL),(73,1,5,2,NULL),(74,1,5,2,NULL),(75,1,5,2,NULL),(76,1,5,2,NULL),(77,1,5,2,NULL),(78,1,5,2,NULL),(79,1,5,2,NULL),(80,1,5,2,NULL),(81,1,5,2,NULL),(82,1,5,2,NULL),(83,1,5,2,NULL),(84,1,5,2,NULL),(85,1,5,2,NULL),(86,1,5,2,NULL),(87,1,5,2,NULL),(88,1,5,2,NULL),(89,1,5,2,NULL),(90,1,5,2,NULL),(91,1,6,6,NULL),(92,1,6,6,NULL),(93,1,6,6,NULL),(94,1,6,6,NULL),(95,1,6,6,NULL),(96,1,6,6,NULL),(97,1,6,6,NULL),(98,1,6,6,NULL),(99,1,6,6,NULL),(100,1,6,6,NULL);
/*!40000 ALTER TABLE `number` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `post`
--

DROP TABLE IF EXISTS `post`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `post` (
  `idpost` int NOT NULL AUTO_INCREMENT,
  `postname` varchar(45) DEFAULT NULL,
  `post_rate` int DEFAULT NULL,
  PRIMARY KEY (`idpost`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `post`
--

LOCK TABLES `post` WRITE;
/*!40000 ALTER TABLE `post` DISABLE KEYS */;
INSERT INTO `post` VALUES (1,'Директор',625),(2,'Администратор',375),(3,'Уборщик',187);
/*!40000 ALTER TABLE `post` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quest`
--

DROP TABLE IF EXISTS `quest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quest` (
  `idquest` int NOT NULL AUTO_INCREMENT,
  `quest_lastname` varchar(45) NOT NULL,
  `quest_firstname` varchar(45) NOT NULL,
  `quest_birthday` date NOT NULL,
  `questcol` varchar(11) NOT NULL,
  PRIMARY KEY (`idquest`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quest`
--

LOCK TABLES `quest` WRITE;
/*!40000 ALTER TABLE `quest` DISABLE KEYS */;
INSERT INTO `quest` VALUES (1,'Варакута','Екатерина','2008-04-20','89123456789'),(2,'Иванов','Иван','1989-07-28','23456789764');
/*!40000 ALTER TABLE `quest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation` (
  `idreservation` int NOT NULL AUTO_INCREMENT,
  `idquest` int NOT NULL,
  `idnumber` int NOT NULL,
  `data_start` date NOT NULL,
  `data_stop` date NOT NULL,
  `idpay` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idreservation`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` VALUES (1,1,12,'2022-06-04','2022-07-04',NULL),(2,2,2,'2022-06-05','2022-06-15','+'),(3,2,2,'2005-06-20','2005-06-20','+'),(4,2,99,'2005-06-20','2005-06-20','+');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule` (
  `idschedule` int NOT NULL AUTO_INCREMENT,
  `idemployer` int NOT NULL,
  `time_from` time NOT NULL,
  `time_do` time NOT NULL,
  `data_from` date NOT NULL,
  `data_to` date NOT NULL,
  `work_day` int NOT NULL,
  `weekend_day` int NOT NULL,
  `attendance` tinyint DEFAULT NULL,
  PRIMARY KEY (`idschedule`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` VALUES (1,1,'09:00:00','17:00:00','2022-04-01','2023-04-01',5,2,NULL),(2,2,'17:00:00','01:00:00','2022-04-01','2023-04-01',5,2,NULL),(3,3,'18:00:00','02:00:00','2022-04-04','2022-10-04',5,2,NULL);
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type`
--

DROP TABLE IF EXISTS `type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type` (
  `idtype` int NOT NULL AUTO_INCREMENT,
  `typename` varchar(45) NOT NULL,
  `single_bead` int NOT NULL,
  `double_bead` int NOT NULL,
  `price` int NOT NULL,
  PRIMARY KEY (`idtype`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type`
--

LOCK TABLES `type` WRITE;
/*!40000 ALTER TABLE `type` DISABLE KEYS */;
INSERT INTO `type` VALUES (1,'Стандарт одноместный',1,0,500),(2,'Стандарт двухместный',2,0,1000),(3,'Стандарт двухместный',0,2,1000),(4,'Стандарт трехместный',1,1,1800),(5,'Стандарт трехместный',3,0,1800),(6,'VIP (двухместный)',0,1,2500);
/*!40000 ALTER TABLE `type` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-18  9:49:00

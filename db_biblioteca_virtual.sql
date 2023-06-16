-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_biblioteca_virtual
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
-- Table structure for table `bvaluno`
--

DROP TABLE IF EXISTS `bvaluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bvaluno` (
  `AlunoID` int NOT NULL AUTO_INCREMENT,
  `AlunoNome` varchar(100) NOT NULL,
  `EmailAluno` varchar(80) NOT NULL,
  `CelAluno` varchar(80) NOT NULL,
  `MatriAluno` varchar(80) NOT NULL,
  `SenhaAluno` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`AlunoID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bvaluno`
--

LOCK TABLES `bvaluno` WRITE;
/*!40000 ALTER TABLE `bvaluno` DISABLE KEYS */;
INSERT INTO `bvaluno` VALUES (1,'','','','','',''),(2,'','','','','',''),(3,'','','','','',''),(4,'System.Windows.Forms.TextBox, Text: rosa','System.Windows.Forms.TextBox, Text: rosasep@gmail.com','System.Windows.Forms.TextBox, Text: (61) 3472-3586','System.Windows.Forms.TextBox, Text: 4','System.Windows.Forms.TextBox, Text: palmeiras1914','System.Windows.Forms.TextBox, Text: 121 casa das prima'),(5,'rosa','amoserverdao@gmail.com','(11) 982521223','5','meupalmeiras','2021 allianz parque'),(6,'lorenzo','garanhaoitaliano@gmail.com','11 983531338','7','1912','vila belmiro');
/*!40000 ALTER TABLE `bvaluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bvbibliotecario`
--

DROP TABLE IF EXISTS `bvbibliotecario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bvbibliotecario` (
  `BibliID` int NOT NULL AUTO_INCREMENT,
  `BibliNome` varchar(100) NOT NULL,
  `EmailBibli` varchar(80) NOT NULL,
  `CelBibli` varchar(80) NOT NULL,
  `MatriBibli` varchar(80) NOT NULL,
  `SenhaBibli` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`BibliID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bvbibliotecario`
--

LOCK TABLES `bvbibliotecario` WRITE;
/*!40000 ALTER TABLE `bvbibliotecario` DISABLE KEYS */;
INSERT INTO `bvbibliotecario` VALUES (1,'bibliotecario','bibliotecavirtual@gmail.com','(11) 93627-5501','8','biblioteca313','Rua Charlie Brown Jr 013');
/*!40000 ALTER TABLE `bvbibliotecario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bvemprestimos`
--

DROP TABLE IF EXISTS `bvemprestimos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bvemprestimos` (
  `ID_Emp` int NOT NULL AUTO_INCREMENT,
  `LivroID` int DEFAULT NULL,
  `LivroNome` varchar(80) DEFAULT NULL,
  `Data_Emp` date DEFAULT NULL,
  `Data_Devolucao` date DEFAULT NULL,
  PRIMARY KEY (`ID_Emp`),
  KEY `LivroID` (`LivroID`),
  CONSTRAINT `bvemprestimos_ibfk_1` FOREIGN KEY (`LivroID`) REFERENCES `bvlivro` (`LivroID`)
) ENGINE=InnoDB AUTO_INCREMENT=132 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bvemprestimos`
--

LOCK TABLES `bvemprestimos` WRITE;
/*!40000 ALTER TABLE `bvemprestimos` DISABLE KEYS */;
/*!40000 ALTER TABLE `bvemprestimos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bvlivro`
--

DROP TABLE IF EXISTS `bvlivro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bvlivro` (
  `LivroID` int NOT NULL AUTO_INCREMENT,
  `LivroNome` varchar(80) NOT NULL,
  `LivroAutor` varchar(50) NOT NULL,
  `LivroGenero` varchar(30) NOT NULL,
  `FaixaEtaria` varchar(30) NOT NULL,
  `Plataforma` varchar(80) NOT NULL,
  `AnoLanc` varchar(4) NOT NULL,
  `Sinopse` varchar(100) NOT NULL,
  PRIMARY KEY (`LivroID`),
  KEY `LivroNome` (`LivroNome`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bvlivro`
--

LOCK TABLES `bvlivro` WRITE;
/*!40000 ALTER TABLE `bvlivro` DISABLE KEYS */;
INSERT INTO `bvlivro` VALUES (1,'Diário de um banana','Jeff Kinney','Humor','12+','Livro Físico','2007','O livro é sobre um menino chamado Greg Heffley e suas tentativas de se tornar popular.'),(2,'Segredos da comédia stand-up','Leo Lins','Humor','12+','Livro Físico','2014','Neste livro, Léo Lins revela os segredos da construção de uma boa piada');
/*!40000 ALTER TABLE `bvlivro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bvprofessor`
--

DROP TABLE IF EXISTS `bvprofessor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bvprofessor` (
  `ProfID` int NOT NULL AUTO_INCREMENT,
  `ProfNome` varchar(100) NOT NULL,
  `EmailProf` varchar(80) NOT NULL,
  `CelProf` varchar(80) NOT NULL,
  `MatriProf` varchar(80) NOT NULL,
  `SenhaProf` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`ProfID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bvprofessor`
--

LOCK TABLES `bvprofessor` WRITE;
/*!40000 ALTER TABLE `bvprofessor` DISABLE KEYS */;
INSERT INTO `bvprofessor` VALUES (1,'leptich','leptich@gmail.com','(11) 691123369','1','vaitrikas','313 casa das prima');
/*!40000 ALTER TABLE `bvprofessor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-13 23:14:36

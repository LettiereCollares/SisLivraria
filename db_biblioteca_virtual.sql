CREATE TABLE `bvaluno` (
  `AlunoID` int NOT NULL AUTO_INCREMENT,
  `AlunoNome` varchar(100) NOT NULL,
  `EmailAluno` varchar(80) NOT NULL,
  `CelAluno` varchar(80) NOT NULL,
  `MatriAluno` varchar(80) NOT NULL,
  `SenhaAluno` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`AlunoID`)
);


CREATE TABLE `bvbibliotecario` (
  `BibliID` int NOT NULL AUTO_INCREMENT,
  `BibliNome` varchar(100) NOT NULL,
  `EmailBibli` varchar(80) NOT NULL,
  `CelBibli` varchar(80) NOT NULL,
  `MatriBibli` varchar(80) NOT NULL,
  `SenhaBibli` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`BibliID`)
);

CREATE TABLE `bvemprestimos` (
  `ID_Emp` int NOT NULL AUTO_INCREMENT,
  `LivroID` int DEFAULT NULL,
  `LivroNome` varchar(80) DEFAULT NULL,
  `Data_Emp` date DEFAULT NULL,
  `Data_Devolucao` date DEFAULT NULL,
  PRIMARY KEY (`ID_Emp`),
  KEY `LivroID` (`LivroID`),
  CONSTRAINT `bvemprestimos_ibfk_1` FOREIGN KEY (`LivroID`) REFERENCES `bvlivro` (`LivroID`)
);


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
);

CREATE TABLE `bvprofessor` (
  `ProfID` int NOT NULL AUTO_INCREMENT,
  `ProfNome` varchar(100) NOT NULL,
  `EmailProf` varchar(80) NOT NULL,
  `CelProf` varchar(80) NOT NULL,
  `MatriProf` varchar(80) NOT NULL,
  `SenhaProf` varchar(80) NOT NULL,
  `Endereco` varchar(80) NOT NULL,
  PRIMARY KEY (`ProfID`)
);

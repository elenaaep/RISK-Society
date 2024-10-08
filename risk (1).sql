-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gazdă: 127.0.0.1
-- Timp de generare: mai 30, 2024 la 04:05 PM
-- Versiune server: 10.4.28-MariaDB
-- Versiune PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Bază de date: `risk`
--

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `amenintari`
--

CREATE TABLE `amenintari` (
  `cod_bun` int(4) NOT NULL,
  `amenintare` varchar(255) NOT NULL,
  `nivel_minim` int(6) NOT NULL,
  `nivel_maxim` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `amenintari`
--

INSERT INTO `amenintari` (`cod_bun`, `amenintare`, `nivel_minim`, `nivel_maxim`) VALUES
(8, 'Atentate cu caracter intention', 1, 8),
(12, 'Spargere echipamente', 2, 9),
(18, 'Spam-uri', 3, 9),
(5, 'Provocarea structurii organiza', 4, 8),
(20, 'Spam-uri', 3, 5),
(15, 'Atentate cu caracter intention', 3, 7);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `bunuri`
--

CREATE TABLE `bunuri` (
  `cod_bun` int(4) NOT NULL,
  `cod_proiect` int(4) NOT NULL,
  `nume_bun` varchar(255) NOT NULL,
  `impact_minim` int(6) NOT NULL,
  `impact_maxim` varchar(30) NOT NULL,
  `domeniu_categorie` varchar(30) NOT NULL,
  `cost` int(6) NOT NULL,
  `cost_reducere` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `bunuri`
--

INSERT INTO `bunuri` (`cod_bun`, `cod_proiect`, `nume_bun`, `impact_minim`, `impact_maxim`, `domeniu_categorie`, `cost`, `cost_reducere`) VALUES
(1, 1, 'Personal / angajat organizatie', 6, '10', 'Oameni', 0, 0),
(2, 1, 'Furnizori', 8, '10', 'Oameni', 0, 0),
(3, 1, 'Personal poza organizatie', 5, '7', 'Oameni', 0, 0),
(4, 2, 'Echipa de curatare', 1, '4', 'Oameni', 0, 0),
(5, 2, 'Clienti - reprezentanti guvern', 8, '10', 'Oameni', 0, 0),
(6, 2, 'Contract de desfasurare pentru', 9, '10', 'Activități', 1060000000, 0),
(7, 1, 'Program de lansare teste', 2, '5', 'Activități', 0, 0),
(8, 2, 'Imaginea organizatiei', 7, '9', 'Activități', 0, 0),
(9, 1, 'Sisteme de arme majore si manu', 6, '8', 'Informații', 0, 0),
(10, 1, 'Informații despre sistemele sa', 7, '10', 'Informații', 0, 0),
(11, 3, 'Documente cu informatii secret', 8, '10', 'Informații', 0, 0),
(12, 3, 'Informatii despre datele si te', 8, '10', 'Informații', 0, 0),
(13, 4, 'Detalii de proiectare, informa', 8, '10', 'Informații', 0, 0),
(14, 3, 'Demonstratii ale diferitelor a', 8, '10', 'Informații', 0, 0),
(15, 2, 'Informatii confidentiale', 8, '10', 'Informații', 0, 100),
(16, 4, 'Acces la bazele de date intern', 9, '10', 'Informații', 0, 0),
(17, 4, 'Acces la bazele de date interne', 2, '6', 'Facilitati', 0, 0),
(18, 4, 'Energie', 6, '9', 'Facilități', 0, 0),
(19, 4, 'Diverse', 6, '8', 'Facilități', 0, 0),
(20, 3, 'Furnizori', 4, '9', 'Oameni', 10, 100),
(21, 2, 'Energie', 2, '8', 'Facilitati', 120, 10),
(22, 2, 'Diverse', 3, '6', 'Oameni', 0, 100),
(23, 1, 'Personal / angajat organizatie', 6, '10', 'Oameni', 0, 0);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `contramasuri`
--

CREATE TABLE `contramasuri` (
  `cod_risc` int(4) NOT NULL,
  `metoda_tratare` varchar(30) NOT NULL,
  `categorie_contramasuri` varchar(30) NOT NULL,
  `tratat` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `contramasuri`
--

INSERT INTO `contramasuri` (`cod_risc`, `metoda_tratare`, `categorie_contramasuri`, `tratat`) VALUES
(1, 'Asumare risc', 'Organizational', 'NU'),
(2, 'Dimuare risc', 'Tehnic', 'DA'),
(3, 'Asumare risc', 'Organizational', 'NU'),
(4, 'Asumare risc', 'Organizational', 'NU'),
(2, 'Dimuare risc', 'Tehnic', 'DA'),
(1, 'Asumare risc', 'Organizational', 'DA');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `istoric`
--

CREATE TABLE `istoric` (
  `ID` int(11) NOT NULL,
  `Action` varchar(1000) DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL,
  `interfata` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `istoric`
--

INSERT INTO `istoric` (`ID`, `Action`, `Timestamp`, `interfata`) VALUES
(1, 'Accesare istoric', '2024-05-19 02:37:52', ''),
(2, 'Accesare istoric', '2024-05-19 02:38:04', ''),
(3, 'Accesare istoric', '2024-05-19 02:51:58', ''),
(4, 'Accesare istoric', '2024-05-20 00:20:00', ''),
(5, 'Accesare istoric', '2024-05-20 00:22:24', 'NumeInterfata'),
(6, 'Accesare istoric', '2024-05-20 00:23:20', 'Bunuri'),
(7, 'Accesare istoric', '2024-05-20 00:24:37', 'Vulnerabilitati'),
(8, 'Accesare istoric', '2024-05-22 17:40:29', 'Amenintari'),
(9, 'Accesare istoric', '2024-05-26 21:02:51', 'Amenintari'),
(10, 'Accesare istoric', '2024-05-27 18:26:57', 'Contramasuri'),
(11, 'Accesare istoric', '2024-05-27 18:27:46', 'Contramasuri'),
(12, 'Accesare istoric', '2024-05-27 20:31:47', 'Contramasuri'),
(13, 'Accesare istoric', '2024-05-27 20:32:10', 'Bunuri'),
(14, 'Accesare istoric', '2024-05-27 20:32:33', 'Amenintari'),
(15, 'Accesare istoric', '2024-05-27 20:32:36', 'Amenintari'),
(16, 'Accesare istoric', '2024-05-27 20:33:46', 'Vulnerabilitati'),
(17, 'Accesare istoric', '2024-05-27 20:33:58', 'Riscuri'),
(18, 'Accesare istoric', '2024-05-27 20:34:27', 'Contramasuri'),
(19, 'Accesare istoric', '2024-05-27 21:28:14', 'Riscuri'),
(20, 'Accesare istoric', '2024-05-30 16:49:31', 'Bunuri'),
(21, 'Accesare istoric', '2024-05-30 16:55:51', 'Bunuri');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `organizatie`
--

CREATE TABLE `organizatie` (
  `denumire` varchar(30) NOT NULL,
  `adresa` varchar(30) NOT NULL,
  `persoana_contact` varchar(30) NOT NULL,
  `telefon` int(10) NOT NULL,
  `user` varchar(30) NOT NULL,
  `parola` varchar(30) NOT NULL,
  `cod_proiect` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `organizatie`
--

INSERT INTO `organizatie` (`denumire`, `adresa`, `persoana_contact`, `telefon`, `user`, `parola`, `cod_proiect`) VALUES
('Risk Society', '123 Main St, City', 'John Doe', 1234567890, 'jdoe', 'password123', 1);

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `proiect`
--

CREATE TABLE `proiect` (
  `cod_proiect` int(4) NOT NULL,
  `denumire` varchar(30) NOT NULL,
  `domeniul` varchar(30) NOT NULL,
  `data_inceput` date NOT NULL,
  `data_final` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `proiect`
--

INSERT INTO `proiect` (`cod_proiect`, `denumire`, `domeniul`, `data_inceput`, `data_final`) VALUES
(1, 'Risk Analysis Project', 'Security', '2024-01-01', '2024-12-31'),
(2, 'Cybersecurity Enhancement', 'IT', '2024-02-01', '2024-11-30'),
(3, 'Infrastructure Upgrade', 'Engineering', '2024-03-01', '2024-10-31'),
(4, 'Data Protection Initiative', 'Data Security', '2024-04-01', '2024-09-30');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `register`
--

CREATE TABLE `register` (
  `nume` varchar(30) NOT NULL,
  `prenume` varchar(30) NOT NULL,
  `gen` varchar(30) NOT NULL,
  `zi_nastere` date NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `register`
--

INSERT INTO `register` (`nume`, `prenume`, `gen`, `zi_nastere`, `username`, `password`) VALUES
('Popescu', 'Maria', 'femeie', '1990-01-01', 'maria90', 'parola123'),
('Ionescu', 'Ion', 'barbat', '1985-05-10', 'ion85', 'parola456'),
('Pop', 'Ana', 'femeie', '1988-12-25', 'ana88', 'parola789'),
('Elena', 'Parteni', 'Femeie', '2002-03-20', 'elenaa_ep', 'admin'),
('Staicu', 'Gabriel', 'Barbat', '2024-05-30', 'gabi', 'admin'),
('Daniel', 'Ioana', 'Femeie', '2024-01-24', 'ioana', 'admin');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `riscuri`
--

CREATE TABLE `riscuri` (
  `cod_risc` int(4) NOT NULL,
  `cod_bun` int(4) NOT NULL,
  `nume_risc` varchar(30) NOT NULL,
  `nivelul_riscului` int(6) NOT NULL,
  `probabilitate_aparitie` int(6) NOT NULL,
  `natura_riscului` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `riscuri`
--

INSERT INTO `riscuri` (`cod_risc`, `cod_bun`, `nume_risc`, `nivelul_riscului`, `probabilitate_aparitie`, `natura_riscului`) VALUES
(1, 1, 'R1_A1_T1_V1', 7, 906, 'Hazard'),
(2, 4, 'R4_A1_T4_V1', 9, 1070, 'Hazard'),
(3, 3, 'R3_A1_T3_V1', 3, 330, 'Hazard'),
(4, 2, 'R2_A1_T2_V1', 26, 3305, 'Hazard'),
(5, 6, 'R8_A1_T8_V1', 8, 80, 'Hazard'),
(7, 4, 'R5_A1_T5_V1', 20, 45, 'Hazard');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `vulnerabilitati`
--

CREATE TABLE `vulnerabilitati` (
  `cod_bun` int(4) NOT NULL,
  `vulnerabilitate` varchar(255) NOT NULL,
  `nivel` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Eliminarea datelor din tabel `vulnerabilitati`
--

INSERT INTO `vulnerabilitati` (`cod_bun`, `vulnerabilitate`, `nivel`) VALUES
(1, 'Lipsa de pregătire a personalu', 'mediu'),
(2, 'Dependenta de furnizori unici', 'mediu'),
(3, 'Lipsa de acces la informații c', 'mare'),
(19, 'Lipsa de acces la informatii cibernetice', 'foarte mare'),
(5, 'Intreruperi in comunicatii', 'mediu'),
(19, 'Lipsa de acces la informatii cibernetice', 'foarte mare'),
(7, 'Defecțiuni ale echipamentelor', 'mare'),
(8, 'Lipsa de materiale', 'mediu'),
(9, 'Sisteme de monitorizare compro', 'mare'),
(10, 'Breșe în protecția datelor', 'mare'),
(11, 'Defecțiuni de stocare', 'mare'),
(12, 'Criptare insuficientă', 'mediu'),
(19, 'Lipsa de acces la informatii cibernetice', 'foarte mare'),
(17, 'Dependenta de furnizori unici', 'mare'),
(12, 'Dependenta de furnizori unici', 'mic'),
(14, 'Intreruperi in comunicatii', 'mic'),
(4, 'Brese in protectia datelor', 'foarte mare'),
(6, 'Brese in protectia datelor', 'foarte mare'),
(7, 'lipsa', 'mic'),
(21, 'Lipsa de pregătire a personalu', 'mediu');

--
-- Indexuri pentru tabele eliminate
--

--
-- Indexuri pentru tabele `amenintari`
--
ALTER TABLE `amenintari`
  ADD KEY `cod_bun` (`cod_bun`);

--
-- Indexuri pentru tabele `bunuri`
--
ALTER TABLE `bunuri`
  ADD PRIMARY KEY (`cod_bun`),
  ADD KEY `cod_proiect1` (`cod_proiect`);

--
-- Indexuri pentru tabele `contramasuri`
--
ALTER TABLE `contramasuri`
  ADD KEY `cod_risc` (`cod_risc`);

--
-- Indexuri pentru tabele `istoric`
--
ALTER TABLE `istoric`
  ADD PRIMARY KEY (`ID`);

--
-- Indexuri pentru tabele `organizatie`
--
ALTER TABLE `organizatie`
  ADD KEY `cod_proiect` (`cod_proiect`);

--
-- Indexuri pentru tabele `proiect`
--
ALTER TABLE `proiect`
  ADD PRIMARY KEY (`cod_proiect`);

--
-- Indexuri pentru tabele `riscuri`
--
ALTER TABLE `riscuri`
  ADD PRIMARY KEY (`cod_risc`),
  ADD KEY `cod_bun1` (`cod_bun`);

--
-- Indexuri pentru tabele `vulnerabilitati`
--
ALTER TABLE `vulnerabilitati`
  ADD KEY `cod_bun2` (`cod_bun`);

--
-- AUTO_INCREMENT pentru tabele eliminate
--

--
-- AUTO_INCREMENT pentru tabele `istoric`
--
ALTER TABLE `istoric`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constrângeri pentru tabele eliminate
--

--
-- Constrângeri pentru tabele `amenintari`
--
ALTER TABLE `amenintari`
  ADD CONSTRAINT `cod_bun` FOREIGN KEY (`cod_bun`) REFERENCES `bunuri` (`cod_bun`);

--
-- Constrângeri pentru tabele `bunuri`
--
ALTER TABLE `bunuri`
  ADD CONSTRAINT `cod_proiect1` FOREIGN KEY (`cod_proiect`) REFERENCES `proiect` (`cod_proiect`);

--
-- Constrângeri pentru tabele `contramasuri`
--
ALTER TABLE `contramasuri`
  ADD CONSTRAINT `cod_risc` FOREIGN KEY (`cod_risc`) REFERENCES `riscuri` (`cod_risc`);

--
-- Constrângeri pentru tabele `organizatie`
--
ALTER TABLE `organizatie`
  ADD CONSTRAINT `cod_proiect` FOREIGN KEY (`cod_proiect`) REFERENCES `proiect` (`cod_proiect`);

--
-- Constrângeri pentru tabele `riscuri`
--
ALTER TABLE `riscuri`
  ADD CONSTRAINT `cod_bun1` FOREIGN KEY (`cod_bun`) REFERENCES `bunuri` (`cod_bun`);

--
-- Constrângeri pentru tabele `vulnerabilitati`
--
ALTER TABLE `vulnerabilitati`
  ADD CONSTRAINT `cod_bun2` FOREIGN KEY (`cod_bun`) REFERENCES `bunuri` (`cod_bun`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 03 mars 2021 à 15:50
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `campinghosnililian`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idcli` int(11) NOT NULL AUTO_INCREMENT,
  `nomcli` varchar(30) NOT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `cp` varchar(6) DEFAULT NULL,
  `ville` varchar(30) DEFAULT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `mail` varchar(30) DEFAULT NULL,
  `motpasse` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idcli`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`idcli`, `nomcli`, `adresse`, `cp`, `ville`, `telephone`, `mail`, `motpasse`) VALUES
(52, 'Manon Pinneau', '95, boulevard d\'Alsace', '92170', 'VANVES', '01.30.76.30.66', 'ManonPinneau@jourrapide.com', NULL),
(53, 'William Chauvin', '46, Avenue Millies Lacroix', '95600', 'EAUBONNE', '01.78.68.39.47', 'WilliamChauvin@dayrep.com', NULL),
(54, 'Tempeste Bélanger', '80, boulevard Aristide Briand', '71200', 'LE CREUSOT', '03.45.81.63.80', 'TempesteBelanger@teleworm.us', NULL),
(55, 'Maryse Lévesque', '4, rue de l\'Epeule', '92500', 'RUEIL-MALMAISON', '01.21.73.31.75', 'MaryseLevesque@jourrapide.com', NULL),
(56, 'Marine Tollmache', '46, Chemin Challet', '59000', 'LILLE', '03.31.12.47.47', 'MarineTollmache@rhyta.com', NULL),
(57, 'Coralie Lacharité', '7, boulevard Albin Durand', '95800', 'CERGY', '01.64.12.74.81', 'CoralieLacharite@dayrep.com', NULL),
(58, 'France Gamelin', '19, rue des Coudriers', '68100', 'MULHOUSE', '03.91.61.30.16', 'France@teleworm.us', NULL),
(59, 'Archard Louis', '40, rue Goya', '72100', 'LE MANS', '02.22.02.29.25', 'ArchardLouis@teleworm.us', NULL),
(60, 'Zurie CinqMars', '77, Avenue De Marlioz', '74100', 'ANNEMASSE', '04.20.80.57.07', 'ZurieCinqMars@rhyta.com', NULL),
(61, 'Amélie Clément', '85, Chemin Des Bateliers', '49100', 'ANGERS', '02.58.21.90.11', 'AmelieClement@teleworm.us', NULL),
(62, 'Pierrette Potvin', '46, place de Miremont', '94190', 'VILLENEUVE-SAINT-GEORGES', '01.28.29.59.71', 'PierrettePotvin@rhyta.com', NULL),
(63, 'Marmion Course', '79, rue Charles Corbeau', '91000', 'ÉVRY', '01.06.82.71.12', 'MarmionCourse@armyspy.com', NULL),
(64, 'Fantina LaGarde', '81, rue des Coudriers', '03000', 'MOULINS', '04.70.21.34.17', 'FantinaLaGarde@armyspy.com', NULL),
(65, 'Saber Patry', '35, rue Porte d\'Orange', '84200', 'CARPENTRAS', '04.56.70.13.51', 'SaberPatry@dayrep.com', NULL),
(66, 'Lotye Petit', '99, rue Victor Hugo', '59210', 'COUDEKERQUE-BRANCHE', '03.37.48.27.77', 'LotyePetit@teleworm.us', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `mobilhome`
--

DROP TABLE IF EXISTS `mobilhome`;
CREATE TABLE IF NOT EXISTS `mobilhome` (
  `idmob` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  `numemp` int(11) NOT NULL,
  `idtyp` int(11) NOT NULL,
  PRIMARY KEY (`idmob`),
  UNIQUE KEY `numemp` (`numemp`),
  KEY `idtyp` (`idtyp`)
) ENGINE=InnoDB AUTO_INCREMENT=8013 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `mobilhome`
--

INSERT INTO `mobilhome` (`idmob`, `nom`, `numemp`, `idtyp`) VALUES
(101, 'Van Gogh', 143, 11),
(102, 'Picasso', 163, 12),
(103, 'Monet', 144, 11),
(104, 'Cézanne', 159, 13),
(105, 'De Vinci', 149, 14),
(106, 'Manet', 162, 12),
(107, 'Degas', 145, 11),
(108, 'Dali', 158, 13),
(109, 'Rembrandt', 148, 14),
(110, 'Michel-Ange', 195, 19),
(111, 'Vermeer', 140, 19),
(112, 'Chagall', 114, 15),
(113, 'Courbet', 161, 12),
(114, 'Rubens', 146, 11),
(115, 'Boticelli', 110, 16),
(116, 'Raphaël', 113, 15),
(117, 'Kandinsky', 157, 13),
(118, 'Munch', 112, 15),
(119, 'Magritte', 139, 19),
(120, 'Goya', 138, 19),
(121, 'Miro', 109, 16),
(122, 'Pissaro', 156, 13),
(123, 'Seurat', 137, 18),
(124, 'Braque', 136, 18),
(125, 'Toulouse-Lautrec', 122, 17),
(126, 'Hopper', 155, 13),
(127, 'Warhol', 111, 15),
(128, 'Modigliani', 147, 11),
(129, 'Velasquez', 160, 12),
(130, 'Morisot', 196, 16),
(131, 'Ingres', 154, 13),
(132, 'Duchamp', 150, 14),
(133, 'Bacon', 151, 14),
(134, 'Brueghel', 121, 17),
(135, 'Bosch', 115, 19),
(136, 'Caillebotte', 135, 18),
(137, 'Cassat', 152, 14),
(138, 'Signac', 153, 13),
(139, 'David', 120, 17),
(140, 'Corrot', 116, 17),
(141, 'Wuhan', 174, 18);

-- --------------------------------------------------------

--
-- Structure de la table `photo`
--

DROP TABLE IF EXISTS `photo`;
CREATE TABLE IF NOT EXISTS `photo` (
  `idphoto` int(11) NOT NULL AUTO_INCREMENT,
  `nomfichier` varchar(30) NOT NULL,
  `idtyp` int(11) DEFAULT NULL,
  PRIMARY KEY (`idphoto`),
  KEY `idtyp` (`idtyp`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `photo`
--

INSERT INTO `photo` (`idphoto`, `nomfichier`, `idtyp`) VALUES
(1, '01001.png', 11),
(2, '01002.jpg', 11),
(3, '01003.jpg', 11),
(4, '01004.jpg', 11),
(5, '01005.jpg', 11),
(6, '02001.jpg', 12),
(7, '02002.jpg', 12),
(8, '02003.jpg', 12),
(9, '02004.jpg', 12),
(10, '02005.jpg', 12),
(11, '02006.jpg', 12),
(12, '03001.jpg', 13),
(13, '03002.jpg', 13),
(14, '03003.jpg', 13),
(15, '03004.jpg', 13),
(16, '04001.jpg', 14),
(17, '04002.jpg', 14),
(18, '04003.jpg', 14),
(19, '04004.jpg', 14),
(20, '04005.jpg', 14),
(21, '05001.jpg', 15),
(22, '05002.jpg', 15),
(23, '05003.jpg', 15),
(24, '05004.jpg', 15),
(25, '06001.jpg', 16),
(26, '06002.jpg', 16),
(27, '06003.jpg', 16),
(28, '06004.jpg', 16),
(29, '07001.jpg', 17),
(30, '07002.jpg', 17),
(31, '07003.jpg', 17),
(32, '07004.jpg', 17),
(33, '08001.png', 18),
(34, '08002.jpg', 18),
(35, '08003.jpg', 18),
(36, '08004.jpg', 18),
(37, '08005.jpg', 18),
(38, '09001.png', 19),
(39, '09002.jpg', 19),
(40, '09003.jpg', 19),
(41, '09004.jpg', 19);

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `idres` int(11) NOT NULL AUTO_INCREMENT,
  `dateres` date NOT NULL,
  `datedebut` date NOT NULL,
  `datefin` date NOT NULL,
  `regleon` tinyint(1) NOT NULL DEFAULT 0,
  `idmob` int(11) NOT NULL,
  `idcli` int(11) NOT NULL,
  PRIMARY KEY (`idres`),
  KEY `idmob` (`idmob`),
  KEY `idcli` (`idcli`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`idres`, `dateres`, `datedebut`, `datefin`, `regleon`, `idmob`, `idcli`) VALUES
(38, '2021-02-18', '2021-02-22', '2021-02-27', 0, 104, 52),
(40, '2021-02-18', '2021-02-24', '2021-02-28', 1, 139, 53),
(41, '2021-02-21', '2021-02-22', '2021-02-27', 1, 101, 52),
(42, '2021-02-21', '2021-02-22', '2021-02-27', 1, 103, 54),
(43, '2021-02-21', '2021-02-22', '2021-02-27', 0, 102, 55),
(44, '2021-02-21', '2021-02-22', '2021-02-26', 1, 113, 56),
(45, '2021-02-21', '2021-02-24', '2021-02-28', 0, 108, 57),
(46, '2021-02-21', '2021-02-25', '2021-02-27', 1, 117, 58),
(47, '2021-02-21', '2021-03-01', '2021-03-06', 0, 105, 59),
(48, '2021-02-21', '2021-03-02', '2021-03-07', 1, 112, 60),
(49, '2021-03-03', '2021-03-03', '2021-03-06', 1, 123, 62),
(50, '2021-03-03', '2021-03-04', '2021-03-08', 0, 124, 59),
(51, '2021-03-03', '2021-03-09', '2021-03-12', 1, 102, 60),
(52, '2021-03-03', '2021-03-17', '2021-03-21', 1, 105, 61),
(53, '2021-03-03', '2021-03-15', '2021-03-26', 1, 110, 53),
(54, '2021-03-03', '2021-03-25', '2021-03-28', 1, 125, 54);

-- --------------------------------------------------------

--
-- Structure de la table `typemobil`
--

DROP TABLE IF EXISTS `typemobil`;
CREATE TABLE IF NOT EXISTS `typemobil` (
  `idtyp` int(11) NOT NULL AUTO_INCREMENT,
  `libtyp` varchar(60) NOT NULL,
  `nbpers` int(11) DEFAULT NULL,
  `descripcourte` text DEFAULT NULL,
  `descriplongue` text DEFAULT NULL,
  `tarifsemaine` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtyp`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typemobil`
--

INSERT INTO `typemobil` (`idtyp`, `libtyp`, `nbpers`, `descripcourte`, `descriplongue`, `tarifsemaine`) VALUES
(11, 'SweetFlower sur Pilotis 5 personnes', 5, '43m2 dont terrasse semi-couverte 11m2 - 2 chambres  - Longueur 10 m / largeur 5,25 m', 'Pour les amoureux de la nature avec tout le confort : 2 chambres séparées avec chauffage, coin repas avec cuisine, grande terrasse sur pilotis. Le + : le coin douche, vasque et wc séparé et chauffage dans chaque pièce. Découvrez notre cabane eco pour le plaisir de toute la famille. N\'hésitez plus réservez.... 1 chambre avec un lit de 140x190, 1 chambre avec 2 lits de 80x190 et un lit superposé, chauffage dans chaque pièce, 5 couettes, 5 oreillers. Kitchenette équipée : frigo-congèle, 1 évier, plaque 4 feux, cafetière électrique, micro-onde, douche, vasque, WC, 1 salon de jardin (1 table + 6 chaises). , un kit vaisselle standard. TV inclus dans le tarif', 469),
(12, 'Eco-Lodge Sahari 5 personnes', 5, '2 chambres - Environ 34 m² dont Terrasse couverte. Longueur 7 m / largeur 4,25 m. Une autre façon de camper.', 'Pour les amoureux de la nature avec tout le confort : 2 chambres separees , coin repas avec cuisine, grande terrasse sur pilotis. Le + : le coin douche, vasque et wc. Découvrez notre tente eco pour le plaisir de toute la famille. N\'hésitez plus réservez.... 1 chambre avec un lit de 140x190, 1 chambre avec 2 lits de 80x190 et un lit superposé, 5 couvertures, 5 oreillers. Kitchenette équipée : petit frigo, 1 évier, plaque 2 feux, cafetière électrique, micro-onde, douche, vasque et WC, 1 salon de jardin (1 table + 6 chaises). , un kit vaisselle standard.', 399),
(13, 'Mobil-Home 2-3 personnes', 3, 'Environ 19 m² + Terrasse bois 7,50 m² Longueur 5,30 m / largeur 4 m', 'Un salon avec banquette en L équipé d’un lit tiroir (140 x 190). Une cuisine équipée, frigo, plaque 2 feux, cafetière électrique, micro-onde. Une grande chambre  lit 2 personnes 140 x 190. Salle de bain et douche, WC, 1 salon de jardin (1 table + 4 chaises),  3 oreillers, 2 couettes, kit vaisselle standard.', 343),
(14, 'Mobil-Home Confort 4 personnes', 4, 'Environ 29  m²  avec Terrasse semi-couverte. Longueur 7,62 m / largeur 4 m ', '1 grande chambre avec un lit de 140x190, 1 chambre avec 2 lits de 80x190, un grand séjour, coin repas et cuisine toute équipée : frigo-congélateur, plaque 4 feux, cafetière électrique, micro-onde, salle de bain et douche, WC, 1 salon de jardin (1 table + 4 chaises). 4 couvertures, 4 oreillers, un kit vaisselle standard + TV', 439),
(15, 'Mobil-Home Grand Confort 4-6 personnes', 6, 'Environ 29 m² avec Terrasse bois couverte de 11 m² Longueur 8,10 m / largeur 4 m', '1 grande chambre avec un lit de 140x190, 1 chambre avec 2 lits de 80x190, un grand séjour comprenant dans le salon 1 couchage (140x190), coin repas et cuisine tout équipée : frigo-congélateur, plaque 4 feux, cafetière électrique, micro-onde, TV, salle de bain et douche, WC, 1 salon de jardin (1 table + 6 chaises). 6 couvertures, 6 oreillers, un kit vaisselle standard.', 420),
(16, 'Mobil-Home Grand Confort 6 personnes', 6, 'Environ 31 m² + terrasse bois semi-couverte 11 m² Longueur 8,62 m / largeur 4 m', '1 grande chambre avec un lit de 140x190, 2 chambres avec 2 lits de 80x190, un grand séjour, coin repas et cuisine toute équipée : frigo-congélateur, plaque 4 feux, cafetière électrique, micro-onde, TV, salle de bain et douche, WC, 1 salon de jardin (1 table + 6 chaises). 6 couvertures, 6 oreillers, un kit vaisselle standard.', 525),
(17, 'Mobil-Home Luxe 6 personnes', 6, 'Environ 37 m² + terrasse bois semi-couverte 15 m² Longueur 8,62 m / largeur 4 m', '1 grande chambre avec un lit de 140x190, 2 chambre avec 2 lits de 80x190, un grand séjour, coin repas et cuisine toute équipée : frigo-congélateur, plaque 4 feux, four ou lave-vaisselle, cafetière électrique, micro-onde, salle de bain et douche, WC. 1 salon de jardin (1 table + 6 chaises) 2 Chiliennes. 5 couettes, 6 oreillers, un kit vaisselle standard. Volets roulants. TV inclus.', 553),
(18, 'Chalet 4-6 personnes', 6, 'Environ 34 m²  avec terrasse couverte + terrasse ext. Longueur 6,67 m / largeur 6,67 m', '1 grande chambre avec un lit de 140x190, 1 chambre avec 2 lits de 80x190, un grand séjour comprenant 1 couchage (140x190), coin repas et cuisine toute équipée : frigo-congélateur, plaque 4 feux, lave-vaisselle, cafetière électrique, micro-onde. Salle de bain et douche, WC. 1 salon de jardin (1 table + 6 chaises) 2 chiliennes. 6 couettes, 6 oreillers, un kit vaisselle standard. Volets roulants.', 420),
(19, 'Chalet 6 personnes', 6, 'Environ 34 m²  avec terrasse couverte + terrasse ext. Longueur 7,2 m / largeur 6,67 m', '1 grande chambre avec un lit de 140x190, 2 chambres avec 2 lits de 80x190, un grand séjour, coin repas et cuisine toute équipée : frigo-congélateur, plaque 4 feux, lave-vaisselle, cafetière électrique, micro-onde. Salle de bain et douche, WC. 1 salon de jardin (1 table + 6 chaises) 2 chiliennes. 5 couettes, 6 oreillers, un kit vaisselle standard. Volets roulants.', 462);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `mobilhome`
--
ALTER TABLE `mobilhome`
  ADD CONSTRAINT `mobilhome_ibfk_1` FOREIGN KEY (`idtyp`) REFERENCES `typemobil` (`idtyp`);

--
-- Contraintes pour la table `photo`
--
ALTER TABLE `photo`
  ADD CONSTRAINT `photo_ibfk_1` FOREIGN KEY (`idtyp`) REFERENCES `typemobil` (`idtyp`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`idmob`) REFERENCES `mobilhome` (`idmob`),
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`idcli`) REFERENCES `client` (`idcli`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

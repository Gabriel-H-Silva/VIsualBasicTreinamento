-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para sistema
CREATE DATABASE IF NOT EXISTS `sistema` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `sistema`;

-- Copiando estrutura para tabela sistema.permissoes
CREATE TABLE IF NOT EXISTS `permissoes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela sistema.permissoes: ~2 rows (aproximadamente)
INSERT INTO `permissoes` (`Id`, `Name`) VALUES
	(1, 'Administrador'),
	(2, 'Usuario');

-- Copiando estrutura para tabela sistema.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Gender` int(11) NOT NULL DEFAULT 0,
  `Email` varchar(60) NOT NULL,
  `Birth` varchar(60) DEFAULT '',
  `Adm_type` int(11) NOT NULL DEFAULT 2,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela sistema.usuarios: ~4 rows (aproximadamente)
INSERT INTO `usuarios` (`Id`, `FirstName`, `LastName`, `Gender`, `Email`, `Birth`, `Adm_type`) VALUES
	(11, 'Gabriel', 'Henrique de Oliveira Silva', 1, 'Gabriel@fliper.com', '04/12/2003 12:37:07', 2),
	(12, 'Usuario', 'pernad', 0, 'usuario@fliper.com', 'Usuario', 2),
	(13, 'usuario', 'novo', 1, 'teste@fliper.com', 'Usuario', 0),
	(14, 'Felipe', 'Santos', 1, 'felipenis@fliper.com', '12/01/2024 15:23:44', 1);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

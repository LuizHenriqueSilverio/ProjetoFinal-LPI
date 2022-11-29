-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.35-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para psf_luizedaiana
DROP DATABASE IF EXISTS `psf_luizedaiana`;
CREATE DATABASE IF NOT EXISTS `psf_luizedaiana` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `psf_luizedaiana`;

-- Copiando estrutura para tabela psf_luizedaiana.consultas
DROP TABLE IF EXISTS `consultas`;
CREATE TABLE IF NOT EXISTS `consultas` (
  `codCONSULTA` int(11) NOT NULL AUTO_INCREMENT,
  `dataHora` datetime NOT NULL,
  `motivo` varchar(200) NOT NULL,
  `MEDICOS_codMEDICOS` int(11) NOT NULL,
  `PACIENTES_codPACIENTES` int(11) NOT NULL,
  PRIMARY KEY (`codCONSULTA`,`MEDICOS_codMEDICOS`,`PACIENTES_codPACIENTES`),
  KEY `fk_CONSULTAS_MEDICOS_idx` (`MEDICOS_codMEDICOS`),
  KEY `fk_CONSULTAS_PACIENTES1_idx` (`PACIENTES_codPACIENTES`),
  CONSTRAINT `fk_CONSULTAS_MEDICOS` FOREIGN KEY (`MEDICOS_codMEDICOS`) REFERENCES `medicos` (`codMEDICOS`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CONSULTAS_PACIENTES1` FOREIGN KEY (`PACIENTES_codPACIENTES`) REFERENCES `pacientes` (`codPACIENTES`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela psf_luizedaiana.consultas: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` (`codCONSULTA`, `dataHora`, `motivo`, `MEDICOS_codMEDICOS`, `PACIENTES_codPACIENTES`) VALUES
	(21, '2022-11-25 07:30:00', 'Febre e dor de garganta', 1, 2);
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;

-- Copiando estrutura para tabela psf_luizedaiana.medicos
DROP TABLE IF EXISTS `medicos`;
CREATE TABLE IF NOT EXISTS `medicos` (
  `codMEDICOS` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `crm` varchar(45) NOT NULL,
  `especialidade` varchar(200) NOT NULL,
  PRIMARY KEY (`codMEDICOS`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela psf_luizedaiana.medicos: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `medicos` DISABLE KEYS */;
INSERT INTO `medicos` (`codMEDICOS`, `nome`, `crm`, `especialidade`) VALUES
	(1, 'Tekomo Nakama', '69420', 'Clínico Geral');
/*!40000 ALTER TABLE `medicos` ENABLE KEYS */;

-- Copiando estrutura para tabela psf_luizedaiana.pacientes
DROP TABLE IF EXISTS `pacientes`;
CREATE TABLE IF NOT EXISTS `pacientes` (
  `codPACIENTES` int(11) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(100) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `endereco` varchar(200) NOT NULL,
  PRIMARY KEY (`codPACIENTES`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela psf_luizedaiana.pacientes: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` (`codPACIENTES`, `cpf`, `nome`, `telefone`, `endereco`) VALUES
	(2, '123.456.789-10', 'Kabe Sadul Meup-al', '(35)99999-9999', 'Rua dos Bobos, Nº 0');
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;

-- Copiando estrutura para procedure psf_luizedaiana.proc_alteraConsulta
DROP PROCEDURE IF EXISTS `proc_alteraConsulta`;
DELIMITER //
CREATE PROCEDURE `proc_alteraConsulta`(IN dataHora DATETIME, IN motivo VARCHAR(200), IN Medicos_codMedicos INT, IN Pacientes_codPacientes INT, IN codCons INT)
BEGIN
	UPDATE `psf_luizedaiana`.`consultas`
	SET
	`dataHora` = dataHora,
	`motivo` = motivo,
	`MEDICOS_codMEDICOS` = Medicos_codMedicos,
	`PACIENTES_codPACIENTES` = Pacientes_codPacientes
	WHERE `codCONSULTA` = codCons;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_alteraMedico
DROP PROCEDURE IF EXISTS `proc_alteraMedico`;
DELIMITER //
CREATE PROCEDURE `proc_alteraMedico`(IN nome VARCHAR(100), IN crm VARCHAR(45), IN espMed VARCHAR(200),IN cod INT)
BEGIN
	UPDATE `psf_luizedaiana`.`medicos`
	SET
		`nome` = nome,
		`crm` = crm,
        `especialidade` = espMed
	WHERE `codMEDICOS` = cod;

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_alteraPaciente
DROP PROCEDURE IF EXISTS `proc_alteraPaciente`;
DELIMITER //
CREATE PROCEDURE `proc_alteraPaciente`(IN cpf VARCHAR(100), IN nome VARCHAR(200), IN telefone VARCHAR(45), IN endereco VARCHAR(200))
BEGIN
	UPDATE `psf_luizedaiana`.`pacientes`
	SET
		`cpf` = cpf,
		`nome` = nome,
		`telefone` = telefone,
		`endereco` = endereco
	WHERE `codPACIENTES` = cod;

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_alteraReceita
DROP PROCEDURE IF EXISTS `proc_alteraReceita`;
DELIMITER //
CREATE PROCEDURE `proc_alteraReceita`(IN meds VARCHAR(100), IN posologia VARCHAR(200), IN codConsulta INT, IN codMed INT, IN codPac INT, IN codRec INT)
BEGIN
	UPDATE `psf_luizedaiana`.`receitas`
	SET
	`medicamentos` = meds,
	`posologia` = posologia,
	`consultas_codCONSULTA` = codConsulta,
	`consultas_MEDICOS_codMEDICOS` = codMed,
	`consultas_PACIENTES_codPACIENTES` = codPac
	WHERE `codRECEITA` = codRec;

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_deletaConsulta
DROP PROCEDURE IF EXISTS `proc_deletaConsulta`;
DELIMITER //
CREATE PROCEDURE `proc_deletaConsulta`(IN codCons INT)
BEGIN
	DELETE FROM `psf_luizedaiana`.`consultas`
	WHERE `codCONSULTA` = codCons;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_deletaMedico
DROP PROCEDURE IF EXISTS `proc_deletaMedico`;
DELIMITER //
CREATE PROCEDURE `proc_deletaMedico`(IN codMed INT)
BEGIN
	DELETE FROM `psf_luizedaiana`.`medicos`
	WHERE codMedicos = codMed;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_deletaPaciente
DROP PROCEDURE IF EXISTS `proc_deletaPaciente`;
DELIMITER //
CREATE PROCEDURE `proc_deletaPaciente`(IN codPac INT)
BEGIN
	DELETE FROM `psf_luizedaiana`.`pacientes`
	WHERE codPacientes = codPac;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_deletaReceita
DROP PROCEDURE IF EXISTS `proc_deletaReceita`;
DELIMITER //
CREATE PROCEDURE `proc_deletaReceita`(IN codRec INT)
BEGIN
	DELETE FROM `psf_luizedaiana`.`receitas`
	WHERE `codRECEITA` = codRec;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_insereConsulta
DROP PROCEDURE IF EXISTS `proc_insereConsulta`;
DELIMITER //
CREATE PROCEDURE `proc_insereConsulta`(IN dataHora DATETIME, IN motivo VARCHAR(200), IN Medicos_codMedicos INT, IN Paciente_codPacientes INT)
BEGIN
	INSERT INTO `psf_luizedaiana`.`consultas`
	(
		`dataHora`,
		`motivo`,
		`MEDICOS_codMEDICOS`,
		`PACIENTES_codPACIENTES`)
	VALUES(
		dataHora,
		motivo,
		Medicos_codMedicos,
		Paciente_codPacientes
	);


END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_insereMedico
DROP PROCEDURE IF EXISTS `proc_insereMedico`;
DELIMITER //
CREATE PROCEDURE `proc_insereMedico`(IN nomeMed VARCHAR(100), IN crmMed VARCHAR(45), IN espMed VARCHAR(200))
BEGIN
	INSERT INTO `psf_luizedaiana`.`medicos`
	(
	`nome`,
	`crm`,
	`especialidade`
    )
	VALUES
	(
	nomeMed,
	crmMed,
	espMed
    );

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_inserePaciente
DROP PROCEDURE IF EXISTS `proc_inserePaciente`;
DELIMITER //
CREATE PROCEDURE `proc_inserePaciente`(IN cpfPaciente VARCHAR(100), 
										IN nomePaciente VARCHAR(100), 
                                        IN telefone VARCHAR(45), 
                                        IN endereco VARCHAR(100))
BEGIN
	INSERT INTO `psf_luizedaiana`.`pacientes`
	(
	`cpf`,
	`nome`,
	`telefone`,
	`endereco`)
	VALUES
	(
	cpfPaciente,
	nomePaciente,
	telefone,
	endereco
    );

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_insereReceita
DROP PROCEDURE IF EXISTS `proc_insereReceita`;
DELIMITER //
CREATE PROCEDURE `proc_insereReceita`(IN meds VARCHAR(100), IN posologia VARCHAR(200), IN codConsulta INT, IN codMed INT, IN codPac INT)
BEGIN
	INSERT INTO `psf_luizedaiana`.`receitas`
	(
	`medicamentos`,
	`posologia`,
	`consultas_codCONSULTA`,
	`consultas_MEDICOS_codMEDICOS`,
	`consultas_PACIENTES_codPACIENTES`)
	VALUES
	(
	meds,
	posologia,
	codConsulta,
	codMed,
	codPac
    );

END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaConsMed
DROP PROCEDURE IF EXISTS `proc_listaConsMed`;
DELIMITER //
CREATE PROCEDURE `proc_listaConsMed`(IN codMed INT)
BEGIN
	SELECT C.codConsulta AS 'Código',
		   date_format(C.dataHora, "%d/%m/%Y, %H:%i") AS 'Data e Hora',
           C.motivo AS 'Motivo',
           M.nome AS 'Nome do Médico',
           P.nome AS 'Nome do Paciente'
           FROM CONSULTA AS C
           INNER JOIN MEDICOS AS M
           INNER JOIN PACIENTES AS P
           ON C.MEDICOS_codMEDICOS = M.codMEDICOS
           AND C.PACIENTES_codPACIENTES = P.codPACIENTES
           WHERE M.codMEDICOS = codMed;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaConsPac
DROP PROCEDURE IF EXISTS `proc_listaConsPac`;
DELIMITER //
CREATE PROCEDURE `proc_listaConsPac`(IN codPac INT)
BEGIN
	SELECT C.codConsulta AS 'Código',
		   date_format(C.dataHora, "%d/%m/%Y, %H:%i") AS 'Data e Hora',
           C.motivo AS 'Motivo',
           M.nome AS 'Nome do Médico',
           P.nome AS 'Nome do Paciente'
           FROM CONSULTA AS C
           INNER JOIN MEDICOS AS M
           INNER JOIN PACIENTES AS P
           ON C.MEDICOS_codMEDICOS = M.codMEDICOS
           AND C.PACIENTES_codPACIENTES = P.codPACIENTES
           WHERE P.codPACIENTES = codPac;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaConsultas
DROP PROCEDURE IF EXISTS `proc_listaConsultas`;
DELIMITER //
CREATE PROCEDURE `proc_listaConsultas`()
BEGIN
	SELECT C.codConsulta AS 'Código',
		   date_format(C.dataHora, "%d/%m/%Y, %H:%i") AS 'Data e Hora',
           C.motivo AS 'Motivo',
           M.nome AS 'Nome do Médico',
           P.nome AS 'Nome do Paciente'
           FROM CONSULTAS AS C
           INNER JOIN MEDICOS AS M
           INNER JOIN PACIENTES AS P
           ON C.MEDICOS_codMEDICOS = M.codMEDICOS
           AND C.PACIENTES_codPACIENTES = P.codPACIENTES;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaMedicos
DROP PROCEDURE IF EXISTS `proc_listaMedicos`;
DELIMITER //
CREATE PROCEDURE `proc_listaMedicos`()
BEGIN
	SELECT *
	FROM `psf_luizedaiana`.`medicos`;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaPacientes
DROP PROCEDURE IF EXISTS `proc_listaPacientes`;
DELIMITER //
CREATE PROCEDURE `proc_listaPacientes`()
BEGIN
	SELECT *
	FROM `psf_luizedaiana`.`pacientes`;
END//
DELIMITER ;

-- Copiando estrutura para procedure psf_luizedaiana.proc_listaReceitas
DROP PROCEDURE IF EXISTS `proc_listaReceitas`;
DELIMITER //
CREATE PROCEDURE `proc_listaReceitas`()
BEGIN
	SELECT R.codReceita AS 'Código',
		   R.medicamento AS 'Medicamento(s)',
           R.posologia AS 'posologia',
           C.codConsulta AS 'Código da Consulta',
           M.nome AS 'Nome do médico',
           P.nome AS 'Nome do paciente'
           FROM RECEITAS AS R
           INNER JOIN CONSULTAS AS C
           INNER JOIN MEDICOS AS M
           INNER JOIN PACIENTES AS P
           ON R.consultas_codCONSULTA = C.codCONSULTA
           AND R.consultas_MEDICOS_codMEDICOS = M.codMEDICOS
           AND R.consultas_PACIENTES_codPACIENTES = P.codPACIENTES;
END//
DELIMITER ;

-- Copiando estrutura para tabela psf_luizedaiana.receitas
DROP TABLE IF EXISTS `receitas`;
CREATE TABLE IF NOT EXISTS `receitas` (
  `codRECEITA` int(11) NOT NULL AUTO_INCREMENT,
  `medicamentos` varchar(100) NOT NULL,
  `posologia` varchar(200) NOT NULL,
  `consultas_codCONSULTA` int(11) NOT NULL,
  `consultas_MEDICOS_codMEDICOS` int(11) NOT NULL,
  `consultas_PACIENTES_codPACIENTES` int(11) NOT NULL,
  PRIMARY KEY (`codRECEITA`,`consultas_codCONSULTA`,`consultas_MEDICOS_codMEDICOS`,`consultas_PACIENTES_codPACIENTES`),
  KEY `fk_receitas_consultas1_idx` (`consultas_codCONSULTA`,`consultas_MEDICOS_codMEDICOS`,`consultas_PACIENTES_codPACIENTES`),
  CONSTRAINT `fk_receitas_consultas1` FOREIGN KEY (`consultas_codCONSULTA`, `consultas_MEDICOS_codMEDICOS`, `consultas_PACIENTES_codPACIENTES`) REFERENCES `consultas` (`codCONSULTA`, `MEDICOS_codMEDICOS`, `PACIENTES_codPACIENTES`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela psf_luizedaiana.receitas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receitas` DISABLE KEYS */;
/*!40000 ALTER TABLE `receitas` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

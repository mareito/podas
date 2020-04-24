-- MySQL dump 10.13  Distrib 5.6.33, for Linux (x86_64)
--
-- Host: localhost    Database: c0180448_podas
-- ------------------------------------------------------
-- Server version	5.6.31-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `act_codigos3`
--

DROP TABLE IF EXISTS `act_codigos3`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `act_codigos3` (
  `codigo_interaseo` int(11) NOT NULL,
  `codigo_censo` int(11) NOT NULL,
  `direccion` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
  KEY `codigo_interaseo` (`codigo_interaseo`),
  KEY `codigo_censo` (`codigo_censo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `actualizaciones`
--

DROP TABLE IF EXISTS `actualizaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `actualizaciones` (
  `maestro` varchar(20) NOT NULL,
  `version` int(11) NOT NULL,
  PRIMARY KEY (`maestro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `archivos`
--

DROP TABLE IF EXISTS `archivos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `archivos` (
  `consecutivo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `contratista` int(11) NOT NULL,
  `cuadrilla` int(11) NOT NULL,
  `fechaini` date NOT NULL,
  `fechafin` date NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `totreg` int(11) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `ruta` varchar(200) NOT NULL,
  UNIQUE KEY `serial` (`consecutivo`),
  KEY `serial_2` (`consecutivo`),
  KEY `usuario` (`usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4614 DEFAULT CHARSET=utf8mb4 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `asi_detalle`
--

DROP TABLE IF EXISTS `asi_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `asi_detalle` (
  `asd_encabezado` int(11) NOT NULL,
  `asd_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `asd_codigo` int(11) NOT NULL,
  `asd_contratista` int(11) NOT NULL,
  `asd_cuadrilla` int(11) NOT NULL,
  `asd_intervencion` int(11) NOT NULL,
  `asd_catantes` int(11) NOT NULL,
  `asd_altantes` decimal(6,2) NOT NULL,
  `asd_diacantes` decimal(6,2) NOT NULL,
  `asd_dianantes` decimal(6,2) NOT NULL,
  `asd_catdespues` int(11) NOT NULL,
  `asd_altdesp` decimal(6,2) NOT NULL,
  `asd_diacdesp` decimal(6,2) NOT NULL,
  `asd_diandesp` decimal(6,2) NOT NULL,
  `asd_estfisico` varchar(1) NOT NULL,
  `asd_estfito` varchar(1) NOT NULL,
  `asd_volresi` decimal(5,2) NOT NULL,
  `asd_estado` varchar(1) NOT NULL,
  `asd_fechaejec` date NOT NULL,
  `asd_horaejec` varchar(8) NOT NULL,
  `asd_antes` varchar(250) NOT NULL,
  `asd_durante` varchar(250) NOT NULL,
  `asd_despues` varchar(250) NOT NULL,
  `asd_codobserva` int(11) NOT NULL,
  `asd_observacion` varchar(100) NOT NULL,
  `asd_radicado` int(11) NOT NULL,
  `asd_usuario` varchar(20) NOT NULL,
  `asd_fecha` date NOT NULL,
  `asd_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`asd_encabezado`,`asd_codigo`),
  UNIQUE KEY `asd_serial` (`asd_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=227786 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `asi_encabezado`
--

DROP TABLE IF EXISTS `asi_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `asi_encabezado` (
  `asi_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `asi_encprog` int(11) NOT NULL,
  `asi_detprog` int(11) NOT NULL,
  `asi_municipio` int(11) NOT NULL,
  `asi_localidad` int(11) NOT NULL,
  `asi_barrio` int(11) NOT NULL,
  `asi_totcenini` int(11) NOT NULL,
  `asi_totnocenini` int(11) NOT NULL,
  `asi_contratista` int(11) NOT NULL,
  `asi_cuadrilla` int(11) NOT NULL,
  `asi_totcenfin` int(11) NOT NULL,
  `asi_totnocenfin` int(11) NOT NULL,
  `asi_usuario` varchar(20) NOT NULL,
  `asi_fecha` date NOT NULL,
  `asi_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`asi_encprog`,`asi_detprog`,`asi_municipio`,`asi_localidad`,`asi_barrio`),
  UNIQUE KEY `asi_serial` (`asi_serial`),
  UNIQUE KEY `asi_encprog` (`asi_encprog`,`asi_detprog`,`asi_localidad`,`asi_barrio`),
  UNIQUE KEY `asi_encprog_2` (`asi_encprog`,`asi_detprog`,`asi_municipio`,`asi_localidad`,`asi_barrio`)
) ENGINE=InnoDB AUTO_INCREMENT=1817 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `asignaciones`
--

DROP TABLE IF EXISTS `asignaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `asignaciones` (
  `tercero` int(11) DEFAULT NULL,
  `arbol` int(11) DEFAULT NULL,
  `serial` int(11) DEFAULT NULL,
  KEY `idx_asig` (`arbol`),
  KEY `idx_asig2` (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `barrio`
--

DROP TABLE IF EXISTS `barrio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `barrio` (
  `bar_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `bar_descripcion` varchar(100) NOT NULL,
  `bar_municipio` int(11) NOT NULL,
  `bar_localidad` int(11) NOT NULL,
  `bar_estado` varchar(1) NOT NULL,
  `bar_usuario` varchar(20) NOT NULL,
  `bar_fecha` date NOT NULL,
  `bar_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`bar_municipio`,`bar_localidad`,`bar_codigo`),
  UNIQUE KEY `bar_codigo` (`bar_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=555 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cambio_est`
--

DROP TABLE IF EXISTS `cambio_est`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `cambio_est` (
  `cam_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `cam_codigo` int(11) NOT NULL,
  `cam_arbol` int(11) NOT NULL,
  `cam_fecha` date NOT NULL,
  `cam_estant` varchar(1) NOT NULL,
  `cam_estact` varchar(1) NOT NULL,
  `cam_observa` varchar(100) NOT NULL,
  `cam_usuario` varchar(10) NOT NULL,
  `cam_fecreg` date NOT NULL,
  `cam_horreg` varchar(8) NOT NULL,
  UNIQUE KEY `cam_serial` (`cam_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=49043 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `categoria` (
  `cat_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `cat_descripcion` varchar(30) NOT NULL,
  `cat_altmin` decimal(5,2) NOT NULL,
  `cat_altmax` decimal(5,2) NOT NULL,
  `cat_estado` varchar(1) NOT NULL,
  `cat_usuario` varchar(20) NOT NULL,
  `cat_fecha` date NOT NULL,
  `cat_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`cat_codigo`),
  UNIQUE KEY `cat_codigo` (`cat_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `ciudad` (
  `ciu_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `ciu_descripcion` varchar(20) NOT NULL,
  `ciu_estado` varchar(1) NOT NULL,
  `ciu_usuario` varchar(20) NOT NULL,
  `ciu_fecha` date NOT NULL,
  `ciu_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`ciu_codigo`),
  UNIQUE KEY `ciu_codigo` (`ciu_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `coords`
--

DROP TABLE IF EXISTS `coords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `coords` (
  `codigo` int(11) NOT NULL,
  `latitud` decimal(19,15) NOT NULL,
  `longitud` decimal(19,15) NOT NULL,
  KEY `idx_coord` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cuadrilla`
--

DROP TABLE IF EXISTS `cuadrilla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `cuadrilla` (
  `cua_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `cua_nombre` varchar(30) NOT NULL,
  `cua_tercero` int(11) NOT NULL,
  `cua_estado` varchar(1) NOT NULL,
  `cua_usuario` varchar(20) NOT NULL,
  `cua_fecha` date NOT NULL,
  `cua_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`cua_codigo`),
  UNIQUE KEY `cua_codigo` (`cua_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `emplazamiento`
--

DROP TABLE IF EXISTS `emplazamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `emplazamiento` (
  `emp_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `emp_descripcion` varchar(30) NOT NULL,
  `emp_estado` varchar(1) NOT NULL,
  `emp_usuario` varchar(20) NOT NULL,
  `emp_fecha` date NOT NULL,
  `emp_hora` varchar(6) NOT NULL,
  PRIMARY KEY (`emp_codigo`),
  UNIQUE KEY `emp_codigo` (`emp_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `especie`
--

DROP TABLE IF EXISTS `especie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `especie` (
  `esp_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `esp_nombre` varchar(100) NOT NULL,
  `esp_nomcient` varchar(100) NOT NULL,
  `esp_familia` int(11) NOT NULL,
  `esp_estado` varchar(1) NOT NULL,
  `esp_usuario` varchar(20) NOT NULL,
  `esp_fecha` date NOT NULL,
  `esp_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`esp_codigo`),
  UNIQUE KEY `esp_codigo` (`esp_codigo`),
  KEY `esp_codigo_2` (`esp_codigo`),
  KEY `esp_codigo_3` (`esp_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=1951 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `familia`
--

DROP TABLE IF EXISTS `familia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `familia` (
  `fam_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `fam_descripcion` varchar(100) NOT NULL,
  `fam_estado` varchar(1) NOT NULL,
  `fam_usureg` varchar(20) NOT NULL,
  `fam_fecreg` date NOT NULL,
  `fam_horreg` varchar(8) NOT NULL,
  UNIQUE KEY `fam_codigo` (`fam_codigo`),
  KEY `fam_codigo_2` (`fam_codigo`),
  KEY `fam_codigo_3` (`fam_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `intervencion`
--

DROP TABLE IF EXISTS `intervencion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `intervencion` (
  `int_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `int_descripcion` varchar(50) NOT NULL,
  `int_estado` varchar(1) NOT NULL,
  `int_usuario` varchar(20) NOT NULL,
  `int_fecha` date NOT NULL,
  `int_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`int_codigo`),
  UNIQUE KEY `int_codigo` (`int_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `inv_arboles`
--

DROP TABLE IF EXISTS `inv_arboles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `inv_arboles` (
  `ina_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `ina_municipio` varchar(3) NOT NULL,
  `ina_localidad` int(11) NOT NULL,
  `ina_barrio` int(11) NOT NULL,
  `ina_codigo` int(11) NOT NULL,
  `ina_codint` int(11) NOT NULL,
  `ina_familia` int(11) NOT NULL,
  `ina_especie` int(11) NOT NULL,
  `ina_categoria` int(11) NOT NULL,
  `ina_latitud` decimal(19,15) NOT NULL,
  `ina_longitud` decimal(19,15) NOT NULL,
  `ina_direccion` varchar(100) NOT NULL,
  `ina_emplazamiento` int(11) NOT NULL,
  `ina_estado` varchar(1) NOT NULL,
  `ina_usuario` varchar(20) NOT NULL,
  `ina_fecha` date NOT NULL,
  `ina_hora` varchar(8) CHARACTER SET latin1 NOT NULL,
  UNIQUE KEY `ina_serial` (`ina_serial`),
  KEY `ina_codigo` (`ina_codigo`),
  KEY `ina_codint` (`ina_codint`)
) ENGINE=InnoDB AUTO_INCREMENT=73540 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `inv_conflicto`
--

DROP TABLE IF EXISTS `inv_conflicto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `inv_conflicto` (
  `inc_codigo` int(11) NOT NULL,
  `inc_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `inc_redesele` varchar(1) NOT NULL,
  `inc_redeshid` varchar(1) NOT NULL,
  `inc_redesalc` varchar(1) NOT NULL,
  `inc_arboles` varchar(1) NOT NULL,
  `inc_estructuras` varchar(1) NOT NULL,
  `inc_infvial` varchar(1) NOT NULL,
  `inc_redestel` varchar(1) NOT NULL,
  `inc_redesgas` varchar(1) NOT NULL,
  `inc_alumbra` varchar(1) NOT NULL,
  `inc_usuario` varchar(20) NOT NULL,
  `inc_fecha` date NOT NULL,
  `inc_hora` varchar(8) NOT NULL,
  UNIQUE KEY `inc_serial` (`inc_serial`),
  KEY `inc_codigo` (`inc_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `inv_medidas`
--

DROP TABLE IF EXISTS `inv_medidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `inv_medidas` (
  `inm_codigo` int(11) NOT NULL,
  `inm_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `inm_emplazamiento` decimal(12,2) NOT NULL,
  `inm_alturafus` decimal(12,2) NOT NULL,
  `inm_alturatot` decimal(12,2) NOT NULL,
  `inm_diametroc` decimal(12,2) NOT NULL,
  `inm_diametron` decimal(12,2) NOT NULL,
  `inm_volumen` decimal(12,5) NOT NULL,
  `inm_usuario` varchar(20) NOT NULL,
  `inm_fecha` date NOT NULL,
  `inm_hora` varchar(8) NOT NULL,
  UNIQUE KEY `inm_serial` (`inm_serial`),
  KEY `inm_codigo` (`inm_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=78085 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `inv_medidas_2`
--

DROP TABLE IF EXISTS `inv_medidas_2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `inv_medidas_2` (
  `inm_codigo` int(11) NOT NULL,
  `inm_serial` int(11) NOT NULL,
  `inm_emplazamiento` decimal(12,2) NOT NULL,
  `inm_alturafus` decimal(12,2) NOT NULL,
  `inm_alturatot` decimal(12,2) NOT NULL,
  `inm_diametroc` decimal(12,2) NOT NULL,
  `inm_diametron` decimal(12,2) NOT NULL,
  `inm_volumen` decimal(12,5) NOT NULL,
  `inm_usuario` varchar(20) NOT NULL,
  `inm_fecha` date NOT NULL,
  `inm_hora` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `inv_riesgo`
--

DROP TABLE IF EXISTS `inv_riesgo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `inv_riesgo` (
  `inr_codigo` int(11) NOT NULL,
  `inr_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `inr_volcamiento` int(11) NOT NULL,
  `inr_caramas` int(11) NOT NULL,
  `inr_caelementos` int(11) NOT NULL,
  `inr_usuario` varchar(20) NOT NULL,
  `inr_fecha` date NOT NULL,
  `inr_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`inr_codigo`),
  UNIQUE KEY `inr_serial` (`inr_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `localidad`
--

DROP TABLE IF EXISTS `localidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `localidad` (
  `loc_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Codigo de la Localidad',
  `loc_descripcion` varchar(50) NOT NULL,
  `loc_estado` varchar(1) NOT NULL,
  `loc_municipio` int(11) NOT NULL,
  `loc_usuario` varchar(20) NOT NULL,
  `loc_fecha` date NOT NULL,
  `loc_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`loc_municipio`,`loc_codigo`),
  UNIQUE KEY `loc_codigo` (`loc_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `observacion`
--

DROP TABLE IF EXISTS `observacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `observacion` (
  `obs_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `obs_descripcion` varchar(50) NOT NULL,
  `obs_detalle` varchar(1) NOT NULL,
  `obs_estado` varchar(1) NOT NULL,
  `obs_usureg` varchar(20) NOT NULL,
  `obs_fechareg` date NOT NULL,
  `obs_horareg` varchar(8) NOT NULL,
  PRIMARY KEY (`obs_codigo`),
  UNIQUE KEY `obs_serial` (`obs_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pro_detalle`
--

DROP TABLE IF EXISTS `pro_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `pro_detalle` (
  `prd_encabezado` int(11) NOT NULL,
  `prd_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `prd_observacion` varchar(250) NOT NULL,
  `prd_fechaini` date NOT NULL,
  `prd_fechafin` date NOT NULL,
  `prd_estado` varchar(1) NOT NULL,
  `prd_usuario` varchar(20) NOT NULL,
  `prd_fecha` date NOT NULL,
  `prd_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`prd_serial`),
  UNIQUE KEY `prd_serial` (`prd_serial`),
  KEY `prd_encabezado` (`prd_encabezado`,`prd_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pro_encabezado`
--

DROP TABLE IF EXISTS `pro_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `pro_encabezado` (
  `pre_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `pre_observacion` varchar(250) NOT NULL,
  `pre_fechaini` date NOT NULL,
  `pre_fechafin` date NOT NULL,
  `pre_usuario` varchar(20) NOT NULL,
  `pre_fecha` date NOT NULL,
  `pre_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`pre_serial`),
  UNIQUE KEY `pre_serial` (`pre_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `prog_agosto`
--

DROP TABLE IF EXISTS `prog_agosto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `prog_agosto` (
  `codigo` int(11) NOT NULL,
  `contratista` int(11) NOT NULL,
  `serial` int(11) NOT NULL,
  KEY `codigo` (`codigo`),
  KEY `serial` (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `programacion`
--

DROP TABLE IF EXISTS `programacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `programacion` (
  `codigo` int(11) NOT NULL,
  `serial` int(11) NOT NULL,
  `contratista` int(11) NOT NULL,
  `comuna` int(11) NOT NULL,
  KEY `idx1` (`serial`),
  KEY `idx2` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rechazos`
--

DROP TABLE IF EXISTS `rechazos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `rechazos` (
  `rec_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `rec_arbol` int(11) NOT NULL,
  `rec_tercero` int(11) NOT NULL,
  `rec_fechanov` date NOT NULL,
  `rec_observa` varchar(100) NOT NULL,
  `rec_corregir` varchar(1) NOT NULL,
  `rec_inactivar` varchar(1) NOT NULL,
  `rec_usuario` varchar(20) NOT NULL,
  `rec_fecha` date NOT NULL,
  `rec_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`rec_serial`),
  UNIQUE KEY `rec_serial` (`rec_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=12169 DEFAULT CHARSET=utf8mb4 ROW_FORMAT=COMPACT;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `seriales`
--

DROP TABLE IF EXISTS `seriales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `seriales` (
  `serial` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tarifa`
--

DROP TABLE IF EXISTS `tarifa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `tarifa` (
  `tar_categoria` int(11) NOT NULL,
  `tar_serial` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `tar_fecinicio` date NOT NULL,
  `tar_fecfin` date NOT NULL,
  `tar_valor` decimal(14,2) NOT NULL,
  `tar_usuario` varchar(20) NOT NULL,
  `tar_fecha` date NOT NULL,
  `tar_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`tar_categoria`,`tar_serial`),
  UNIQUE KEY `tar_serial` (`tar_serial`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tercero`
--

DROP TABLE IF EXISTS `tercero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `tercero` (
  `ter_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `ter_nit` int(11) NOT NULL,
  `ter_nombre` varchar(50) NOT NULL,
  `ter_contacto` varchar(50) NOT NULL,
  `ter_direccion` varchar(100) NOT NULL,
  `ter_telefono` varchar(50) NOT NULL,
  `ter_correo` varchar(100) NOT NULL,
  `ter_estado` varchar(1) NOT NULL,
  `ter_usuario` varchar(20) NOT NULL,
  `ter_fecha` date NOT NULL,
  `ter_hora` varchar(8) NOT NULL,
  PRIMARY KEY (`ter_codigo`),
  UNIQUE KEY `ter_codigo` (`ter_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE IF NOT EXISTS `usuario` (
  `usu_login` varchar(15) NOT NULL COMMENT 'Login del usuario',
  `usu_codigo` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `usu_documento` bigint(20) NOT NULL COMMENT 'Nro Documento',
  `usu_nombre` varchar(50) NOT NULL COMMENT 'Nombre del Usuario',
  `usu_correo` varchar(100) NOT NULL COMMENT 'Correo del Usuario',
  `usu_clave` varchar(30) NOT NULL COMMENT 'Clave de Acceso',
  `usu_estado` varchar(1) NOT NULL COMMENT 'Estado del Usuario',
  `usu_perfil` varchar(10) NOT NULL COMMENT 'Perfil del Usuario',
  `usu_fechaCl` date NOT NULL COMMENT 'Vencimiento Clave',
  `usu_cambiacl` varchar(1) NOT NULL COMMENT 'Cambio Clave',
  `usu_token` varchar(49) NOT NULL,
  `usu_tipo` varchar(1) NOT NULL,
  `usu_empresa` int(11) NOT NULL,
  `usu_cuadrilla` int(11) NOT NULL,
  `usu_factura` varchar(1) NOT NULL,
  `usu_borrar` varchar(1) NOT NULL,
  `usu_inventario` varchar(1) NOT NULL,
  `usu_encriptacl` varchar(1) NOT NULL,
  `usu_clave2` varchar(60) NOT NULL,
  PRIMARY KEY (`usu_login`) USING BTREE,
  UNIQUE KEY `usu_codigo` (`usu_codigo`),
  UNIQUE KEY `idx_usu1` (`usu_documento`),
  UNIQUE KEY `usu_login` (`usu_login`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-05 22:59:34

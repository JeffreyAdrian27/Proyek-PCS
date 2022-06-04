/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.21-MariaDB : Database - db_proyekpcs
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_proyekpcs` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_proyekpcs`;

/*Table structure for table `alat_musik` */

DROP TABLE IF EXISTS `alat_musik`;

CREATE TABLE `alat_musik` (
  `id_alat_musik` varchar(5) NOT NULL,
  `nama_alat_musik` varchar(50) DEFAULT NULL,
  `id_jenis` varchar(10) DEFAULT NULL,
  `merek` varchar(25) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_alat_musik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `alat_musik` */

insert  into `alat_musik`(`id_alat_musik`,`nama_alat_musik`,`id_jenis`,`merek`,`stock`,`harga`) values 
('G001','GX18CE Acoustic Guitar','1','Takamine',5,4000000),
('G002','GY11ME Acoustic Natural','1','Takamine',4,4300000),
('G003','GN11MCE Acoustic Natura','1','Takamine',2,3500000),
('P001','ES520 Digital Piano, Black','2','Kawai',3,13600000),
('P002','LP-380 88-Key Digital Piano, Black','2','KORG ',4,12600000),
('P003','YDP-144B Digital Home Piano, Rosewod','2','Yamaha',2,10600000),
('P004','DGX-670 B Stage Piano + L300 B Stand','2','Yamaha',4,9500000);

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `id_customer` varchar(6) NOT NULL,
  `nama_customer` varchar(50) DEFAULT NULL,
  `jk_customer` varchar(2) DEFAULT NULL,
  `alamat_customer` varchar(150) DEFAULT NULL,
  `notelp_customer` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id_customer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `customer` */

insert  into `customer`(`id_customer`,`nama_customer`,`jk_customer`,`alamat_customer`,`notelp_customer`) values 
('001','Alexander Renaldi','L','dinoyo 77','087454521543'),
('002','Jeffrey Adrian','L','Ngaggel jaya 46','089756453210'),
('003','Albert Gunawan','L','Kejawan Putih 17','081789456144'),
('004','Lia Stefany','P','Kejawan Putih 17','089454785612'),
('005','Philia ','P','raya keputih indah 30','085797446542');

/*Table structure for table `dtrans` */

DROP TABLE IF EXISTS `dtrans`;

CREATE TABLE `dtrans` (
  `id_dt` int(11) NOT NULL,
  `nota_beli` varchar(10) DEFAULT NULL,
  `id_alat_musik` varchar(10) DEFAULT NULL,
  `harga_beli` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `id_ht` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_dt`),
  KEY `id_ht` (`id_ht`),
  CONSTRAINT `dtrans_ibfk_1` FOREIGN KEY (`id_ht`) REFERENCES `htrans` (`id_ht`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `dtrans` */

insert  into `dtrans`(`id_dt`,`nota_beli`,`id_alat_musik`,`harga_beli`,`quantity`,`id_ht`) values 
(1,'N001','G001',4000000,1,1),
(2,'N001','G002',4300000,1,1),
(3,'N002','G003',3500000,1,2);

/*Table structure for table `htrans` */

DROP TABLE IF EXISTS `htrans`;

CREATE TABLE `htrans` (
  `id_ht` int(11) NOT NULL,
  `nota_beli` varchar(10) DEFAULT NULL,
  `tgl_beli` date DEFAULT NULL,
  `id_karyawan` varchar(6) DEFAULT NULL,
  `id_customer` varchar(6) DEFAULT NULL,
  `subtotal_beli` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_ht`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `htrans` */

insert  into `htrans`(`id_ht`,`nota_beli`,`tgl_beli`,`id_karyawan`,`id_customer`,`subtotal_beli`) values 
(1,'N001','2022-06-04','a','002',8300000),
(2,'N002','2022-06-04','a','002',3500000);

/*Table structure for table `jenis_alat_musik` */

DROP TABLE IF EXISTS `jenis_alat_musik`;

CREATE TABLE `jenis_alat_musik` (
  `id_jenis` varchar(10) NOT NULL,
  `nama_jenis` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_jenis`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `jenis_alat_musik` */

insert  into `jenis_alat_musik`(`id_jenis`,`nama_jenis`) values 
('1','Guitar'),
('2','Piano');

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `id_karyawan` varchar(6) NOT NULL,
  `nama_karyawan` varchar(50) DEFAULT NULL,
  `jk_karyawan` varchar(2) DEFAULT NULL,
  `alamat_karyawan` varchar(50) DEFAULT NULL,
  `notelp_karyawan` varchar(13) DEFAULT NULL,
  `tgl_masuk` date DEFAULT NULL,
  `usname_karyawan` varchar(50) DEFAULT NULL,
  `pass_karyawan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `karyawan` */

insert  into `karyawan`(`id_karyawan`,`nama_karyawan`,`jk_karyawan`,`alamat_karyawan`,`notelp_karyawan`,`tgl_masuk`,`usname_karyawan`,`pass_karyawan`) values 
('a','a','L','a','432432432424',NULL,'a','a'),
('KN1','Annabelle Brooke','P','margomulyo 1','085156452165','2018-08-06','abke','a'),
('MM','Mulyono','L','Raya Tempurejo 3','082145648968','2019-06-03','mulz','mul'),
('TW','Tonny Wijono','L','Kedawung 22','081178974562','2018-10-13','tw12','twtw');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

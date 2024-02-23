CREATE DATABASE rumah_sakit_mitra_sehat;
USE rumah_sakit_mitra_sehat;
CREATE TABLE doctors
(
	fullname VARCHAR(16) NOT NULL
);

SELECT * FROM doctors;

ALTER TABLE `doctors` 
ADD `id` int NOT NULL FIRST;

ALTER TABLE `doctors`
ADD `nik` VARCHAR(16) NOT NULL AFTER `fullname`,
ADD `birth_date` DATE NOT NULL AFTER `nik`,
ADD `birth_place` VARCHAR(50) NOT NULL AFTER `birth_date`,
ADD `sex` ENUM('M','F') NOT NULL AFTER `birth_place`;
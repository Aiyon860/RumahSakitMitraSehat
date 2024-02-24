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

ALTER TABLE `doctors`
MODIFY COLUMN `NIK` BIGINT;

ALTER TABLE `doctors`
RENAME COLUMN `sex` to `gender`;

ALTER TABLE `doctors`
ADD `type_id` int NOT NULL AFTER `gender`;

ALTER TABLE `doctors`
MODIFY COLUMN `birth_place` text;

ALTER TABLE `doctors`
MODIFY COLUMN fullname VARCHAR(30),
RENAME COLUMN `nik` TO `NIK`;

ALTER TABLE `doctors`
MODIFY COLUMN `NIK` int;

ALTER TABLE `doctdoctorsors`
ADD PRIMARY KEY (`id`);

ALTER TABLE `doctors`
ADD FOREIGN KEY (`type_id`) REFERENCES doctor_types (`id`);

CREATE VIEW `doctor_list` AS
SELECT
	A.id AS `ID`,
    A.fullname AS `Nama Lengkap`,
    A.NIK AS `NIK`,
    A.birth_date AS `Tanggal Lahir`,
    A.birth_place AS `Tempat Lahir`,
    A.gender AS `Jenis Kelamin`,
    B.type AS `Spesialisasi`
FROM
	doctors A JOIN doctor_types B ON A.type_id = B.id;
    
INSERT INTO doctors (id, fullname, NIK, birth_date, birth_place, gender, type_id) 
VALUES (1, 'Dr. John Smith', 123456789, '1980-06-10', 'New York', 'M', 4),
	   (2, 'Dr. Emily Johnson', 987654321, '1975-09-20', 'Los Angeles', 'F', 2),
	   (3, 'Dr. Michael Brown', 456789012, '1985-03-15', 'Chicago', 'M', 1),
	   (4, 'Dr. Sarah Davis', 654321098, '1990-11-25', 'Houston', 'F', 3),
	   (5, 'Dr. David Wilson', 789012345, '1978-12-30', 'Miami', 'M', 7);



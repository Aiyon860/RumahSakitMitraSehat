CREATE TABLE `patients`
(
	`id` INT NOT NULL PRIMARY KEY,
    `fullname` VARCHAR(30) NOT NULL,
    `NIK` INT NOT NULL,
    `birth_date` DATE,
    `birth_place` TEXT,
    `gender` ENUM('M', 'F'),
    `occupation` VARCHAR(30)
);

SELECT * FROM `patients`doctor_list;

CREATE VIEW `patient_list` AS
SELECT
	id AS `ID`,
    fullname AS `Nama Lengkap`,
    NIK AS `NIK`,
    birth_date AS `Tanggal Lahir`,
    birth_place AS `Tempat Lahir`,
    gender AS `Jenis Kelamin`,
    occupation AS `Pekerjaan`
FROM
	patients;

ALTER TABLE `patients`
MODIFY COLUMN NIK BIGINT;
    
INSERT INTO `patients` (id, fullname, NIK, birth_date, birth_place, gender, occupation) 
VALUES (1, 'John Doe', 123456789, '1990-05-15', 'New York', 'M', 'Software Engineer'),
	   (2, 'Jane Smith', 987654321, '1995-10-20', 'Los Angeles', 'F', 'Data Scientist'),
	   (3, 'Michael Johnson', 456789012, '1988-03-08', 'Chicago', 'M', 'Teacher'),
	   (4, 'Emily Davis', 654321098, '1992-07-25', 'Houston', 'F', 'Doctor'),
	   (5, 'David Brown', 789012345, '1985-12-12', 'Miami', 'M', 'Artist');

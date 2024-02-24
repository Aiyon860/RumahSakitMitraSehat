CREATE TABLE doctor_types
(
	id_type INT NOT NULL PRIMARY KEY,
    type VARCHAR(30) NOT NULL
);

SELECT * FROM `doctor_types`;

ALTER TABLE `doctor_types`
RENAME COLUMN `id_type` TO `id`;

INSERT INTO `doctor_types` (id, type)
VALUES (1, "Umum"),
	   (2, "Gigi"),
       (3, "Anak"),
       (4, "Penyakit Dalam"),
       (5, "Saraf"),
       (6, "Kandungan dan Ginekologi"),
       (7, "Bedah"),
       (8, "Kulit dan Kelamin"),
       (9, "THT"),
       (10, "Mata");
       
DELETE FROM doctor_types;
CREATE TABLE medicines
(
	`id` INT NOT NULL PRIMARY KEY,
    `medicine_name` VARCHAR(30) NOT NULL,
    `indication` VARCHAR(30),
    `quantity` INT,
    `price` INT NOT NULL
);

SELECT * FROM medicines;doctors

CREATE VIEW `medicine_list` AS
SELECT
	id AS `ID`,
    medicine_name AS `Nama Obat`,
    indication AS `Indikasi`,
    quantity AS `Kuantitas`,
    price AS `Harga`
FROM
	medicines;
    
INSERT INTO medicines (id, medicine_name, indication, quantity, price) 
VALUES (1, 'Paracetamol', 'Fever and Pain', 100, 10000),
	   (2, 'Amoxicillin', 'Bacterial Infections', 50, 15000),
	   (3, 'Loratadine', 'Allergies', 30, 8000),
	   (4, 'Omeprazole', 'Acid Reflux', 40, 20000),
	   (5, 'Ibuprofen', 'Pain and Inflammation', 80, 12000),
	   (6, 'Aspirin', 'Pain and Fever', 120, 7000),
	   (7, 'Simvastatin', 'High Cholesterol', 60, 25000),
	   (8, 'Metformin', 'Type 2 Diabetes', 70, 18000),
	   (9, 'Atorvastatin', 'High Cholesterol', 55, 30000),
	   (10, 'Losartan', 'Hypertension', 65, 22000);

UPDATE medicines  
SET indication = "test"
WHERE id = 11;
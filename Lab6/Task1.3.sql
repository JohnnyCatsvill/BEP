SELECT 
	COUNT("hdd(Gb)")
FROM
	PC
WHERE
	"hdd(Gb)" =
	(SELECT
		MIN("hdd(Gb)")
	FROM
		PC);
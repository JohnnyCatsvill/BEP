SELECT
	title, last_name, first_name
FROM
	offer 
	JOIN customer ON offer.customer_id = customer.customer_id
	JOIN dvd ON offer.dvd_id = dvd.dvd_id
WHERE
	offer_date > '2020-01-01'
ORDER BY last_name ASC;
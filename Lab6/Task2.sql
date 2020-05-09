SELECT
	download_count, count(download_count) as user_count
FROM
	(SELECT
		count(user_id) as download_count
	FROM
		track_downloads
	WHERE
		download_time > "2010-11-18" AND download_time < "2010-11-20"
	GROUP BY
		user_id)
GROUP BY 
	download_count
	
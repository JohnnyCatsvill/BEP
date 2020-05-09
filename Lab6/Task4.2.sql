SELECT
	courses.name as student_courses
FROM
	students_on_courses
	JOIN students ON students_on_courses.student_id = students.id
	JOIN courses ON students_on_courses.course_id = courses.id
WHERE
	students.name = "Шаров Эдуард Борисович"
SELECT [NAME] + '(' + SUBSTRING([OCCUPATION], 1, 1) + ')' FROM [OCCUPATIONS] ORDER BY [NAME];
SELECT 'There are total ' + CAST(COUNT(*) AS VARCHAR(10)) + ' ' + LOWER([OCCUPATION]) + 's.' FROM [OCCUPATIONS] GROUP BY [OCCUPATION] ORDER BY COUNT(*);
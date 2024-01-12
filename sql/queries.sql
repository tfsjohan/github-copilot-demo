-- Path: sql/schema.sql

/* Create a query for the **Users** table that counts the number of logins
grouped by year and month,
sorted by date so the latest dates comes first.
Only include the top 100 rows.
*/

SELECT
    YEAR(last_login) AS year,
    MONTH(last_login) AS month,
    COUNT(*) AS logins
FROM Users
GROUP BY year, month
ORDER BY year DESC, month DESC
LIMIT 100;






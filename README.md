# Mindbox

SQL-запрос:

```
SELECT Products.Name, Categories.Name
From Products
LEFT JOIN Categories
ON Products.ID = Categories.ID
```

CREATE TABLE orders
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [customer_id] INT REFERENCES customers(id),
	[order_date] DATE NOT NULL,
	[total_price] NUMERIC NOT NULL
)

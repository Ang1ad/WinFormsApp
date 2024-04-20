CREATE TABLE customers
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [first_name] NCHAR(50) NOT NULL, 
    [last_name] NCHAR(50) NOT NULL, 
    [address] NTEXT NOT NULL, 
    [phone] NUMERIC NOT NULL
)

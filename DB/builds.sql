CREATE TABLE builds
(
	[Id] INT NOT NULL PRIMARY KEY,
	[order_id] INT REFERENCES orders(id),
	[catalog_id] INT REFERENCES catalogs(id),
	[build_type] TEXT NOT NULL,
	[stock] INT NOT NULL
)

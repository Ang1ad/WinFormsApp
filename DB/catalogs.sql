CREATE TABLE catalogs
(
	[Id] INT NOT NULL PRIMARY KEY,
	[catalog_name] NCHAR(50) NOT NULL,
	[component_id] INT REFERENCES components(id)
)

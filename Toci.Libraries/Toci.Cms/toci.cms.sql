drop table DataDefinition;

create table DataDefinition
(
	Id int identity primary key,
	TableName text,
	ColumnName text,
	Type text,
	Constraint8 text,
	Metadata text -- json ?
);


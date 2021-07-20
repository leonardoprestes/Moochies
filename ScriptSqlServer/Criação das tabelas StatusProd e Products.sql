Create table StatusProd(
	StatusId int primary key  Identity(1,1),
	Status varchar(20) not null
)

Create table Products(
	ProdId int primary key  Identity(1,1),
	ProdName varchar(50) not null,
	Price Float not null,
	Status int not null,
	DateReg Date not null,
	FOREIGN KEY(Status) REFERENCES StatusProd(StatusId)
)
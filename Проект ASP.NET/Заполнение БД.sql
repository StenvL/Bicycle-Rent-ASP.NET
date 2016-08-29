use BicycleRent

-- Автомобили.
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), 'Газель', 'A123AA');
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), 'Газель', 'В123ВВ');
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), 'Газель', 'Е123ЕЕ');
declare @car1 uniqueidentifier = (select primaryKey from Car where Number = 'A123AA');
declare @car2 uniqueidentifier = (select primaryKey from Car where Number = 'В123ВВ');
declare @car3 uniqueidentifier = (select primaryKey from Car where Number = 'Е123ЕЕ');

-- Сотрудники.
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), 'Директор', 'Петров Петр Петрович', 'М');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), 'Водитель', 'Иванов Иван Иванович', 'М');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), 'Водитель', 'Сидоров Сидор Сидорович', 'М');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), 'Менеджер', 'Николаев Николай Николаевич', 'М');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), 'Менеджер', 'Андреев Андрей Андреевич', 'М');
declare @emp1 uniqueidentifier = (select primaryKey from Employee where FullName = 'Петров Петр Петрович');
declare @emp2 uniqueidentifier = (select primaryKey from Employee where FullName = 'Иванов Иван Иванович');
declare @emp3 uniqueidentifier = (select primaryKey from Employee where FullName = 'Сидоров Сидор Сидорович');
declare @emp4 uniqueidentifier = (select primaryKey from Employee where FullName = 'Николаев Николай Николаевич');
declare @emp5 uniqueidentifier = (select primaryKey from Employee where FullName = 'Андреев Андрей Андреевич');

-- Клиенты.
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), 'Паспорт 1234 567835', 'Андреев Петр Николаевич', 'М');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), 'Паспорт 5634 234523', 'Петров Николай Андреевич', 'М');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), 'Паспорт 6543 132345', 'Некрасова Ольга Виктровна', 'Ж');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), 'Паспорт 1234 645234', 'Николаев Владимир Павлович', 'М');
declare @client1 uniqueidentifier = (select primaryKey from Client where FullName = 'Андреев Петр Николаевич');
declare @client2 uniqueidentifier = (select primaryKey from Client where FullName = 'Петров Николай Андреевич');
declare @client3 uniqueidentifier = (select primaryKey from Client where FullName = 'Некрасова Ольга Виктровна');
declare @client4 uniqueidentifier = (select primaryKey from Client where FullName = 'Николаев Владимир Павлович');

-- Точки проката.
insert into Point (primaryKey, Address) values (newid(), 'Пушкина 1');
insert into Point (primaryKey, Address) values (newid(), 'Екатерининская 2');
declare @point1 uniqueidentifier = (select primaryKey from Point where Address = 'Пушкина 1');
declare @point2 uniqueidentifier = (select primaryKey from Point where Address = 'Екатерининская 2');

-- Велосипеды.
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, IsFree)
	values(newid(), 1, 'Stels 1', 2.2, 'Горный', 'Исправен', 0);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 2, 'Forward 1', 3, 'Горный', 'Исправен', @point2, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 3, 'Stels 2', 1.8, 'Шоссейный', 'Неисправен', @point1, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 4, 'Forward 2', 2.3, 'Шоссейный', 'Неисправен', @point2, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, isFree)
	values(newid(), 5, 'Школьник', 1.2, 'Детский', 'Украден', null, null);
declare @bicycle1 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Stels 1');
declare @bicycle2 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Forward 1');
declare @bicycle3 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Stels 2');
declare @bicycle4 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Forward 2');
declare @bicycle5 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Школьник');

-- Сессии проката.
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '21.08.2016 15:28', '21.08.2016 16:28', 132, 0, 'Закрыта', @client1, @point1, @point1, @emp2, @emp2, @bicycle1);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '20.08.2016 12:15', '20.08.2016 13:01', 138, 0, 'Закрыта', @client2, @point2, @point2, @emp3, @emp3, @bicycle2);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '20.08.2016 19:10', '20.08.2016 21:15', 225, 50, 'Закрыта', @client3, @point1, @point2, @emp2, @emp3, @bicycle3);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '22.08.2016 10:12', '22.08.2016 13:00', 302.4, 0, 'Закрыта', @client4, @point2, @point1, @emp3, @emp2, @bicycle3);
insert into RentSession (primaryKey, StartDate, [State], Client, StartPoint, EmployeeGive, Bicycle)
	values (newid(), '23.08.2016 13:23', 'Открыта', @client1, @point1, @emp2, @bicycle1);

-- Сессии перевозок.
insert into TransportSession (primaryKey, StartDate, FinishDate, Car, StartPoint, EndPoint, Driver, State)
	values (newid(), '21.08.2016 15:28', '21.08.2016 16:28', @car1, @point1, @point2, @emp2, 'Закрыта');
insert into TransportSession (primaryKey, StartDate, FinishDate, Car, StartPoint, EndPoint, Driver, State)
	values (newid(), '25.08.2016 15:28', '25.08.2016 19:28', @car2, @point2, @point1, @emp2, 'Закрыта');
insert into TransportSession (primaryKey, StartDate, Car, StartPoint, Driver, State)
	values (newid(), '27.08.2016 14:12', @car1, @point1, @emp1, 'Открыта');
declare @transport1 uniqueidentifier = (select top 1 primaryKey from TransportSession where StartPoint = @point1);
declare @transport2 uniqueidentifier = (select primaryKey from TransportSession where StartPoint = @point2);
declare @transport3 uniqueidentifier = (select primaryKey from TransportSession where State = 'Открыта');

-- Список перевезенных велосипедов.
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle2, @transport1);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle4, @transport1);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle1, @transport2);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle3, @transport2);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle3, @transport3);

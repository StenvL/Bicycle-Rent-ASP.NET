use BicycleRent

-- ����������.
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), '������', 'A123AA');
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), '������', '�123��');
insert into Car (primaryKey, Model, Number) output inserted.primaryKey values (newid(), '������', '�123��');
declare @car1 uniqueidentifier = (select primaryKey from Car where Number = 'A123AA');
declare @car2 uniqueidentifier = (select primaryKey from Car where Number = '�123��');
declare @car3 uniqueidentifier = (select primaryKey from Car where Number = '�123��');

-- ����������.
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), '��������', '������ ���� ��������', '�');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), '��������', '������ ���� ��������', '�');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), '��������', '������� ����� ���������', '�');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), '��������', '�������� ������� ����������', '�');
insert into Employee (primaryKey, Position, FullName, Gender) 
	values (newid(), '��������', '������� ������ ���������', '�');
declare @emp1 uniqueidentifier = (select primaryKey from Employee where FullName = '������ ���� ��������');
declare @emp2 uniqueidentifier = (select primaryKey from Employee where FullName = '������ ���� ��������');
declare @emp3 uniqueidentifier = (select primaryKey from Employee where FullName = '������� ����� ���������');
declare @emp4 uniqueidentifier = (select primaryKey from Employee where FullName = '�������� ������� ����������');
declare @emp5 uniqueidentifier = (select primaryKey from Employee where FullName = '������� ������ ���������');

-- �������.
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), '������� 1234 567835', '������� ���� ����������', '�');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), '������� 5634 234523', '������ ������� ���������', '�');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), '������� 6543 132345', '��������� ����� ���������', '�');
insert into Client (primaryKey, DocData, FullName, Gender) 
	values (newid(), '������� 1234 645234', '�������� �������� ��������', '�');
declare @client1 uniqueidentifier = (select primaryKey from Client where FullName = '������� ���� ����������');
declare @client2 uniqueidentifier = (select primaryKey from Client where FullName = '������ ������� ���������');
declare @client3 uniqueidentifier = (select primaryKey from Client where FullName = '��������� ����� ���������');
declare @client4 uniqueidentifier = (select primaryKey from Client where FullName = '�������� �������� ��������');

-- ����� �������.
insert into Point (primaryKey, Address) values (newid(), '������� 1');
insert into Point (primaryKey, Address) values (newid(), '�������������� 2');
declare @point1 uniqueidentifier = (select primaryKey from Point where Address = '������� 1');
declare @point2 uniqueidentifier = (select primaryKey from Point where Address = '�������������� 2');

-- ����������.
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, IsFree)
	values(newid(), 1, 'Stels 1', 2.2, '������', '��������', 0);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 2, 'Forward 1', 3, '������', '��������', @point2, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 3, 'Stels 2', 1.8, '���������', '����������', @point1, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, IsFree)
	values(newid(), 4, 'Forward 2', 2.3, '���������', '����������', @point2, 1);
insert into Bicycle (primaryKey, Number, Model, CostPerMinute, Type, State, CurPoint, isFree)
	values(newid(), 5, '��������', 1.2, '�������', '�������', null, null);
declare @bicycle1 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Stels 1');
declare @bicycle2 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Forward 1');
declare @bicycle3 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Stels 2');
declare @bicycle4 uniqueidentifier = (select primaryKey from Bicycle where Model = 'Forward 2');
declare @bicycle5 uniqueidentifier = (select primaryKey from Bicycle where Model = '��������');

-- ������ �������.
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '21.08.2016 15:28', '21.08.2016 16:28', 132, 0, '�������', @client1, @point1, @point1, @emp2, @emp2, @bicycle1);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '20.08.2016 12:15', '20.08.2016 13:01', 138, 0, '�������', @client2, @point2, @point2, @emp3, @emp3, @bicycle2);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '20.08.2016 19:10', '20.08.2016 21:15', 225, 50, '�������', @client3, @point1, @point2, @emp2, @emp3, @bicycle3);
insert into RentSession (primaryKey, StartDate, FinishDate, Cost, Fine, [State], Client, StartPoint, EndPoint, EmployeeGive, EmployeeTake, Bicycle)
	values (newid(), '22.08.2016 10:12', '22.08.2016 13:00', 302.4, 0, '�������', @client4, @point2, @point1, @emp3, @emp2, @bicycle3);
insert into RentSession (primaryKey, StartDate, [State], Client, StartPoint, EmployeeGive, Bicycle)
	values (newid(), '23.08.2016 13:23', '�������', @client1, @point1, @emp2, @bicycle1);

-- ������ ���������.
insert into TransportSession (primaryKey, StartDate, FinishDate, Car, StartPoint, EndPoint, Driver, State)
	values (newid(), '21.08.2016 15:28', '21.08.2016 16:28', @car1, @point1, @point2, @emp2, '�������');
insert into TransportSession (primaryKey, StartDate, FinishDate, Car, StartPoint, EndPoint, Driver, State)
	values (newid(), '25.08.2016 15:28', '25.08.2016 19:28', @car2, @point2, @point1, @emp2, '�������');
insert into TransportSession (primaryKey, StartDate, Car, StartPoint, Driver, State)
	values (newid(), '27.08.2016 14:12', @car1, @point1, @emp1, '�������');
declare @transport1 uniqueidentifier = (select top 1 primaryKey from TransportSession where StartPoint = @point1);
declare @transport2 uniqueidentifier = (select primaryKey from TransportSession where StartPoint = @point2);
declare @transport3 uniqueidentifier = (select primaryKey from TransportSession where State = '�������');

-- ������ ������������ �����������.
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle2, @transport1);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle4, @transport1);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle1, @transport2);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle3, @transport2);
insert into TransportSessionString (primaryKey, Bicycle, TransportSession) values (newid(), @bicycle3, @transport3);

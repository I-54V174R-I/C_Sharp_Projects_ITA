use Norte
delete from zona where 1=1;
DBCC CHECKIDENT (zona, RESEED, 1);
DBCC CHECKIDENT (zona, RESEED, 0);
select * from zona;
insert into ZONA values('NORTE');
insert into ZONA values('CENTRO');
insert into ZONA values('SUR');

delete from ESTADO where 1=1;
DBCC CHECKIDENT (estado, RESEED, 1);
DBCC CHECKIDENT (estado, RESEED, 0);
select * from ESTADO;
insert into ESTADO valueS('Baja California', 1);
insert into ESTADO valueS('Baja California Sur', 1);
insert into ESTADO valueS('Chihuahua', 1);
insert into ESTADO valueS('Sinaloa', 1);
insert into ESTADO valueS('Sonora', 1);
insert into ESTADO valueS('Coahuila', 1);
insert into ESTADO valueS('Durango', 1);
insert into ESTADO valueS('Nuevo León', 1);
insert into ESTADO valueS('San Luis Potosí', 1);
insert into ESTADO valueS('Tamaulipas', 1);

delete from COLONIA where 1=1;
DBCC CHECKIDENT (colonia, RESEED, 1);
DBCC CHECKIDENT (colonia, RESEED, 0);
select * from COLONIA;
insert into COLONIA valueS('LOMAS DE CHAPULTEPEC', 1);
insert into COLONIA valueS('LOMAS DE REFORMA', 1);
insert into COLONIA valueS('DEL BOSQUE', 2);
insert into COLONIA valueS('PEDREGAL DE SANTA URSULA I', 2);
insert into COLONIA valueS('AJUSCO I', 3);
insert into COLONIA valueS('VISTAS DEL MAUREL', 3);
insert into COLONIA valueS('IGNACIO ZARAGOZA I', 4);
insert into COLONIA valueS('CENTRO', 4);
insert into COLONIA valueS('VALENTIN GOMEZ FARIAS', 5);
insert into COLONIA valueS('MORELOS', 5);
insert into COLONIA valueS('NICOLAS BRAVO', 6);
insert into COLONIA valueS('5 DE MAYO', 6);
insert into COLONIA valueS('PLUTARCO ELIAS CALLES', 7);
insert into COLONIA valueS('CAMPESTRE COYOACAN', 7);
insert into COLONIA valueS('JANITZIO', 8);
insert into COLONIA valueS('FELIPE ANGELES', 8);
insert into COLONIA valueS('AZTECA', 9);
insert into COLONIA valueS('ARTES GRAFICAS', 9);
insert into COLONIA valueS('CUATRO ARBOLES', 9);
insert into COLONIA valueS('EMILIANO ZAPATA', 10);
insert into COLONIA valueS('SAN FRANCISCO CULHUACAN', 10);
insert into COLONIA valueS('PARQUE SAN ANDRES', 11);
insert into COLONIA valueS('OLIMPICA', 11);

delete from CALLE where 1=1;
DBCC CHECKIDENT (calle, RESEED, 1);
DBCC CHECKIDENT (calle, RESEED, 0);
select * from CALLE;
insert into CALLE valueS('FEDERACION', 1);
insert into CALLE valueS('DE FUEGO', 2);
insert into CALLE valueS('MAGISTERIO', 3);
insert into CALLE valueS('EDISON', 4);
insert into CALLE valueS('VALENCIA', 5);
insert into CALLE valueS('LA BOLA', 6);
insert into CALLE valueS('FELIPE ANGELES', 7);
insert into CALLE valueS('DATIL', 8);
insert into CALLE valueS('VICENTE RIOS', 9);
insert into CALLE valueS('LA GUAIRA', 10);
insert into CALLE valueS('DE LA PAZ', 11);
insert into CALLE valueS('ELOTE', 12);
insert into CALLE valueS('VENUSTIANO CARRANZA', 13);
insert into CALLE valueS('MANUEL CERVANTES', 14);
insert into CALLE valueS('FELIPE LOPEZ', 15);
insert into CALLE valueS('SALVADOR ALVARADO', 16);
insert into CALLE valueS('MAGNESIO', 17);
insert into CALLE valueS('SAN MARCOS', 18);
insert into CALLE valueS('ELIGIO ANCONA', 19);
insert into CALLE valueS('SAN IGNACIO', 20);
insert into CALLE valueS('LA LUNA', 21);
insert into CALLE valueS('SALVADOR LIMA', 22);
insert into CALLE valueS('FISICOS', 23);








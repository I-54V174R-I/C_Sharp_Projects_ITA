use Sur
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
insert into ESTADO valueS('Campeche', 3);
insert into ESTADO valueS('Chiapas', 3);
insert into ESTADO valueS('Oaxaca', 3);
insert into ESTADO valueS('Quintana Roo', 3);
insert into ESTADO valueS('Tabasco', 3);
insert into ESTADO valueS('Veracruz', 3);
insert into ESTADO valueS('Yucat�n', 3);

delete from COLONIA where 1=1;
DBCC CHECKIDENT (colonia, RESEED, 1);
DBCC CHECKIDENT (colonia, RESEED, 0);
select * from COLONIA;
insert into COLONIA valueS('JARDINES EN LA MONTAA', 1);
insert into COLONIA valueS('JARDINES DEL AJUSCO', 1);
insert into COLONIA valueS('AYOCATITLA', 2);
insert into COLONIA valueS('ARBOLEDAS DEL SUR', 2);
insert into COLONIA valueS('LA ASUNCION', 3);
insert into COLONIA valueS('EX EJIDOS DE LA MAGDALENA MIXIH', 3);
insert into COLONIA valueS('SAN JUAN TLIHUACA', 4);
insert into COLONIA valueS('SAN BARTOLO CAHUALTONGO', 4);
insert into COLONIA valueS('PRESIDENTE MADERO', 5);
insert into COLONIA valueS('LIBERTAD', 5);
insert into COLONIA valueS('OLIVAR DEL CONDE 2DA SECCION I', 6);
insert into COLONIA valueS('OLIVAR DEL CONDE 1RA SECCION II', 6);
insert into COLONIA valueS('TABACALERA', 7);
insert into COLONIA valueS('RESIDENCIAL MARIA ISABEL', 7);

delete from CALLE where 1=1;
DBCC CHECKIDENT (calle, RESEED, 1);
DBCC CHECKIDENT (calle, RESEED, 0);
select * from CALLE;
insert into CALLE valueS('OBREGON', 1);
insert into CALLE valueS('QUIMICOS', 2);
insert into CALLE valueS('NATIVIDAD MACIAS', 3);
insert into CALLE valueS('WASHINGTON', 4);
insert into CALLE valueS('ZARAGOZA', 5);
insert into CALLE valueS('OSCAR MENDEZ', 6);
insert into CALLE valueS('QUERIDO MOHENO', 7);
insert into CALLE valueS('RAFAEL CASTRO', 8);
insert into CALLE valueS('NICOLAS ROMERO', 9);
insert into CALLE valueS('YUNQUE', 10);
insert into CALLE valueS('OTILIO GONZALES', 11);
insert into CALLE valueS('ZACARIAS RUBIO', 12);
insert into CALLE valueS('RAMON ALDAMA', 13);
insert into CALLE valueS('NUEVO MUNDO', 14);

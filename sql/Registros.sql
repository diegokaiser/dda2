----INGRESO DE DATOS------
------DISTRITO-----
------------------
use SistemaServicios
go
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LIMA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('ANCON')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ( N'ATE')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('BREÑA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CARABAYLLO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('COMAS')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CHACLACAYO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CHORRILLOS')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LA VICTORIA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LA MOLINA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LINCE')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LURIGANCHO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LURIN')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('MAGDALENA DEL MAR')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('MIRAFLORES')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PACHACAMAC')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PUEBLO LIBRE')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PUCUSANA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PUENTE PIEDRA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PUNTA HERMOSA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('PUNTA NEGRA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('RIMAC')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN BARTOLO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN ISIDRO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('BARRANCO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN MARTIN DE PORRES')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN MIGUEL')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SANTA MARIA DEL MAR')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SANTA ROSA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SANTIAGO DE SURCO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SURQUILLO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('VILLA MARIA DEL TRIUNFO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('JESUS MARIA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('INDEPENDENCIA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('EL AGUSTINO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN JUAN DE MIRAFLORES')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN JUAN DE LURIGANCHO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN LUIS')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CIENEGUILLA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SAN BORJA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('VILLA EL SALVADOR')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LOS OLIVOS')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SANTA ANITA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CALLAO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('BELLAVISTA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LA PUNTA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('CARMEN DE LA LEGUA-REYNOSO')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('LA PERLA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('VENTANILLA')
INSERT [dbo].tb_Distrito ( nombreDistrito) VALUES ('SURCO')

------TIPOCUENTA-----
------------------
INSERT INTO tb_TipoCuenta(nombre,precio) values('Basico',0),('Egresado',20),('Estandar',30),('Platino',40),('Dorada',50),('Ejecutiva',60),('Premiun',70)


------USUARIO-----
------------------

INSERT INTO tb_Usuario ( nombreUsuario ,apellidoUsuario ,contrasenaUsuario ,idDistrito   ,emailUsuario ,cellUsuario ,rankUsuario ,wspUsuario,ocupacionUsuario,idTipoCuenta) VALUES ('Josue','Flores Chalco' ,'123456' ,1   ,'yoshuai_i@hotmail.com' ,'957483456' ,5 ,'485846374','Developer',1) 
INSERT INTO tb_Usuario([nombreUsuario],[apellidoUsuario],[contrasenaUsuario],[idDistrito],[emailUsuario],[cellUsuario],[rankUsuario],[wspUsuario],[ocupacionUsuario],idTipoCuenta) VALUES('Beck Cervantes','Sykes','MHS28EUB8WN',46,'sed.pede@rutrumnonhendrerit.ca','16171215 9746',1,'16751229 1662','Operario de limpieza',1),('Tate Winters','Talley','WAF00MGF6VW',25,'consequat@loremtristiquealiquet.net','16720207 5235',1,'16741029 5930','Estilista',1),('Addison Alvarado','Malone','KRA40CIJ6KL',18,'ante.Maecenas@doloregestasrhoncus.com','16170712 1784',2,'16140529 1947','Panadero',1),('Garrison Holden','Reynolds','MOI86ZGC4HK',16,'elit@porttitor.co.uk','16620811 2240',2,'16730425 7418','Arquitecto',1),('Oleg Britt','Barnett','ENV16RLN3ZB',24,'laoreet.posuere@iaculisodioNam.net','16380716 9473',3,'16620829 4618','Obrero',1),('Seth Love','Velazquez','XVM13LUW5KB',8,'parturient.montes@iaculislacus.co.uk','16330321 8097',4,'16170611 8112','Jardinero',1),('Maxwell Calhoun','Woodward','BVC90LSW0ZO',1,'non.vestibulum.nec@blandit.org','16030508 6423',5,'16741026 7632','Traductor',1),('Clark Mercado','Buckley','COR98XYR6TL',4,'neque@commodo.com','16290601 2014',4,'16440419 7024','Obrero',1),('August Holden','Sharp','BBU19ADD7FV',10,'diam@sagittisaugue.com','16980530 6405',5,'16110714 4634','Electricista',1),('Alvin Pruitt','Fischer','AUT87TKV5EW',4,'erat@arcu.edu','16860618 3062',1,'16790924 0421','Electricista',1);
INSERT INTO tb_Usuario([nombreUsuario],[apellidoUsuario],[contrasenaUsuario],[idDistrito],[emailUsuario],[cellUsuario],[rankUsuario],[wspUsuario],[ocupacionUsuario],idTipoCuenta) VALUES('Emmanuel Shelton','Shaw','DUN69CUA3GZ',39,'purus@at.edu','16561101 4845',2,'16680621 4976','Diseñador grafico',1),('Hamilton Lawson','Johnston','YXN07TAW0JI',45,'nostra@nunc.co.uk','16150210 2302',3,'16590319 3372','Arquitecto',1),('Calvin Love','Terrell','ATR25CSF2DQ',43,'quis.lectus@elitEtiam.org','16120120 8780',2,'16081001 5487','Arquitecto',1),('Elijah Hughes','Bowen','GHI48DRT7OE',10,'Pellentesque@aultriciesadipiscing.ca','16961230 6341',5,'16120316 0435','Dentista',1),('Cadman Lang','Snyder','JFB57CEH0KE',17,'molestie.tellus@Nullaeu.net','16950315 3679',5,'16700230 0916','Jardinero',1),('Malachi Velez','Sheppard','SQZ84NHY8ZE',13,'aliquet@risus.ca','16990205 3645',3,'16870318 4674','Cocinero',1),('Cody Roman','Love','YJB52XOR2BX',27,'dis.parturient.montes@felis.edu','16240202 6500',4,'16050115 9669','Arquitecto',1),('Ivor Bush','Rogers','XUZ28FOJ8JP',28,'vitae@in.co.uk','16910712 2070',3,'16290120 4384','Arquitecto',1),('Oscar Velasquez','Glass','BCF41JRB5OX',30,'ultrices@vitaesodales.ca','16211016 9410',2,'16651114 9681','Dentista',1),('Merrill Humphrey','Mccullough','OLV24MZA6XP',26,'et.netus@incursus.net','16740414 1298',1,'16031113 9745','Traductor',1);

-----USUARIO UPDATE DE TIPOS DE USUARIO==== (POR DEFECTO SON 1)
update tb_Usuario 
set tipoUsuario =2 where idUsuario>8
update tb_Usuario 
set tipoUsuario =3 where idUsuario>15



------CATEGORIA-----
------------------

INSERT INTO tb_Categoria (nombreCategoria) VALUES('Medicina'),('Abogacia'),('Ingenieria'),('Carpinteria'),('Electronica'),('Administracion'),('Educacion'),('Periodismo'),
												('Informatica'),('Musica'),('Economia'),('Cosmetologia'),('Traduccion'),('Diseño'),('Animacion'),('Jardineria'),('Cocina'),
												('Fotografia'),('Veterinaria'),('Seguridad')


------SUBCATEGORIA-----
------------------

INSERT INTO tb_subCategoria (idCategoria,nombreSubCategoria) values(1,'Cardeologia'),(1,'Podologia'),(1,'Odontologia'),(1,'Neumologia'),(1,'Pediatria'),(1,'Psicologia'),
																(2,'Derecho empresarial'),(2,'Derecho Penal'),(3,'Derecho tributario'),(3,'sistemas'),(3,'Minas'),(3,'Mecanica'),
																(3,'Industrial'),(3,'Quimica'),(4,'Cardeologia'),(5,'Interiores'),(1,'Domestico'),(1,'Exteriores'),(7,'Reposteria'),
																(1,'Gourmet'),(1,'Tradicional')
------POST-----
------------------

INSERT INTO tb_Post (idUsuario,idSubcategoria,idDistrito,tituloPost) values(1,1,5,'Se busca cardeologo con 3 años exp'),
												(2,2,8,'Se busca podologo con 6 años exp'), (3,3,9,'Se busca odontolo con 4 años exp'), 
												(4,4,32,'Se busca neumologo con 1 años exp'), (5,5,50,'Se busca pediatra con 2 años exp'), 
												(6,6,14,'Se busca Psicologo con 2 años exp'), (7,7,30,'Se busca abogado empresaria'), 
												(8,8,31,'Se busca abogado con 1 años exp'), (9,9,32,'Se busca abogado tributario con 2 años exp'), 
												(10,10,47,'Se busca experto en sistemas con 3 años exp'), (11,11,20,'Se busca Ingeniero de minas con 3 años exp'), 
												(12,12,16,'Se busca Mecanico '), (13,13,15,'Se busca Ing industrial con 3 años exp'), 
												(14,14,3,'Se busca Quimico  con 1 años exp'), (15,15,5,'Se busca Cardealogo con 1 años exp'), 
												(16,16,2,'Se busca Diseñador de interiores con 3 años exp'), (17,17,18,'Se busca Doctor domestico '), 
												(18,18,1,'Se busca Diseñador de exteriores con 2 años exp'), (19,19,33,'Se busca Repostero '), 
												(20,20,27,'Se busca Cocinero Gourmet ')

------SERVICIO-----
------------------

INSERT INTO tb_Servicio (idPost,idUsuario) values(1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15),
										(16,16),(17,17),(18,18),(19,19),(20,20)

------TESTIMONIO-----
------------------

INSERT INTO tb_Testimonio (idUsuario,idPost,tituloTestimonio,descripcionTestimonio) values(1,20,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(2,19,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(3,18,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(4,17,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(5,16,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(6,15,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(7,14,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(8,13,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(9,12,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(10,11,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(11,10,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(12,9,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(13,8,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(14,7,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(15,6,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),
										(16,5,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(17,4,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(18,3,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(19,2,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias'),(20,1,'Buen servicio, recomendado', 'Una persona que sabe lo que hace, excelentes referencias')

------REPLICA-----
------------------

INSERT INTO tb_Replica (idUsuario,idTestimonio,tituloReplica,descripcionReplica) values(1,1,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(2,2,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(3,3,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(4,4,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(5,5,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(6,6,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(7,7,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(8,8,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(9,9,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(10,10,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(11,11,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(12,12,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(13,13,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(14,14,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(15,15,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),
										(16,16,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(17,17,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(18,18,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(19,19,'Estoy de acuerdo ', 'Asi es, una persona muy profesional'),(20,20,'Estoy de acuerdo ', 'Asi es, una persona muy profesional')









--EJECUTAR CONSULTAS
select * from tb_Distrito
select * from tb_Usuario
select * from tb_Categoria
select * from tb_SubCategoria
select * from tb_Post
select * from tb_Servicio
select * from tb_Testimonio
select * from tb_Replica
select * from tb_TipoCuenta

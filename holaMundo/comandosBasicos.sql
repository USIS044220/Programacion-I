
select nombre, email from clientes where email like '%ugb%'

insert into clientes (codigo,nombre,direccion,telefono,email) values ('004', 'Miguel Hernandez','Usulutan','2323-2323','oscar@ugb.edu.sv')

delete from clientes where idCliente=3

update clientes set codigo='003', nombre='Jorge Hernandez', telefono='4512-4545', email='jorge@ugb.edu.sv' where idCliente=4

update clientes set email='luishernandez@ugb.edu.sv' where idCliente=2

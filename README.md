# Propuesta Solución TgJobsApi
### Requisitos Principales
* Respecto al **cambio de arquitectura usando el patrón que más suelas usar**.
* He procedido ha realizar cambios en el proyecto con el fin de adecuarlo a una arquitectura multicapa orientada a dominio, el porque de esta decisión es la 
* de dotar de tener una mejor capacidad de respuesta y rendimiento conforme se vayan añadiendo nuevos módulos. 
* Además nos permite tener una mejor separación jerárquica entre las diferentes capas inherentes al proyecto como son los de Aplicación, Dominio(Negocio) y Acceso a Datos.

*Respecto a la solución de **estos ejercicios mediante el uso de LINQ tanto como sea posible**.

### Ejercicio 1
Para obtener el producto más vendido se ha implementado a travez de linq una query que recorra todas las ventas y agrupe por el id del producto para obtener el Id en
el que exista en más ventas.

### Ejercicio 2
Se ha implementado a travez de linq una query que consulte todos los clientes asociados a alguna venta con su respectivo productos 

### Ejercicio 3
Ejercio no completado.

### Ejercicio 4
Para evitar inicializar la variable Total en el constructor, se ha añadido nueva variable privada dentro de la clase para que a travez del método get del Total
en el se vayan sumando los precios de los prodcutos.

### Ejercicio 5
Se ha completado el método GetCustomerAsync para obtener un customer por su Id de forma asincrona y para ello se ha añadio un Delay(1000) que permita 
esperar la respuesta de la tarea en la capa de datos.







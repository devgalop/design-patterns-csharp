# Singleton

El patrón de diseño *Singleton* se asegura de que una clase sea instanciada una sola vez y provee un acceso global a esta instancia.

Este patrón de diseño se suele utilizar en los siguientes casos:
- Se requiere centralizar el control 
- Cuando se requiera que una instancia pueda ser accedida desde cualquier punto del código.
- Cuando se requiere una instancia global para todos los clientes.
- Cuando se necesite ser estricto con el control de variables gloabales.

## Componentes del patron **Singleton**

- **Singleton**: Para implementar este patrón, se deben tener en cuenta las siguientes reglas: constructur privado, un campo estático para almacenar la clase, un metodo estático para retonar la instancia.

![singleton_components](resources/singleton_components.drawio.png)

## Ejemplo Aplicado

Para efectos de ejemplo, se creará un problema ficticio el cual se resolverá a través del uso de *Singleton*

## Problema:

Se necesita mantener la conexión a la base de datos desde todos los puntos del código.

## Solucion:

Se crea la clase *Database* utilizando el patrón *¨singleton* con un constructor privado, un objeto estatico con la conexión y un metodo estático para acceder a la conexión.

![arq_singleton](resources/arq_singleton.drawio.png)

Si desea conocer o profundizar más, dirijase a las fuentes

- [Refactoring Guru](https://refactoring.guru/design-patterns/singleton).
- [Geek for Geeks](https://www.geekforgeeks.org/system-design/singleton-design-pattern)
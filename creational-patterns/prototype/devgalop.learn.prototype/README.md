# Prototype

El patrón de diseño *Prototype* permite la creacion de objetos a partir de un objeto previamente existente. Es decir, realizar una copia del objeto sin hacer el codigo dependiente de las clases.

Este patrón permite ocultar al cliente toda la complejidad de crear nuevas instancias de un objeto.

Este patrón de diseño suele utilizarce en los siguientes escenarios:
- Cuando los tiempos o costos de creación de un objeto son altos.
- Cuando no se desea hacer el código dependiente de las clases que se van a copiar
- Cuando se requiere copiar un objeto muy complejo con configuraciones previas.

## Componentes del patron **Prototype**

- **Prototype Interface**: Esta es la *interface* que contiene el método *clone* con el cual se realizarán las copias de los objetos. 
- **Concrete Prototype**: Esta clase es la que implementa la *interface* y sobreescribe el metodo *clone*.

![prototype_components](resources/prototype_components.drawio.png)

## Ejemplo Aplicado

Para efectos de ejemplo, se creará un problema ficticio el cual se resolverá a través del uso de *Prototype*

## Problema:

Un sistema requiere matricular un empleado en diferentes plataformas por lo que necesita que una vez instanciado, este se pueda copiar multiples veces para mantener su información integra.

## Solucion:

Utilizando el patrón *Prototype* se creó una *interface* llamada *IEmployee* la cual contiene un método hábilitado para la clonación de los empleados. Con la ayuda de la clase *ConcreteEmployee* se crea una instancia y a partir de esta se puede invocar multiples veces la clonación de dicho objeto.

![arq_prototype](resources/arq_prototype.drawio.png)

Si desea conocer o profundizar más, dirijase a las fuentes

- [Refactoring Guru](https://refactoring.guru/design-patterns/prototype).
- [Geek for Geeks](https://www.geekforgeeks.org/system-design/prototype-design-pattern)
# Adapter

El patrón de diseño *adapter* nos permite la colaboración entre objetos que no tienen una *interface* compatible.

Este patrón se suele utilizar en los siguientes escenarios:
- Cuando se requiere utilizar código existente pero las interfaces no son compatibles con el resto del código.
- Cuando se necesite utilizar subclases que no pueden ser agregadas en una superclase.
- Cuando necesitas implementar librerias existentes que son incompatibles con tu codigo.
- Cuando el proyecto crece, el patrón permite agregar este nuevo codigo sin afectar el existente.

## Componentes del patron **Adapter**

- **Target Interface**: Define la *interface* con la que el cliente va interactuar.
- **Adaptee**: Clase existente que es incompatible con el código actual.
- **Adapter**: El adaptador implementa la *interface* e internamente genera una instancia de la clase *Adaptee* para hacerla compatible con la *interface*.

![adapter_components](resources/adapter_components.drawio.png)

## Ejemplo Aplicado

Para efectos de ejemplo, se creará un problema ficticio el cual se resolverá a través del uso de *Adapter*

## Problema:

En una aplicación encargada de leer archivos, se tiene que todos los escenarios previstos al momento de desarrollar la aplicacion eran lecturas linea a linea, sin embargo, se necesita agregar la funcionalidad de poder leer multiples lineas.

## Solucion:

Usando el patrón *Adapter* se creo la clase *MultipleLinesAdapter* con la cual se creo la compatibilidad entre la *interface IFileReader* y la clase *MultipleLinesReader*

![arq_adapter](resources/arq_adapter.drawio.png)

Si desea conocer o profundizar más, dirijase a las fuentes

- [Refactoring Guru](https://refactoring.guru/design-patterns/adapter).
- [Geek for Geeks](https://www.geeksforgeeks.org/system-design/adapter-pattern/)
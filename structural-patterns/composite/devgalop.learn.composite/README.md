# Composite

El patrón de diseño *Composite* permite componer objetos dentro de estructuras de arboles y trabajar con cada objeto de manera individual.

**NOTA**: Este patron solo es aplicable a modelos que se puedan representar como un *árbol*

El concepto principal es que se puede manipular una sola instancia del objeto de la misma manera que se puede manipular un grupo de instancias.

## Componentes del patron **Composite**

- **Component**: El componente declara la *interface* para los objetos en la composicion. También permite acceder y administrar los componentes hijos.

- **Leaf**: Define el comportamiento para los objetos primitivos dentro de la composicion. Este es la implementacion base de la composicion. Representa la implementación de la *interface* *Component*.

- **Composite**: Almacena los componentes hijos e implementa las operaciones entre los hijos. Los hijos pueden ser *Leaf* u otros *Composite* 

![composite_components](resources/composite_components.drawio.png)

## Ejemplo Aplicado

Para efectos de ejemplo, se creará un problema ficticio el cual se resolverá a través del uso de *Composite*

## Problema:

Se necesita crear una aplicación que permita leer archivos dentro de un sistema.

## Solucion:

Se crea como *Component* la clase *IFile* la cual tiene un método dedicado a la lectura de los archivos. 

Se crean como *Leaf* dos tipos de clases *CsvFile* y *JsonFile* las cuales nos permiten leer dos tipos de archivos diferentes.

Se crea como *Composite* la clase *Folder* la cual permite agrupar archivos o nuevas carpetas con archivos dentro.

![arq_composite](resources/arq_composite.drawio.png)

Si desea conocer o profundizar más, dirijase a las fuentes

- [Refactoring Guru](https://refactoring.guru/design-patterns/composite).
- [Geek for Geeks](https://www.geeksforgeeks.org/java/composite-design-pattern-in-java/)
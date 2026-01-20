# Patrones Creacionales

Los patrones de diseño creacionales proveen mecanismos para la creación de objetos, de manera que, el código sea fuertemente dependiente de estos. De esta manera se obtiene un código abierto a nuevas implementaciones. [según Refactoring  Guru](https://refactoring.guru/design-patterns/creational-patterns).

Estos patrones creacionales se encarga de desacoplar el sistema de la creación de los objetos, es decir, el sistema es independiente a cómo se crean los objetos, cómo se componen y cómo se representan [según Geek for Geeks](https://www.geeksforgeeks.org/system-design/software-design-patterns/#creational-design-patterns).

## Clasificación

A continuación se desarrollan para cada uno de los patrones creacionales los siguientes items:

- Definición
- ¿Cuándo usar este patrón?
- ¿Cuales son sus componentes?
- Diagrama de clases
- Ejemplo

---

## Tabla de contenido

1. [Factory Method](#factory-method)
2. [Abstract Factory](#abstract-factory)
3. [Builder](#builder)
4. [Prototype](#prototype)
5. [Singleton](#singleton)

### Factory Method

- **Definición**

El patrón de diseño *Factory Method* nos facilita la creación de objetos a través de una *interfaz* común y una super clase (*Factory*) que le permite a las subclases especificar el tipo de objetos que ellas deseen crear. Este patrón busca **desacoplar** el código de la creación de objetos.

- **¿Cuándo usar este patrón?**

Es un patrón que se debe usar cuando se necesite **dejar el código abierto a nuevas implementaciones** de objetos o cuando **no se conozca la totalidad de los objetos** con los que debe interactuar el sistema.

- **¿Cuales son sus componentes?**

  - **Creator**: Esta es una *clase abstracta* encargada de encapsular los métodos necesarios para crear los objetos.
  - **Concrete Creator**: Esta clase hereda y sobreescribe los métodos definidos dentro de *Creator* para escribir la lógica propia de cada tipo de objeto.
  - **Product**: Esta es una *interface* que provee los métodos comunes para todos los objetos.
  - **Concrete Product**: Implementa el comportamiento real de cada uno de los productos.

- **Diagrama de clases**

![diagrama_factory_method](resources/factory_method_components.drawio.png)

- **Ejemplo**

Para ejemplificar el patrón Factory Method, pensemos en una aplicación que debe manejar distintos tipos de archivos de entrada para sus procesos. Actualmente, solo se tienen implementados los archivos CSV y JSON, pero se tiene presente que en un futuro cercano se está pensando en integrar XML y otros archivos más.

```csharp
// Creamos una interfaz Product para los tipos de archivos
public interface IFile{
  Task<string> Read(string filePath);
  bool IsValidExtension(string extension);
}

// Creamos cada uno de los productos concretos
public class CSVFile: IFile{

  public async Task<string> Read(string filePath){
    string readLines = string.Empty;

    //implementa la lógica propia de lectura

    return readLines;
  }

  public bool IsValidExtension(string extension){
    bool isValid;

    //Implementa lógica propia para CSV

    return isValid;
  }
}

public class JSONFile: IFile{

  public async Task<string> Read(string filePath){
    string readLines = string.Empty;

    //implementa la lógica propia de lectura

    return readLines;
  }

  public bool IsValidExtension(string extension){
    bool isValid;

    //Implementa lógica propia para JSON

    return isValid;
  }
}

// Creamos la clase abstracta Creator
public abstract class BaseFileFactory{

  public abstract IFile CreateFile();

}

// Creamos cada una de las implementaciones del Factory
public class CSVFactory : BaseFilefactory{

  public override IFile CreateFile(){

    //Implementación propia para archivos CSV
    return new CSVFile();    
  }
}

public class JSONFactory : BaseFileFactory{

  public override IFile CreateFile(){

    //Implementación propia para archivos JSON
    return new JSONFile();    
  }
}

```

[Volver a Indice](#tabla-de-contenido)

---

### Abstract Factory

- **Definición**

El patrón de diseño *Abstract Factory* permite la creación de familias de objetos usando una interfaz sin la necesidad de especificar sus clases concretas. En terminos simples [Geek for Geeks](https://www.geekforgeeks.org/system-design/abstract-factory-pattern) lo define como el camino para crear un grupo de objetos que están relacionados.

- **¿Cuándo usar este patrón?**

Este patrón se suele utilizar en los siguientes casos:
    - Cuando el sistema requiera de multiples familias de objetos relacionados y se necesita asegurar su compatibilidad.
    - Cuando se requiera dejar la puerta abierta para futuras extensiones de objetos relacionados
    - Cuando se tienen varios *Factory Method* relacionados.

- **¿Cuales son sus componentes?**

  - **Abstract Factory**: Esta es la *interface* propuesta para la creación de las familias de objetos. Define las reglas para crear las familas de objetos.
  - **Concrete Factories**: Son las implementaciones especificas para la creación de cada una de las familias. Cada una de estas debe implementar la *interface* *Abstract Factory*
  - **Abstract Products**: Representa una familia de objetos, se definen los metodos y/o propiedades comunes.
  - **Concrete Products**: Implementación especifica de cada una de las familias de productos. Cada una de estas clases debe implementar la *interface* *Abstract Product*

- **Diagrama de clases**

![diagrama_factory_method](resources/abstract_factory_components.drawio.png)

- **Ejemplo**

[Volver a Indice](#tabla-de-contenido)

### Builder

- **Definición**

El patrón de diseño *Builder* permite la creación de objetos complejos a través de una serie de pasos. Adicionalmente, el patrón permite producir diferentes tipos y representaciones de un objeto usando un mismo código constructor.

- **¿Cuándo usar este patrón?**

Este patrón de diseño suele utilizarce en los siguientes escenarios:
    - Cuando se necesite crear objetos complejos que tiene muchos parametros opcionales
    - Cuando la construccion de un objeto se necesita hacer de un determinado orden o ejecutar una serie de pasos.
    - Cuando se tiene metodos constructores con muchos parametros
    - Cuando se requiere de una interfaz común para construir diferentes objetos.

- **¿Cuales son sus componentes?**

  - **Product**: Esta clase es la que hace referencia al objeto complejo que debe ser creado paso a paso.
  - **Builder**: Es una *interface* que tiene todos los metodos necesarios para construir un objeto paso a paso.
  - **Concrete Builder**: Es la implementación de la *interface Builder* con el comportamiento deseado para crear el objeto de la clase *Product*
  - **Director**: Es el responsable por la orquestación del proceso de creación del objeto. Es una clase opcional, cuando no se configura, se deja la responsabilidad de la creación del objeto al cliente.

- **Diagrama de clases**

![diagrama_factory_method](resources/builder_components.drawio.png)

- **Ejemplo**

[Volver a Indice](#tabla-de-contenido)

### Prototype

- **Definición**

El patrón de diseño *Prototype* permite la creacion de objetos a partir de un objeto previamente existente. Es decir, realizar una copia del objeto sin hacer el codigo dependiente de las clases.

Este patrón permite ocultar al cliente toda la complejidad de crear nuevas instancias de un objeto.

- **¿Cuándo usar este patrón?**

Este patrón de diseño suele utilizarce en los siguientes escenarios:
    - Cuando los tiempos o costos de creación de un objeto son altos.
    - Cuando no se desea hacer el código dependiente de las clases que se van a copiar
    - Cuando se requiere copiar un objeto muy complejo con configuraciones previas.

- **¿Cuales son sus componentes?**

  - **Prototype Interface**: Esta es la *interface* que contiene el método *clone* con el cual se realizarán las copias de los objetos.
  - **Concrete Prototype**: Esta clase es la que implementa la *interface* y sobreescribe el metodo *clone*.

- **Diagrama de clases**

![diagrama_factory_method](resources/prototype_components.drawio.png)

- **Ejemplo**

[Volver a Indice](#tabla-de-contenido)

### Singleton

- **Definición**

El patrón de diseño *Singleton* se asegura de que una clase sea instanciada una sola vez y provee un acceso global a esta instancia.

- **¿Cuándo usar este patrón?**

Este patrón de diseño se suele utilizar en los siguientes casos:
    - Se requiere centralizar el control.
    - Cuando se requiera que una instancia pueda ser accedida desde cualquier punto del código.
    - Cuando se requiere una instancia global para todos los clientes.
    - Cuando se necesite ser estricto con el control de variables gloabales.

- **¿Cuales son sus componentes?**

  - **Singleton**: Para implementar este patrón, se deben tener en cuenta las siguientes reglas: constructur privado, un campo estático para almacenar la clase, un metodo estático para retonar la instancia.

- **Diagrama de clases**

![diagrama_factory_method](resources/singleton_components.drawio.png)

- **Ejemplo**

[Volver a Indice](#tabla-de-contenido)

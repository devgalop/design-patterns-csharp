# Patrones Creacionales

## Definición

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

Para ejemplificar el patrón **Factory Method**, pensemos en una aplicación que debe manejar distintos tipos de archivos de entrada para sus procesos. Actualmente, solo se tienen implementados los archivos CSV y JSON, pero se tiene presente que en un futuro cercano se está pensando en integrar XML y otros archivos más.

```csharp
// Creamos una interfaz Product para los tipos de archivos
public interface IFile{
  Task<string> Read(string filePath);
  bool IsValidExtension(string extension);
}

// Creamos cada uno de los productos concretos
public class CSVFile: IFile{

  public async Task<string> Read(string filePath){
    // Simula la lectura de un archivo CSV
    await Task.Delay(100); // Simula una operación asincrónica
    return "Contenido del archivo CSV";
  }

  public bool IsValidExtension(string extension){
    // Verifica si la extensión es válida para un archivo CSV
    return extension.Equals(".csv", StringComparison.OrdinalIgnoreCase);
  }
}

public class JSONFile: IFile{

  public async Task<string> Read(string filePath){
    // Simula la lectura de un archivo JSON
    await Task.Delay(100); // Simula una operación asincrónica
    return "Contenido del archivo JSON";
  }

  public bool IsValidExtension(string extension){
    // Verifica si la extensión es válida para un archivo JSON
    return extension.Equals(".json", StringComparison.OrdinalIgnoreCase);
  }
}

// Creamos la clase abstracta Creator
public abstract class BaseFileFactory{

  public abstract IFile CreateFile();

}

// Creamos cada una de las implementaciones del Factory
public class CSVFactory : BaseFileFactory{

  public override IFile CreateFile(){
    // Retorna una nueva instancia de CSVFile
    return new CSVFile();    
  }
}

public class JSONFactory : BaseFileFactory{

  public override IFile CreateFile(){
    // Retorna una nueva instancia de JSONFile
    return new JSONFile();    
  }
}

```

De esta manera, cuando se requiera implementar un nuevo tipo de archivo, basta con crear la entidad del producto implementando la interfaz *IFile* y crear el factory respectivo heredando la clase BaseFileFactory.

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

Un ejemplo perfecto para aplicar el patrón **Abstract Factory** es el siguiente: Supongamos que se está creando una aplicacion para una tienda que vende indumentarias de moto por marca, dentro de las indumentarias se tienen prendas como Cascos, Chaquetas y Pantalones. La tienda dentro de sus marcas tiene Alpinestar, Richa y Dainese.

El patrón es perfectamente aplicable ya que cada marca representa una familia de productos. Desde el código se vería así

```csharp
// Creamos las interfaces de cada tipo de producto
// IHelmet: interfaz para las implementaciones de todos los cascos.
public interface IHelmet{
  string GetCertification();
}
// IJacket: interfaz para las implementaciones de las chaquetas.
public interface IJacket{
  string GetDescription();
  List<string> GetAvailableSizes();
}
// IPants: interfaz para las implementaciones de los pantalones.
public interface IPants{
  string GetDescription();
  string GetGuarantee();
}

// Se crean las clases concretas para cada tipo de producto
public class AlpinestarHelmet : IHelmet{

  public string GetCertification(){
    //Implementación de lógica propia para el casco Alpinestar
    return "Alpinestar Helmet certification";
  }
}
public class RichaHelmet : IHelmet{

  public string GetCertification(){
    //Implementación de lógica propia para el casco Richa
    return "Richa Helmet certification";
  }
}
public class DaineseHelmet : IHelmet{

  public string GetCertification(){
    //Implementación de lógica propia para el casco Dainese
    return "Dainese Helmet certification";
  }
}

public class AlpinestarJacket : IJacket{

  public string GetDescription(){
    //Implementación de lógica propia para la chaqueta Alpinestar
    return "Alpinestar Jacket description";
  }

  public List<string> GetAvailableSizes(){
    //Busca las tallas disponibles para la chaqueta Alpinestar
    return new List<string> { "M", "L", "XL" };
  }
}
public class RichaJacket : IJacket{

  public string GetDescription(){
    //Implementación de lógica propia para la chaqueta Richa
    return "Richa Jacket description";
  }

  public List<string> GetAvailableSizes(){
    //Busca las tallas disponibles para la chaqueta Richa
    return new List<string> { "L", "XL" };
  }
}
public class DaineseJacket : IJacket{

  public string GetDescription(){
    //Implementación de lógica propia para la chaqueta Dainese
    return "Dainese Jacket description";
  }

  public List<string> GetAvailableSizes(){
    //Busca las tallas disponibles para la chaqueta Dainese
    return new List<string> { "M", "L" };
  }
}

public class AlpinestarPants : IPants{

  public string GetDescription(){
    //Implementación de lógica propia para el pantalón Alpinestar
    return "Alpinestar Pants description";
  }

  public string GetGuarantee(){
    return "Alpinestar Pants guarantee";
  }
}
public class RichaPants : IPants{

  public string GetDescription(){
    //Implementación de lógica propia para el pantalón Richa
    return "Richa Pants description";
  }

  public string GetGuarantee(){
    return "Richa Pants guarantee";
  }
}
public class DainesePants : IPants{

  public string GetDescription(){
    //Implementación de lógica propia para el pantalón Dainese
    return "Dainese Pants description";
  }

  public string GetGuarantee(){
    return "Dainese Pants guarantee";
  }
}


// Creamos la interfaz que ejerce la función de Abstract Factory
public interface IFactory{
  IHelmet CreateHelmet();
  IJacket CreateJacket();
  IPants CreatePants();
}

// Creamos cada uno de las Factory concretas por marca
public class AlpinestarFactory : IFactory{

  public IHelmet CreateHelmet(){
    return new AlpinestarHelmet();
  }

  public IJacket CreateJacket(){
    return new AlpinestarJacket();
  }

  public IPants CreatePants(){
    return new AlpinestarPants();
  }
}

public class RichaFactory : IFactory{

  public IHelmet CreateHelmet(){
    return new RichaHelmet();
  }

  public IJacket CreateJacket(){
    return new RichaJacket();
  }

  public IPants CreatePants(){
    return new RichaPants();
  }
}

public class DaineseFactory : IFactory{

  public IHelmet CreateHelmet(){
    return new DaineseHelmet();
  }

  public IJacket CreateJacket(){
    return new DaineseJacket();
  }

  public IPants CreatePants(){
    return new DainesePants();
  }
}
```

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

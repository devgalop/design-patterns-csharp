# Patrones Estructurales

## Definición

Los patrones de diseño estructurales se encargan de mostrar cómo se deben organizar y componer las clases y objetos, explican cómo se deben ensamblar, permitiendo flexibilidad en sistemas complejos. [Refactoring Guru](https://refactoring.guru/design-patterns/structural-patterns).

Para [Geek for Geeks](https://www.geeksforgeeks.org/system-design/structural-design-patterns/) los patrones de diseño estructurales se enfocan en organizar clases y objetos dentro de largas estructuras de manera eficiente y mantenible. Estos son los encargados de describir las diferentes formas que se puede componer un objeto para realizar nuevas funcionalidades. Simplifica el manejo de jerarquias complejas.

## Clasificación

A continuación se desarrollan para cada uno de los patrones creacionales los siguientes items:

- Definición
- ¿Cuándo usar este patrón?
- ¿Cuales son sus componentes?
- Diagrama de clases
- Ejemplo

---

## Tabla de contenido

1. [Adapter](#adapter)
2. [Bridge](#bridge)
3. [Composite](#composite)
4. [Decorator](#decorator)
5. [Fly weight](#fly-weight)
6. [Proxy](#proxy)

### Adapter

- **Definición**

El patrón de diseño *adapter* funge como un puente para la colaboración entre objetos incompatibles, es decir, que no tienen una *interfaz* común, permitiendo que estos objetos trabajen juntos.

- **¿Cuándo usar este patrón?**

Este patrón se suele utilizar en los siguientes escenarios:

1. Cuando se requiere utilizar código existente pero las interfaces no son compatibles con el resto del código.
2. Cuando se necesite utilizar subclases que no pueden ser agregadas en una superclase.
3. Cuando necesitas implementar librerias existentes que son incompatibles con tu codigo.
4. Cuando el proyecto crece, el patrón permite agregar este nuevo codigo sin afectar el existente.

- **¿Cuales son sus componentes?**

  - **Target Interface**: Define la *interface* con la que el cliente va interactuar.
  - **Adaptee**: Clase existente que es incompatible con el código actual.
  - **Adapter**: El adaptador implementa la *interface* e internamente genera una instancia de la clase *Adaptee* para hacerla compatible con la *interface*.

- **Diagrama de clases**

![diagrama_adapter](resources/adapter_components.drawio.png)

- **Ejemplo**

Para ejemplificar el patrón **Adapter** simularemos un problema recurrente. Una pasarela de pagos debe integrarse con una plataforma externa para realizar los pagos de determinado banco. Dentro de nuestro sistema de pasarela de pagos, el cliente se integra con la ayuda de la interfaz IPayment, sin embargo el Banco X expone una API propia la cual no es compatible con IPayment.

```csharp
// La interfaz payment es la representación de ITarget
public interface IPayment{
  bool Pay(string reference, double value);
}

// Esta clase cumple la función de adaptador
public class PaymentXAdapter : IPayment{

  private readonly IPaymentX _paymentBankX;

  public PaymentXAdapter(IPaymentX paymentBankX)
  {
    _paymentBankX = paymentBankX;
  }

  public bool Pay(string reference, double value){
    //Implementa lógica previa de pagos
    return _paymentBankX.PayBill(DateTime.UtcNow, reference, value);
  }
}

// Interfaz usada por el banco X 
public interface IPaymentX{
  bool PayBill(DateTime transactionDate, string payReference, double value);
}
```

[Volver a Indice](#tabla-de-contenido)

---

### Bridge

- **Definición**

El patrón de diseño *Bridge* permite dividir una jerarquia de clases muy extensa y que se desarrollan por separado, en dos jerarquias *Abstractions* e *Implementations*. Esto habilita que ambas jerarquias puedan desarrollarse de manera independiente.

El sitio web [Refactoring Guru](https://refactoring.guru/design-patterns/bridge) resume esto con un ejemplo básico y fácil de entender. Supongamos que tenemos una clase *Figura* la cual tiene implementaciones como *Circulo* y *Cuadrado*. Se desea incorporar a esta clase *Figura* diferentes colores como lo son *Rojo* y *Azul*. Si se implementa estos colores en la jerarquia de figura se duplicarían las clases concretas:
*Circulo Rojo*, *Circulo Azul*, *Cuadrado Rojo*, *Cuadrado Azul*. A medida que la jerarquia crece, se hace más tedioso realizar nuevas implementaciones.

Para resolver este problema, se dividen dos claras jerarquias *Figuras* y *Colores*. Donde la *Figura* contiene un *Color*.

- **¿Cuándo usar este patrón?**

El patrón brige se debe usar en los siguientes escenarios:

  1. Cuando una jerarquía crece de manera exponencial debido a la combinación de multiples variables de dimensión.
  2. Cuando se desee separar la lógica de los detalles de la implementación de la jerarquía, de modo de que evolucionen independiente.

- **¿Cuales son sus componentes?**

  - **Abstraction**: Provee el control logico a alto nivel. Esta clase contiene la referencia al *Implementer*.
  - **Refined Abstraction**: Esta clase es la implementación concreta de la clase *Abstraction*.
  - **Implementer**: Esta es la *interface* para las clases de la jerarquia *Implementations*.
  - **Concrete Implementation**: Contiene la implementacion concreta de la *interface* *Implementer*.

- **Diagrama de clases**

![diagrama_bridge](resources/bridge_components.drawio.png)

- **Ejemplo**

Usaremos un ejemplo básico para representar el patrón **Bridge**, supongamos que nuestra aplicación es usada por una empresa que presta mobiliario para eventos. Dentro del catalogo de sus productos tienen mesas, sillas entre otros mobiliarios. Cada uno de ellos está en diferentes materiales como madera, plastico, metal etc.

El patrón brige nos permite separar el mobiliario (Abstractions) y los materiales (Implementations). De esta manera cada que ingrese un nuevo mobiliario no se debe modificar los materiales, y viceversa, cuando ingrese un material, el mobiliario no debe verse afectado.

```csharp
// Cumple la función de Abstraction
public interface IFurniture
{
    string GetSizeDescription();
    string GetMaterial();
}

// Cumple la función de Implementer
public interface IMaterial
{
    string GetDescription();
}

// Implementaciones de las Abstractions

public class Desk : IFurniture
{
    private readonly IMaterial _material;

    public Desk(IMaterial material)
    {
        _material = material;
    }

    public string GetSizeDescription()
    {
        return "Escritorio de tamaño estándar.";
    }

    public string GetMaterial()
    {
        return _material.GetDescription();
    }
}

public class Sofa : IFurniture
{
    private readonly IMaterial _material;

    public Sofa(IMaterial material)
    {
        _material = material;
    }

    public string GetSizeDescription()
    {
        return "Sofá de tamaño grande.";
    }

    public string GetMaterial()
    {
        return _material.GetDescription();
    }
}

// Implementaciones concretas de Implementations

public class Wood : IMaterial
{
    public string GetDescription()
    {
        return "Hecho de madera.";
    }
}

public class Metal : IMaterial
{
    public string GetDescription()
    {
        return "Hecho de metal.";
    }
}

public class Plastic : IMaterial
{
    public string GetDescription()
    {
        return "Hecho de plástico.";
    }
}

// Ejemplo de uso del patrón Bridge
public class Client
{
    public void DisplayFurnitureDetails()
    {
        // Crear materiales
        IMaterial wood = new Wood();
        IMaterial metal = new Metal();

        // Crear mobiliario con diferentes materiales
        IFurniture woodenDesk = new Desk(wood);
        IFurniture metalSofa = new Sofa(metal);

        // Mostrar detalles
        Console.WriteLine($"Mobiliario: {woodenDesk.GetSizeDescription()}, Material: {woodenDesk.GetMaterial()}");
        Console.WriteLine($"Mobiliario: {metalSofa.GetSizeDescription()}, Material: {metalSofa.GetMaterial()}");
    }
}

```

[Volver a Indice](#tabla-de-contenido)

---

### Composite

- **Definición**

El patrón de diseño *Composite* permite componer objetos dentro de estructuras de arboles y trabajar con cada objeto de manera individual.

**NOTA**: Este patron solo es aplicable a modelos que se puedan representar como un *árbol*

El concepto principal es que se puede manipular una sola instancia del objeto de la misma manera que se puede manipular un grupo de instancias.

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

  - **Component**: El componente declara la *interface* para los objetos en la composicion. También permite acceder y administrar los componentes hijos.
  - **Leaf**: Define el comportamiento para los objetos primitivos dentro de la composicion. Este es la implementacion base de la composicion. Representa la implementación de la *interface* *Component*.
  - **Composite**: Almacena los componentes hijos e implementa las operaciones entre los hijos. Los hijos pueden ser *Leaf* u otros *Composite*.

- **Diagrama de clases**

![diagrama_composite](resources/composite_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

---

### Decorator

- **Definición**

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

- **Diagrama de clases**

![diagrama_decorator](resources/decorator_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

---

### Facade

- **Definición**

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

- **Diagrama de clases**

![diagrama_facade](resources/facade_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

---

### Fly Weight

- **Definición**

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

- **Diagrama de clases**

![diagrama_fly_weight](resources/flyweigth_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

---

### Proxy

- **Definición**

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

- **Diagrama de clases**

![diagrama_proxy](resources/proxy_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

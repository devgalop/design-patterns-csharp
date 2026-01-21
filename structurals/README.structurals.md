# Patrones Estructurales

## Definición

Los patrones de diseño estructurales se encargan de mostrar cómo se deben organizar y componer las clases y objetos, explican cómo se deben ensamblar, permitiendo flexibilidad en sistemas complejos. [Refactoring Guru](https://refactoring.guru/design-patterns/structural-patterns).

Para [Geek for Geeks](https://www.geeksforgeeks.org/system-design/structural-design-patterns/) los patrones de diseño estructurales, resuelven los problemas que tienen que ver en cómo las clases y objetos son compuestos y ensamblados. Simplifica el manejo de jerarquias complejas.

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

El patrón de diseño *adapter* nos permite la colaboración entre objetos que no tienen una *interfaz* compatible.

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

```csharp
//Implementacion
```

[Volver a Indice](#tabla-de-contenido)

---

### Bridge

- **Definición**

El patrón de diseño *Bridge* permite dividir una clase muy larga o un conjunto de clases que esten fuertemente relacionadas en dos jerarquias *Abstractions* e *Implementations*. Esto permite que ambas jerarquias puedan desarrollarse de manera independiente.

El sitio web [Refactoring Guru](https://refactoring.guru/design-patterns/bridge) resume esto con un ejemplo básico y fácil de entender. Supongamos que tenemos una clase *Figura* la cual tiene implementaciones como *Circulo* y *Cuadrado*. Se desea incorporar a esta clase *Figura* diferentes colores como lo son *Rojo* y *Azul*. Si se implementa estos colores en la jerarquia de figura se duplicarían las clases concretas:
*Circulo Rojo*, *Circulo Azul*, *Cuadrado Rojo*, *Cuadrado Azul*. A medida que la jerarquia crece, se hace más tedioso realizar nuevas implementaciones.

Para resolver este problema, se dividen dos claras jerarquias *Figuras* y *Colores*. Donde la *Figura* contiene un *Color*.

- **¿Cuándo usar este patrón?**

- **¿Cuales son sus componentes?**

  - **Abstraction**: Provee el control logico a alto nivel. Esta clase contiene la referencia al *Implementer*.
  - **Refined Abstraction**: Esta clase es la implementación concreta de la clase *Abstraction*.
  - **Implementer**: Esta es la *interface* para las clases de la jerarquia *Implementations*.
  - **Concrete Implementartion**: Contiene la implementacion concreta de la *interface* *Implementer*.

- **Diagrama de clases**

![diagrama_bridge](resources/bridge_components.drawio.png)

- **Ejemplo**

```csharp
//Implementacion
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

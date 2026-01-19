# Patrones de diseño estructurales

Los patrones de diseño estructurales se encargan de mostrar cómo se deben organizar y componer las clases y objetos, explican cómo se deben ensamblar, permitiendo flexibilidad en sistemas complejos. [Refactoring Guru](https://refactoring.guru/design-patterns/structural-patterns).

Para [Geek for Geeks](https://www.geeksforgeeks.org/system-design/structural-design-patterns/) los patrones de diseño estructurales, resuelven los problemas que tienen que ver en cómo las clases y objetos son compuestos y ensamblados. Simplifica el manejo de jerarquias complejas.

## Clasificación

Los patrones de diseño estructurales se dividen en:

- **Adapter**: Este patrón permite que objetos que provienen de interfaces incompatibles, puedan trabajar juntos a través de el uso de una clase adaptador [ver más ...](adapter/devgalop.learn.adapter)

- **Bridge**: Este patrón permite separar jerarquías complejas que crecen de manera independiente en dos grupos *Abstractions* e *Implementations*, para que cada una de estas, pueda ser desarrollada y/o modificada sin afectar a la otra. [ver más ...](bridge/devgalop.learn.bridge)

- **Composite**: Este patrón permite que el cliente trabaje con objetos simples o compuestos de la misma manera, es un patrón que solo se aplica en jerarquias tipo árbol.

- **Decorator**: Este patrón permite añadir nuevas funcionalidades a un objeto sin modificar su codigo principal. Funciona cómo una envoltura, donde se van añadiendo cada vez más capas de comportamientos al objeto inicial.

- **Facade**: Este patrón permite simplificar la interacción que tiene un cliente con un sistema complejo, solo se expone lo necesario, lo demás pasa tras la fachada.

- **Flyweight**: Es un patrón que permite la optimización del uso de RAM cuando existen objetos que tienen un estado compartido.

- **Proxy**: Este patrón permite interactuar con un objeto sustituto para recibir y controlar el acceso al objeto principal.

# Patrones de diseño creacionales

Los patrones de diseño creacionales proveen mecanismos para la creación de objetos incrementando así la eficiencia y la reutilización del código [según Refactoring  Guru](https://refactoring.guru/design-patterns/creational-patterns).

Estos patrones creacionales ayudan a desacoplar el sistema de la creación de los objetos, es decir, el sistema es independiente a cómo se crean los objetos, cómo se componen y cómo se representan [según Geek for Geeks](https://www.geeksforgeeks.org/system-design/software-design-patterns/#creational-design-patterns).

Los patrones de diseño creacionales son:

- [Factory Method](factoy-method): Provee una interfaz para la creacion de objetos en una super clase llamada *Factory*. [Conocer más ...](factory-method)
- [Abstract Factory](abstract-factory): Permite la construcción de familias de objetos sin una clase especifica. [Conocer más ...](abstract-factory)
- [Builder](builder): Permite la creacion de objetos complejos paso a paso [Conocer más ...](builder)
- [Prototype](prototype): Genera copias o clones a partir de un objeto existente sin depender de la clase [Conocer más ...](prototype)
- [Singleton](singleton): Asegura que una clase tenga una única instancia y provee un acceso global a esta intancia [Conocer más ...](singleton)
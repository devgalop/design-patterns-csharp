# Patrones Creacionales

Los patrones de diseño creacionales proveen mecanismos para la creación de objetos, de manera que, el código sea fuertemente dependiente de estos. De esta manera se obtiene un código abierto a nuevas implementaciones. [según Refactoring  Guru](https://refactoring.guru/design-patterns/creational-patterns).

Estos patrones creacionales se encarga de desacoplar el sistema de la creación de los objetos, es decir, el sistema es independiente a cómo se crean los objetos, cómo se componen y cómo se representan [según Geek for Geeks](https://www.geeksforgeeks.org/system-design/software-design-patterns/#creational-design-patterns).

## Clasificación

Los diferentes patrones creacionales son:

- **Factory Method**: Provee una interfaz para la creacion de objetos en una super clase llamada *Factory*. Permitiendo desacoplar el código de la creación de objetos. Cada objeto tiene su propia implementación concreta. [Conocer más ...](factory-method/devgalop.learn.factory_method)

- **Abstract Factory**: Permite la construcción de familias de objetos relacionados mediante el uso de una interfaz común. Este patrón se encarga de mantener una consistencia entre los productos que están relacionados. [Conocer más ...](abstract-factory/devgalop.learn.abstract_factory)

- **Builder**: Permite la creacion de objetos complejos y/o con muchos parámetros opcionales en una secuencia de pasos lógicos. Este paso a paso puede delegarse al cliente o tener una clase director para que orqueste los pasos. [Conocer más ...](builder/devgalop.learn.builder)

- **Prototype**: Genera copias o clones a partir de un objeto existente sin depender de la clase [Conocer más ...](prototype/devgalop.learn.prototype)

- **Singleton**: Asegura que la instancia de un objeto se cree una única vez y que esta se pueda acceder globalmente desde cualquier parte del código. [Conocer más ...](singleton/devgalop.learn.singleton)

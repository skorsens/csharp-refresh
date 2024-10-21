namespace Classes;

/*
record vs class vs struct:
- Type category:
    `record` are reference types
    `class` are reference types
    `struct` are value types

- Fields initialization:
    `record` provide implicit fields initialization using the primary constructor (see `record Person`)
    `class` require explicit fields initialization, e.g.
    `public class ClassPerson(string Name, string Surname);`
    
    does not define a fields "Name" and "Surname" while

    `public record Person(string Name, string Surname);`

    does.
    `struct` requre explicit fields initialization

    `record class` is equivalent to `record`
    `record struct` provides implicit fields initialization

- Mutability:
    `record` fields are immutable by default, but can be made mutable
    `class` are mutable by default
    `struct` are immutable, but can be made mutable

- Equality:
    `record` are value equality
    `class` are reference equality
    `struct` are value equality

- Inheritance:
    `record` support inheritance
    `class` support inheritance
    `struct` does not support inheritance, but can implement an interface

- Copy constructor:
    `record` have a default shallow copy constructor; users can define a copy constructor
    `class` do not have a default copy constructor; users can define a copy constructor
    `struct` have a default shallow copy constructor; users can define a copy constructor
    `record struct` have no copy constructor, since they are always copied

*/

namespace Generics;

/*
A generic type is called "unbound" until the type parameter (`T`) is
defined, then it is called "constructed". 
*/
public class NamedContainerClass<T>(T item, string name)
{
    public T Item { get; } = item;
    public string Name { get; } = name;
}


//public record NamedContainerRecord<T>(T Item; string Name);

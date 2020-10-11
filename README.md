# Topic: *Creational Design Patterns*
### Author: *Adrian-Mihai Covaci*
------
## Objectives :
__1. Study the Creational Design Patterns__

__2. Implement them in real projects__

## Theory :
Creational patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

Some examples of this kind of design patterns are :

   * Singleton
   * Builder
   * Prototype
   * Object Pooling
   * Factory Method
   * Abstract Factory

## Implementation :
In the following project, I've implemented a factory which deals with creating cars based on the body type that the client requested.
Besides using the factory, a car can be created by cloning an already existent one. It is guaranteed that only one instance of a car shop can be created, and the creation process is thread safe, using .NET's Lazy<T> type, by accessing the object's ~Instance~ property.


namespace ConsoleApp2;

public record Person(int Id, string FirstName, string LastName, string Address,int Age);

//Records:
//Records are a new feature introduced in C# 9 that provide a concise and convenient way to define immutable data types.
//They combine properties, equality, and value-based semantics in a single construct.
//Here are a few key points to understand about records:

//Immutability: Records are immutable by default, meaning that their properties cannot be changed once the record is created.
//This ensures that the state of a record remains consistent throughout its lifetime.

//Value-based equality: Records have built-in value-based equality semantics.
//This means that two records are considered equal if all their properties have the same values. By default, the equality comparison includes all properties of the record.

//Property initialization: Records allow you to initialize properties directly in the constructor or using property initializers.
//This makes it convenient to create and initialize instances of records in a single expression.

//With-expressions: Records support the with keyword, which allows you to create a new record based on an existing one with specific properties updated.
//This helps in creating modified copies of records while keeping the original record immutable.

//Inheritance and interfaces: Records can inherit from classes and interfaces like regular classes.
//They can also override members and implement interfaces, allowing you to define behavior specific to the record type.







// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

//Problem: We need to iterate over a collection of items without exposing the underlying representation of the collection.
//Solution: Use the Iterator pattern to provide a uniform interface for traversing different types of collections.

//The Iterator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

var words = new List<string> { "First", "Second", "Third", "Fourth", "Fifth" };

//words.GetRange(0, 2).ForEach(Console.WriteLine);

IteratorClass iterator = new IteratorClass(words);
iterator.MoveNext();
Console.WriteLine(iterator.Current);
iterator.MoveNext();
Console.WriteLine(iterator.Current);
iterator.MoveNext();
Console.WriteLine(iterator.Current);
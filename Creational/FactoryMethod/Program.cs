// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
// Problem: 
// Bir yapının sorumlu olduğu işi yapması gerekmektedir. Bu işi yaparken de bir çok farklı nesneye ihtiyaç duyulmaktadır.
// Bu nesnelerin oluşturulması ve yönetilmesi gerekmektedir. Bu durumda Factory Method Pattern devreye girmektedir.
// Factory Method Pattern, bir sınıfın nesne oluşturma işlemini alt sınıflara bırakarak, nesne oluşturma işlemini
// alt sınıflara bırakarak, nesne oluşturma işlemini gerçekleştirmektedir. Bu sayede nesne oluşturma işlemi
// alt sınıflara bırakılmış olmaktadır. Bu sayede nesne oluşturma işlemi daha esnek bir hale gelmektedir.
// Factory Method Pattern, Creational Design Pattern grubunda yer almaktadır.

//Hoca Notu: Bir nesneyi oluştururken; o nesnenin sorumlu olduğu başka nesneleri de oluşturmak istiyorsunuz. Bu 
// ihtiyaciınızı nasıl giderirsiniz? Factory Method Pattern ile giderirsiniz. 

/*
 * CuktureMapGenerator mapGenerator = new CultureMapGenerator();
 * var map = mapGenerator.GenerateMap();
 * 
 */

CultureMapGenerator mapGenerator = new CultureMapGenerator();
var map = mapGenerator.GenerateMap();
map.ShowMap();
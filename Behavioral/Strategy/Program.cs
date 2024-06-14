// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");

/*
 * Problem: Bir iş için yazdığınız algoritma değişmesi gerekirse; minimum kod değişikliği ile bu algoritma güncellemesini nasıl yaparsınız?
 * 
 * Çözüm: Strategy Pattern, bir algoritmayı tanımlar, bu algoritmayı bir sınıfa kapsüler ve bu sınıfı değiştirilebilir yapar.
 * 
 */


ProductCollection productCollection = new ProductCollection();

productCollection.Sort(new BubbleSort());
productCollection.Sort(new QuickSort());

Console.ReadLine();
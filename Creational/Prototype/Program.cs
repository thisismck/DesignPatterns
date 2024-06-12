// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");
/*
 * Bellekte oluşturulması çok zaman alan bir nesneniz var.
 * Ama aynısından bir kaç tan kullanmanız gerekiyor
 * İlki hariç diğerlerinin hiç zaman almaması için ne yaparsınız?
 * 
 * Var olan nesneyi klonlarsınız.
 * 
 */

string[] letters = {"A", "B", "C", "D"};

var cloneLetters = (string[])letters.Clone();

foreach (var letter in cloneLetters)
{
    Console.WriteLine(letter);
}

cloneLetters[0] = "Z";

Console.WriteLine(
    $"letters[0]: {letters[0]} cloneLetters[0]: {cloneLetters[0]}");


Chair chair = new Chair();

Chair chair2 = (Chair)chair.Clone(true);
Console.WriteLine(
    $"chair.No: {chair.No} chair2.No: {chair2.No}");
Console.WriteLine(chair.ToString());
Console.WriteLine(chair2.ToString());

chair2.No = 2;
chair2.Cinema.MovieName = "Matrix"; // chair2'nin Cinema'sını değiştirdik. chair'da da değişir.
Console.WriteLine(
    $"chair.No: {chair.No} chair2.No: {chair2.No}");
Console.WriteLine(chair.ToString());
Console.WriteLine(chair2.ToString());


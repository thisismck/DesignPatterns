// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

/*
 * Problem: Uygulamanızda sadece bir tane olmasını istediğiniz bir instance'ınız var. Bunu nasıl sağlarsınız?
 * 
 * Cevap: Singleton pattern kullanarak. Singleton pattern, bir sınıfın yalnızca bir örneğine sahip olmasını 
 * sağlar ve bu örneğe global erişim sağlar.
 * 
 * 
 */

MailConfigurator mailConfigurator1 = MailConfigurator.GetInstance();
MailConfigurator mailConfigurator2 = MailConfigurator.GetInstance();

if (mailConfigurator1 == mailConfigurator2)
{
    Console.WriteLine("İki instance aynıdır.");
}
else
{
    Console.WriteLine("İki instance farklıdır.");
}
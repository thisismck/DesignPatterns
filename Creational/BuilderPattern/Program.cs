// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");

/*
 * Problem: Oluşturulması için bir çok aşamadan geçen kompleks bir nesnemiz var ve bu nesneyi oluşturmak için bir çok parametre gerekiyor.
 * Bu nesne geliştirilebilir bir nesne olmalı ve bu nesne oluşturulurken bir çok aşamadan geçmeli.
 * Bu aşamaları nasıl stabil (tüm implamantasyonlarda aynı olacak biçimde) hale getirirsiniz?
 * 
 * Çözüm: Builder Pattern
 * Çözümün uygulanması
 * */


var reportBuilder = new ReportBuilder();
var reportDirector = new ReportDirector(reportBuilder);
reportDirector.Run();
var report = reportBuilder.GetReport();
Console.WriteLine(report.Title);

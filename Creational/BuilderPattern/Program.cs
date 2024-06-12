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


var reportBuilder = new WeeklySalesReportBuilder();
reportBuilder.SetTitle();
reportBuilder.SetData();
reportBuilder.SetGraph();
var report = reportBuilder.GetReport();
Console.WriteLine(report.Title );
Console.WriteLine(report.Data);
Console.WriteLine(report.Graph);


var director = new ReportDirector(new WeeklySalesReportBuilder());

Console.WriteLine(director.BuildReportAndReturn().Title);

var standartReportBuilder = new ReportDirector(new StandartReportBuilder());

Console.WriteLine(standartReportBuilder.BuildReportAndReturn());



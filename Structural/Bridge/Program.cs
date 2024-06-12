// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

/*
 * Problem: Bir nesne geliştirme sürecinde sürekli bir miras alarak ilerlerse kaos oluşabilir. 
 * Bu durumda nesneler arasındaki ilişkiyi ayrı bir hiyerarşi ile yönetmek istiyorsunuz.
 *
 */

// Solution: Bridge Design Pattern

SalesReport salesReport = new SalesReport();
salesReport.Format = new Html();

PerformanceReport performanceReport = new PerformanceReport();

performanceReport.Format = new Pdf();

// In this example, we have two types of reports: SalesReport and PerformanceReport.
// We also have two types of formats: Html and Pdf.
// We can create a report with a specific format by setting the Format property of the report object.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /*
     *   Senaryo: Karmaşık süreçlerden geçerek (farklı db, dosya okuma gibi...) rapor oluşturan bir nesnemiz var.
     *
     */


    // 1. Ne üreceğimizi belirleyen class

    public class Report
    {
        public string Title { get; set; }
        public string Data  { get; set; }
        public string Graph { get; set; }
    }

    // 2. Bu karmaşık aşamaları belirten interface veya abstract class

    public interface IReportBuilder
    {
        void SetTitle();
        void SetData();
        void SetGraph();
        Report GetReport();
    }

    // 3. Builder class

    public class ReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void SetTitle()
        {
            _report.Title = "Report Title";
        }

        public void SetData()
        {
            _report.Data = "Report Data";
        }

        public void SetGraph()
        {
            _report.Graph = "Report Graph";
        }

        public Report GetReport()
        {
            return _report;
        }
    }

    // 4. Director class

    public class ReportDirector
    {
        private IReportBuilder _reportBuilder;

        public ReportDirector(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

        public void BuildReport()
        {
            _reportBuilder.SetTitle();
            _reportBuilder.SetData();
            _reportBuilder.SetGraph();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IReportBuilder reportBuilder = new ReportBuilder();
            ReportDirector reportDirector = new ReportDirector(reportBuilder);

            reportDirector.BuildReport();

            Report report = reportBuilder.GetReport();

            Console.WriteLine(report.Title);
            Console.WriteLine(report.Data);
            Console.WriteLine(report.Graph);

            Console.ReadLine();
        }
    }

}

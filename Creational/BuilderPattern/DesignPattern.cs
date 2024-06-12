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

    public class WeeklySalesReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public Report GetReport()
        {
            return _report;
        }

        public void SetData()
        {
            _report.Data = "Weekly Sales Data";
        }

        public void SetGraph()
        {
            _report.Graph = "Weekly Sales Graph";
        }

        public void SetTitle()
        {
            _report.Title = "Weekly Sales Report";
        }

    }

    public class StandartReportBuilder : IReportBuilder
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

        public Report BuildReportAndReturn()
        {
            _reportBuilder.SetTitle();
            _reportBuilder.SetData();
            _reportBuilder.SetGraph();
            return _reportBuilder.GetReport();
        }
    }


}

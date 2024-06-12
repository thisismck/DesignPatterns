using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /*
     * Senaryo: Hem pdf hem de html olarak alabileceğimiz satış ve performans raporlarımız var.
     *          Geliştirme yapısını nasıl tasarlarsınız?
     *          
     * Çözüm: 
     * 
     */

    public class Report
    {
        public Format Format { get; set; }
    }
    public class Html : Format
    {

    }
    public class Pdf : Format
    {

    }
    public class SalesReport : Report
    {

    }
    public class Format
    {

    }
    public class PerformanceReport : Report
    {

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /*
     * Senaryo: İçerisinde sıralama yaptığınız bir koleksiyonunuz var. Sıralama algoritmanızı değiştirmek istiyorsunuz.
     *          Sıralama algoritması değiştiğinde bu değişimi nasıl yönetirsiniz?
     * 
     */

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductCollection
    {
        public void Sort(ISortStrategy sortStrategy)
        {
            sortStrategy.Sort();
        }
    }

    public interface ISortStrategy
    {
        void Sort();
    }

    public class QuickSort : ISortStrategy
    {
        public void Sort()
        {
            //write algortihm here

            Console.WriteLine("QuickSort Algorithm");

        }
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort()
        {
            //write algortihm here

            Console.WriteLine("BubbleSort Algorithm");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /*
     *  Senaryo: Bir sinema koltuk seçim ekranı yapıyorsunuz. 300 koltuk nesnesi bellekte olmalı.
     */

    public class Chair : ICloneable
    {
        public int No { get; set; }
        public string Letter { get; set; }
        public string DefaultColor { get; set; }

        public Cinema Cinema { get; set; }
        public Chair()
        {
            Console.WriteLine("Koltuk oluşturuluyor...");
            Console.WriteLine($"Başlangıç zamanı {DateTime.Now}");
            Thread.Sleep(10000); // Koltuğun oluşturulması 5 saniye sürüyor.
            Console.WriteLine($"Bitiş zamanı {DateTime.Now}");
            // Burada koltuğun default rengi, id'si ve harfi atanır.
            Cinema = new Cinema() { MovieName="Harry Potter", StartTime= DateTime.Now};
            No = 1;
            Letter = "A";
            DefaultColor = "Red";

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object Clone(bool isDeepClone)
        {
            return isDeepClone ? this.DeepClone() : this.MemberwiseClone();
        }

        private Chair DeepClone()
        {
            var chair = (Chair)this.MemberwiseClone();
            chair.Cinema = new Cinema()
            {
                MovieName = this.Cinema.MovieName,
                StartTime = this.Cinema.StartTime
            };
            return chair;
        }

        public override string ToString()
        {
            return $"No: {No} Letter: {Letter} DefaultColor: {DefaultColor} Movie {Cinema.MovieName}";
        }
    }

    public class Cinema
    {
        public string MovieName { get; set; }

        public DateTime StartTime { get; set; }
    }
}

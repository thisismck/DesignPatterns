using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /* Senaryo: Harita uygulaması geliştirdiğinizi düşünün. Bir turist, amacı doğrultusundan ziyaret edeceği 
     * lokasyonları görmektedir.
     * Örn: Amacı kültür olan bir turist; müze, tarihi yerler, sanat galerileri gibi lokasyonları görmek isteyebilir.
     * 
     * 
     */

    // 0. Haritada(Prodcut) gösterilecek ziyaret noktaları
    public interface IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }

    }

    public class SultanaAhmet : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    public class TopkapiSarayi : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    public class YerebatanSarnici : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    // 1. Harita(Prodcut): Haritada gösterilecek ziyaret noktaları

    public interface IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
        public void ShowMap();
    }
    // 2. Harita(Concrete Product): Kültür haritası ve inanç haritası

    public class CultureMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }

        public CultureMap()
        {
            VisitPoints = new List<IVisitPoint>();
        }

        public void ShowMap()
        {
            foreach (var visitPoint in VisitPoints)
            {
                Console.WriteLine($"Name: {visitPoint.Name}, Latitude: {visitPoint.Latitude}, Longitude: {visitPoint.Longitude}");
            }
        }
    }

    public class RelationMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }

        public RelationMap()
        {
            VisitPoints = new List<IVisitPoint>();
        }

        public void ShowMap()
        {
            foreach (var visitPoint in VisitPoints)
            {
                Console.WriteLine($"Name: {visitPoint.Name}, Latitude: {visitPoint.Latitude}, Longitude: {visitPoint.Longitude}");
            }
        }
    }

    // 3. Harita Oluşturucu(Creator): Harita oluşturucu sınıfı

    public abstract class MapGenerator
    {
        protected IMap? map;
        protected abstract void CreateMap();

        public MapGenerator()
        {
            CreateMap();
        }
    }

    // 4. Harita Oluşturucu(Concrete Creator): Kültür haritası ve inanç haritası oluşturucular

    public class RelationMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
           var religionMap = new RelationMap();
            religionMap.VisitPoints.Add(new SultanaAhmet() { Latitude = 41, Longitude = 28, Name = "Sultana Ahmet" });
            map = religionMap;

        }

        public IMap GenerateMap()
        {
            return map;
        }
    }
    
    public class CultureMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
            var cultureMap = new CultureMap();
            cultureMap.VisitPoints.Add(new TopkapiSarayi() { Latitude = 41, Longitude = 28, Name = "Topkapi Sarayi" });
            cultureMap.VisitPoints.Add(new YerebatanSarnici() { Latitude = 41, Longitude = 28, Name = "Yerebatan Sarnici" });
            map = cultureMap;
        }

        public IMap GenerateMap()
        {
            return map;
        }
    }

}

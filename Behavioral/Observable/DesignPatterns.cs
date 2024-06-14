using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    /*
     * Form2 Form 1'in alt formu olarak açılmıştır. Form 1'de bir butona tıklandığında Form 2 açılacaktır.
     * Form1'de renk değişince Form 2 subscribe ise renk değişikliğini algılayacaktır.
     * unsubscribe ise renk değişikliğini algılamayacaktır.
     * 
     */

    public interface IColorObserver
    {
        void OnColorChanged(Color color);
    }

    public interface IObservable
    {
        void Subscribe(IColorObserver observer);
        void Unsubscribe(IColorObserver observer);
        void Notify(Color color);
    }

    public class ColorObservable : IObservable
    {
        private List<IColorObserver> _observers = new List<IColorObserver>();

        public void Subscribe(IColorObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IColorObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Color color)
        {
            if(_observers == null || _observers.Count == 0)
                return;
            foreach (var observer in _observers)
            {
                observer.OnColorChanged(color);
            }
        }
    }


}

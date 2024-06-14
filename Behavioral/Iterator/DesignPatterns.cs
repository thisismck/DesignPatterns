using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
     * Senaryo: Bellekte bir kelime koleksiyonumuz var, belli algoritmalarla bu koleksiyonu dolaşmak istiyoruz.
     * 
     *  
     */


    public class IteratorClass : IEnumerator<string>
    {

        private readonly List<string> _words;

        private int _index = -1;
        public IteratorClass(List<string> words)
        {
            this._words = words;
            if (_words.Count > 0)
            {
                _index = 0;
            }
        }

        public string Current => _words[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _words.Count;
        }

        public void Reset()
        {
            _index = -1;
        }

        public void First()
        {
            _index = 0;
        }
        public void Last()
        {
            _index = _words.Count - 1;
        }

    }
}

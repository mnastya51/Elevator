using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    class FormValue<K, V>
    {
        private K key;
        private V value;
        public FormValue(K key, V value)
        {
            this.key = key;
            this.value = value;
        }

        public K getKey()
        {
            return key;
        }

        public V getValue()
        {
            return value;
        }
    }
}

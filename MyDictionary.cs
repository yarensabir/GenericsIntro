using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T1,T2>
    {
        T1[] key;
        T2[] value;
        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
        }
        public void Add(T1 newKey, T2 newValue)
        {
            T1[] tempT1 = key;
            T2[] tempT2 = value;

            key = new T1[key.Length + 1];
            for (int i = 0; i < tempT1.Length; i++)
            {
                key[i] = tempT1[i];
            }
            key[key.Length - 1] = newKey;

            value = new T2[value.Length + 1];
            for (int i = 0; i < tempT2.Length; i++)
            {
                value[i] = tempT2[i];
            }
            value[value.Length - 1] = newValue;
        }
    }
}

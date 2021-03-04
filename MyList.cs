using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor tab tab --> constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //new leyince yeni referans numarası alıyor, eski veriler kaybolmasın diye geçici değişkene atama yapıyoruz
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Lenght
        {
            get { return items.Length; }
        }

    }
}

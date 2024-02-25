using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Task2
{
    internal class ArrayContainer<T>
    {
        private T[] arrayContainer;

        public ArrayContainer()
        {
            arrayContainer = new T[0];
        }

        public void Add(T item)
        {
            T[] newArray = new T[arrayContainer.Length + 1];
            arrayContainer.CopyTo(newArray, 0);
            newArray[arrayContainer.Length] = item;
            arrayContainer = newArray;
        }

        public void Remove(int index)
        {
            T[] newArray = new T[arrayContainer.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = arrayContainer[i];
            }
            // сам index пропускается
            for (int i = index + 1; i < arrayContainer.Length; i++)
            {
                newArray[i - 1] = arrayContainer[i];
            }
            arrayContainer = newArray;
        }

        public void Find(int index)
        {
            Console.WriteLine(arrayContainer[index]);
        }

        public void Length()
        {
            Console.WriteLine(arrayContainer.Length);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    interface IMyList<T>
    {       
        void Add( T value);                       //+        
        int IndexOf(T item);                      //+ 
        void Remove();//last                      //+
        void Remove( T value);                    //+        
        void RemoveFirst();                       //+            
        int Count();                              //+
        void Clear();                             //+
        T[] ToArray();                            //+
        T GetElementByPosition(int index);        //+
        void Ubdate(T value, T valueUpdate, bool flag); // value, true/false //+ 


        void Insert(int index,  T item); 
        void RemoveIndex(int index);


    }
}

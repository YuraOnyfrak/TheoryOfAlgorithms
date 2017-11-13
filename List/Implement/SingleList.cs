using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class SimpleList<T> : IMyList<T>
    {

        private MyList<T> _head;
        private int _size;
        
        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new MyList<T>(){ Value = value };
            }
            else
            {
                MyList<T> item = _head;
                while (item.Next != null)
                {
                    item = item.Next;
                }
                item.Next = new MyList<T>(){ Value = value };
            }
            _size++;
        }


        public int Count()
        {
            return _size;
        }

        public void Clear()
        {
            _head = null;
        }

        public void Remove()
        {
            MyList<T> list = _head;
            while (list.Next != null)
            {
                if (list.Next.Next == null)
                {
                    list.Next = null;
                    _size--;
                    break;
                }
                list = list.Next;
            }  
            
        }

        public void Remove(T value) 
        {
            if (_head.Value.Equals(value) && _head.Next == null)//шукане значення збігається з головою
            {
                _head = null;
                _size--;
            }
            else if (_head.Value.Equals(value) && _head.Next != null)//шукане значення збігається з головою
            {
                MyList<T> itemNew = _head;
                _head = itemNew.Next;
                itemNew = null;
                _size--;

            }

            else
            {
                MyList<T> item = _head;

                while (item!= null)
                {
                   if (item.Next.Value.Equals(value))//шукане значення  в середині або в кінці списку
                    {
                        item.Next = item.Next.Next;
                        _size--;
                    }

                    item = item.Next;
                }
            }                    

         }
         
        public void RemoveIndex(int index)
        {
            int indexValue = 0;
            
            MyList<T> item = _head;

            if (index < _size)
            {
                while (item.Next != null)
                {

                    if (index == indexValue)
                    {
                       
                        {
                            if (_head.Value.Equals(item.Value) && _head.Next == null)//шукане значення збігається з головою
                            {
                                _head = null;
                                _size--;
                            }
                            else if (_head.Value.Equals(item.Value) && _head.Next != null)//шукане значення збігається з головою
                            {
                                MyList<T> itemNew = _head;
                                _head = itemNew.Next;
                                itemNew = null;
                                _size--;

                            }

                            else
                            {
                                MyList<T> items = _head;

                                while (items != null)
                                {
                                    if (items.Value.Equals(item.Value))//шукане значення  в середині або в кінці списку
                                    {
                                        items.Next = items.Next.Next;
                                        _size--;
                                    }

                                    items = items.Next;
                                }
                            }

                        }
                    }
                    indexValue++;
                    item = item.Next;
                }
            }
            else
            {
                Console.WriteLine("Element dont exist");
            }


            

        }        

        public void RemoveFirst()
        {
            MyList<T> item = _head;
            _head = item.Next;
            item = null;
            _size--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            MyList<T> item = _head;           
            while (item != null)
            {
                sb.AppendLine(item.Value.ToString());
                item = item.Next;
            }
            return sb.ToString();
        }

        public void Insert(int index, T value)
        {
            MyList<T> item = _head;
            MyList<T> item1 = _head;
            int count = 0;
            if (index==0)
            {
                _head = new MyList<T>() { Value = value };
                _head.Next = item;
            }
            else if (index == _size-1)
            {
                Add(value);
            }
            else
            {                
                while (item != null)
                {
                    
                    if (count == index)
                    {
                        item1 = item;
                        item.Value = value; 

                    }
                    else if(count>index && item.Next!=null)
                    {
                        item1 = item;
                        item1 = item1.Next;
                    }
                    count++;
                    item = item.Next;
                    
                }
               item = item1;
            }
            _size++;
        }

        public T GetElementByPosition(int index)
        {
            T[] array = new T[_size];
            MyList<T> item = _head;
            int indexValue = 0;

            while (item != null)
            {
                array[indexValue] = item.Value;
                indexValue++;
                item = item.Next;
            }
            return array[indexValue];
        }

        public void Ubdate(T value, T valueUpdate, bool flag)
        {
            MyList<T> item = _head;

            if (flag==true)
            {
                while (item != null)
                {
                    if (item.Value.Equals(value))
                    {
                        item.Value = valueUpdate;                       
                    }
                    item = item.Next;
                }
            }
            else
            {
                while (item != null)
                {
                    if (item.Value.Equals(value))
                    {
                        item.Value = valueUpdate;
                        break;
                    }
                    item = item.Next;
                }
            }

            }

        public T [] ToArray()
        {
            T[] array = new T[_size];
            MyList<T> item = _head;
            int index= 0;

            while (item != null)
            {
                array[index] = item.Value;
                index++;
                item = item.Next;
            }

                return array;
        }       

        public int IndexOf(T value)
        {
            int index = 0;   
            int count = 0; 
            MyList<T> item = _head;

                while (item.Next != null)
                {
                    count++;

                    if (item.Value.Equals(value))
                    {
                        index = count;
                        break;
                    }
                item = item.Next;
                }
            
            return index;
        }

        
    }
}

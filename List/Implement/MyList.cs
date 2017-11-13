using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyList<T> 
    {
        public T Value { get; set; }
        public MyList<T> Next { get; set; }      

        
    }
}

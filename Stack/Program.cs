using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Stack
    {
        private String[] array;
        private int size;

        public Stack(String[] array) 
        {
            this.size = 1;
            this.array = array;
        }
        public bool Empty()
        {
            if (size == 0) return false;
            else return true;
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public void PUSH(String something)
        {
            array.Push(something);
        }
        public String POP()
        {
            if (Empty() == true)
            {
                return(array.Pop);
            } else return("error");
        }
        public String PEEK()
        {
            if (Empty() == true)
            {
                return (array.Peek);
            } else return ("error");
        }
        public void CLEAR()
        {
            array.Clear();
        }
    }
}

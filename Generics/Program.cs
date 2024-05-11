using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystack<int> mystack = new Mystack<int>(5);
            mystack.push(1);
            mystack.push(2);
            mystack.push(3);
            mystack.push(4);
            mystack.push(5);
           // mystack.push(6);
            // int Pop=mystack.pop();
           // Console.WriteLine(Pop);
                
        }
    }
    public class Mystack<T>
    {
        T[] stack;
        public Mystack(int size)
        {
            stack = new T[size];
            
        }
       public int pos= -1;
        public void push(T i)
        {
            if(pos==stack.Length-1)
            {
                Console.WriteLine("Stack is full");
            }
            stack[++pos] = i;
        }
        public T pop()
        {
            if(pos==-1)
            {
                Console.WriteLine("stack is Empty");
            }
            return stack[pos--];
        }
       
    }
}

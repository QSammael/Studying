using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList todo = new LinkedList();
            StreamReader lector = new StreamReader("wordspace.txt");
            while (true)
            {
                string leer = lector.ReadLine();
                if (leer == null)
                {
                    break;
                }
                todo.Add(leer);
            }
            //  todo.Remove(0);
            // todo.Insert(5,"boook");
            todo.GetElement(1);
            {
                Console.Write(todo.GetElement(6));//why i still need to write a number
            }
           todo.GetLength();
            {
                Console.Write(todo.GetLength());
            }
      //      int contar = todo.GetLength()-1;
//            while (contar >= 0)
//            {
//                Console.WriteLine(todo.GetElement(contar));
//                contar = contar - 1;
//            }
            
            Console.ReadKey();
        }
    }
}

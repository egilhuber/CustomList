using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            MyList<int> newList = new MyList<int>();

            MyList<int> storeList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            newList.Add(5);
            newList.Add(6);
            newList.Add(3);
            newList.Add(8);

            storeList = myList - newList;
            for (int i = 0; i < storeList.Count; i++)
            {
                Console.WriteLine(storeList[i]);
            }
            
            Console.ReadLine();

            //last line of main block
        }
    }
}

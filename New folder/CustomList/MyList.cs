using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T> 
    {
        //member variables
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }


        T[] items;
        // public bool isRemoved;
        public bool inArray;
        public int whichIndex;
        public bool place = true;
        public int x = 1;



        //ctor
        public MyList()
        {
            capacity = 0;
            
        }

        //member methods
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }



        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public void Add(T value)
        {
            Count++; //increases count/quantity of values in the array to 1
            if (Count == 1)
            {
                Capacity = 1; //sets capacity of the array to 1 slot 
                T[] tempItems = new T[Capacity]; //creates temporary array
                
                tempItems[0] = value; //adds value to array at index 0 because if the count of items we want in our array is 1, we needs to put that one thing at index 0
                
                items = tempItems; //pushes data from temporary array to og array
                


                for (int i = 0; i < 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i]; //at each index
                }



                //add value to array
                //update member variable reference
            }
            else if (Count > 1 && Count < 4 && Count % 4 != 0)
            {
                Capacity = 4;
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < Count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }

                tempItems[Count - 1] = value;
                
                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
            else if (Count > 4 && Count % 4 != 0)
            {
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < Count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }

                tempItems[Count - 1] = value;

                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
            else if (Count % 4 == 0 && Count == Capacity)
            {
                Capacity = Count * 2;
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < Count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }                

                tempItems[Count - 1] = value;

                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
        }

        public bool InArray(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(value))
                {
                    inArray = true;
                    return inArray;
                }
                
            }
            return place; 
        }

        public int Where(T value)
        {
            for (int j = 0; j < Count; j++)
            {
                if (items[j].Equals(value))
                {
                    whichIndex = j;
                    return whichIndex;
                }
            }
            return x;
        }

        public bool Remove(T value)
        {
            bool isRemoved = false;
            InArray(value);

            Where(value);

            if (inArray == true)
            {
                if (Count == 1)
                {
                    Capacity = 0; 
                    T[] tempItems = new T[Capacity]; 
                    items = tempItems;
                    isRemoved = true;
                    return isRemoved;
                }

                else if (Count > 1 && Count < 4 && Count % 4 != 0)
                {
                    Capacity = 4;
                    T[] tempItems = new T[Capacity];
                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex + 1; i < Count; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i - 1] = items[i];
                    }

                    items = tempItems; //pushes data from temporary array to og array
                    Count--;
                    isRemoved = true;
                    return isRemoved;

                }
                else if (Count > 4 && Count % 4 != 0)
                {
                    T[] tempItems = new T[Capacity];

                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex + 1; i < Count; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i - 1] = items[i];
                    }


                    items = tempItems; //pushes data from temporary array to og array
                    Count--;
                    isRemoved = true;
                    return isRemoved;

                }
                else if (Count % 4 == 0 && Count == (0.5 * Capacity))
                {
                    Capacity = Count / 2;
                    T[] tempItems = new T[Capacity];

                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex + 1; i < Count; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i - 1] = items[i];
                    }


                    items = tempItems; //pushes data from temporary array to og array
                    Count--;
                    isRemoved = true;
                    return isRemoved;

                }
                else
                {
                    return place;
                }
               
            }
            else
            {
                return isRemoved;
            }
            

        }

        //

        public int GreaterCapacity(int cap1, int cap2)
        {
            if (cap1 > cap2)
            {
                Capacity = cap1 * 2;
                return Capacity;
            }
            else if (cap2 > cap1)
            {
                Capacity = cap2 * 2;
                return Capacity;
            }
            else
            {
                Capacity = cap1 + cap2;
                return Capacity;
            }
        }

        //



        public static MyList<T> operator +(MyList<T> l1, MyList<T> l2)
        {
            MyList<T> aList = new MyList<T>();
            int cap = l1.Capacity + l2.Capacity;
            T[] tempItems = new T[cap];
            int smallCount = l1.Count + l2.Count;

            for (int i = 0; i < l1.Count; i++)
            {
                aList.Add(l1[i]);
            }

            for (int i = 0; i < smallCount; i++) 
            {
                aList.Add(l2[i]);

            }

            return aList;
            
        }


        public static MyList<T> operator -(MyList<T> l1, MyList<T> l2)
        {
            MyList<T> aList = new MyList<T>();
            int cap = l1.Capacity + l2.Capacity;
            T[] tempItems = new T[cap];
            int smallCount = l1.Count + l2.Count;

            //logic here

            return aList;
        }

        public void Zip(MyList<T> l1, MyList<T> l2)
        {

        }

        //last line of main block
    }
}





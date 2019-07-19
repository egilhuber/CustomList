using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        //member variables
        public int count = 0;
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
        public bool isRemoved;
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


        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public void Add(T value)
        {
            count++; //increases count/quantity of values in the array to 1
            if (count == 1)
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
            else if (count > 1 && count < 4 && count % 4 != 0)
            {
                Capacity = 4;
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }

                tempItems[count - 1] = value;
                
                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
            else if (count > 4 && count % 4 != 0)
            {
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }

                tempItems[count - 1] = value;

                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
            else if (count % 4 == 0 && count == Capacity)
            {
                Capacity = count * 2;
                T[] tempItems = new T[Capacity];

                for (int i = 0; i < count - 1; i++) //copies data from old array to new array
                {
                    tempItems[i] = items[i];
                }                

                tempItems[count - 1] = value;

                items = tempItems; //pushes data from temporary array to og array

                //add value to array
                //copy values over
                //update member variable reference
            }
        }

        public bool InArray(T value)
        {
            for (int i = 0; i < count; i++)
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
            for (int j = 0; j < count; j++)
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

            InArray(value);

            Where(value);

            if (inArray == true)
            {
                if (count == 1)
                {
                    Capacity = 0; 
                    T[] tempItems = new T[Capacity]; 
                    items = tempItems;
                    isRemoved = true;
                    return isRemoved;
                }

                else if (count > 1 && count < 4 && count % 4 != 0)
                {
                    Capacity = 4;
                    T[] tempItems = new T[Capacity];

                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex; i > whichIndex; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i] = items[i];
                    }

                    items = tempItems; //pushes data from temporary array to og array
                    count--;
                    isRemoved = true;
                    return isRemoved;

                }
                else if (count > 4 && count % 4 != 0)
                {
                    T[] tempItems = new T[Capacity];

                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex; i > whichIndex; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i] = items[i];
                    }


                    items = tempItems; //pushes data from temporary array to og array
                    count--;
                    isRemoved = true;
                    return isRemoved;

                }
                else if (count % 4 == 0 && count == (0.5 * Capacity))
                {
                    Capacity = count / 2;
                    T[] tempItems = new T[Capacity];

                    for (int i = 0; i < whichIndex; i++) //copies data from old array to new array up to removed value
                    {
                        tempItems[i] = items[i];
                    }

                    for (int i = whichIndex; i > whichIndex; i++) //copies data from old array to new array after removed value
                    {
                        tempItems[i] = items[i];
                    }


                    items = tempItems; //pushes data from temporary array to og array
                    count--;
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
                return place;
            }
            

        }

        //last line of main block
    }
}





using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class TestCustomList
    {
        [TestMethod]
        public void Method_Condition_ExpectedResult()
        {
            //test condition



            //arrange



            //act



            //assert



        }



        [TestMethod]
        public void Add_AddToEmptyList_ItemToIndexZero()
        {
            //test condition
            
            /*When an item is added to an empty list, it should go to [0]*/

            //arrange

            MyList<int> test = new MyList<int>();
            int expected = 5;
            int actual;


            //act

            test.Add(5);
            actual = test[0];

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddToEmptyList_CountIncreaseOneIncrement()
        {
            //test condition

            /*When an item is added to an empty list, the count should increase by one*/

            //arrange

            MyList<int> test = new MyList<int>();
            int expected = 1;
            int actual;

            //act

            test.Add(5);
            actual = test.Count;

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddToPopulatedList_ItemAddedToEndOfList()
        {
            //test condition

            /*When an item is added to a populated list, it should go to the end*/

            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 5;
            int actual;

            //act

            test.Add(5);
            actual = test[3];

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddToPopulatedList_CountIncreaseByOne()
        {
            //test condition

            /*When an item is added to a populated list, the count should increase*/

            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 4;
            int actual;

            //act

            test.Add(5);
            actual = test.Count;

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddItemToListWithFullArray_ItemIsAddedToList()
        {
            //test condition

            /*When something is added to a list whose inner array is full, it should still add the item*/

            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 5;
            int actual;


            //act

            test.Add(5);
            actual = test[3];

            //assert

            Assert.AreEqual(expected, actual);

        }

        //last line of main block
    }
}

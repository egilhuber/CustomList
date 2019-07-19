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
            actual = test.count;

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
            actual = test.count;

            //assert

            Assert.AreEqual(expected, actual);

        }

        //

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Reduce_EmptyList_ThrowException()
        {
            //test condition
            //reduce empty list throw exception

            //arrange

            MyList<int> test = new MyList<int>();
            int expected;

            //act

            test.ReduceAt(0);

            //assert



        }


        [TestMethod]
        public void Reduce_PopulatedList_ItemIsRemovedFromList()
        {
            //test condition
            //reduce populated list by one item


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected;
            int actual;

            //act

            test.ReduceAt(1);
            expected = 4;
            actual = test[1];

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Reduce_PopulatedList_CountDecreasesByOne()
        {
            //test condition
            //reduce populated list count decrease by one


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected;
            int actual;

            //act

            test.ReduceAt(1);
            expected = 2;
            actual = test.count;

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Reduce_PopulatedList_CapacityDecreases()
        {
            //test condition
            //reduce populated list capacity decrease


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected;
            int actual;

            //act

            test.ReduceAt(1);
            expected = 4;
            actual = test.Capacity;

            //assert

            Assert.AreEqual(expected, actual);

        }


        //last line of main block
    }
}

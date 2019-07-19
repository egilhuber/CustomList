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
        public void Remove_EmptyList_CountRemainsZero()
        {
            //test condition
            //reduce empty list count should equal 0

            //arrange

            MyList<int> test = new MyList<int>();
            int expected = 0;
            int actual = test.count;

            //act

            test.Remove(3);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PopulatedList_CountDecreasesByOne()
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

            test.Remove(3);
            expected = 2;
            actual = test.count;

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_PopulatedList_CapacityDecreases()
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

            test.Remove(1);
            expected = 4;
            actual = test.Capacity;

            //assert

            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        public void Remove_PopulatedListNonExistingItemNotRemoved_FalseBool()
        {
            //test condition
            //return bool on whether something returned or not (not)


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            bool expected = false;
            bool actual = test.isRemoved;

            //act

            test.Remove(6);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PopulatedListNonexistentItemNotRemoved_CountDoesNotChange()
        {
            //test condition
            //try to remove a thing that's not in the list


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 3;
            int actual = test.count;

            //act

            test.Remove(6);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PopulatedListItemRemoved_CountDoesChange()
        {
            //test condition
            //try to remove a thing that's not in the list


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 2;
            int actual = test.count;

            //act

            test.Remove(2);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PullItemWithMultipleOccurances_FirstInstanceInListRemoved()
        {
            //test condition
            //multiple occurances which one gets pulled - go with first USE A FOR LOOPWITH AN IF STATEMENT IN IT


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(3);
            test.Add(5);

            int expected = 4;
            int actual = test[1];

            //act

            test.Remove(3);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PopulatedList_ItemIsRemovedFromList()
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

            test.Remove(3);
            expected = 4;
            actual = test[1];

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_PopulatedListExistingItemRemoved_TrueBool()
        {
            //test condition
            //return bool on whether something returned or not


            //arrange

            MyList<int> test = new MyList<int>();
            test.Add(2);
            test.Add(3);
            test.Add(4);
            bool expected = true;
            bool actual = test.isRemoved;

            //act

            test.Remove(2);

            //assert

            Assert.AreEqual(expected, actual);

        }




        //last line of main block
    }
}

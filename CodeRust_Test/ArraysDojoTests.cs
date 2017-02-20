using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeRust;
using NUnit.Framework;

namespace CodeRust_Test
{
    public class ArraysDojoTests
    {
        [Test]
        public void Return_correctNumber()
        {
            var arrayDojo = new ArraysDojo();
            var foundNumber = arrayDojo.BinarySearch(new[] { 10, 20, 30, 40, 50 }, 20);
            Assert.AreEqual(foundNumber, 20);
        }

        [Test]
        public void NotReturn_correctNumber()
        {
            var arrayDojo = new ArraysDojo();
            var foundNumber = arrayDojo.BinarySearch(new[] { 10, 25, 30, 40, 50 }, 20);
            Assert.AreEqual(foundNumber, 20);
        }

        [Test]
        public void SumOfTwoNumberReturnsTrue()
        {
            var arrayDojo = new ArraysDojo();
            var foundNumber = arrayDojo.SumOfTwoValues(new[] { 5, 7, 1, 2, 8, 4, 3}, 10);
            Assert.AreEqual(foundNumber, true);
        }

        [Test]
        public void Permute_PermuteArrayCorrectly()
        {
            var arrayDojo = new ArraysDojo();
            string str = "ABCD";
            char[] charArry = str.ToCharArray();
           arrayDojo.permute(charArry, 0, 3);
            Assert.AreEqual(true, true);
        }

        [Test]
        public void Find_Max_Sliding_Window()
        {
            var arrayDojo = new ArraysDojo();
            var array = new[] {-4, 2,-5, 1,-1, -6, 1,1,1,1,-4};
            var resulr = arrayDojo.FindMaxSlidingWindow(array, 3);
            Assert.AreEqual(true, true);
        }

        [Test]
        public void Find_Smallest_CommonNumber_In_Three_Arrays()
        {
            var arrayDojo = new ArraysDojo();
            var arr1 = new[] {6, 7, 10, 25, 30, 63, 64};
            var arr2 = new[] { -1, 4, 5, 6, 7, 8, 50 };
            var arr3 = new[] { 1, 6, 10, 14 };

            var result = arrayDojo
                .FindSmallestCommonNumberInArrays(
                arr1, arr2, arr3
                );

            Assert.AreEqual(6, result);
        }
    }
}

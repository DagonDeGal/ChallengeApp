﻿namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenCompareTwoNumbers_ShouldGiveCorrectResult()
        {
            //arrage
            int number1 = 12;
            int number2 = 24;
            //act 

            //assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void WhenPriceCompare_ShouldReturnResult()
        {
            //arrage
            double price1 = 63.32;
            double price2 = 63.32;
            float price3 = 83.45f;
            float price4 = 88.95f;
            //act 

            //assert
            Assert.AreEqual(price1, price2);
            Assert.AreNotEqual(price3, price4);

        }
        [Test]
        public void GetUserShouldReturnDifferent()
        {
            //arrage
            string user1 = "Tomasz";
            string user2 = "Tomasz";

            //act 


            //assert
            Assert.AreEqual(user1, user2);
        }
    }
}
       
       
  



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG8170_assignment_2;

namespace PROG8170_assignment_2_test
{
    public class ClassTest
    {
        //Test Case 1 for circle Get Radius method
        [Test]
        public void TestGetRadiusWithDefaultRadius()
        {
            Circle crlObj = new Circle();
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(1, actualValue);
        }

        //Test Case 2 for circle Get Radius method
        [Test]
        public void TestGetRadiusWithSomeValue()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(5);
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(3, actualValue);
        }

        //Test Case 3 for circle Get Radius method
        [Test]
        public void TestGetRadiusWithNegativeValue()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(-3);
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(1, actualValue);
        }

        //Test Case 1 for Set Radius method
        [Test]
        public void TestSetRadiusWithDefaultRadius()
        {
            Circle crlObj = new Circle();
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(1, actualValue);
        }

        //Test Case 2 for Set Radius method
        [Test]
        public void TestSetRadiusWithSomeValue()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(5);
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(5, actualValue);
        }

        //Test Case 3 for Set Radius method
        [Test]
        public void TestSetRadiusWithNegativeRadius()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(-5);
            int actualValue = crlObj.GetRadius();
            Assert.AreEqual(1, actualValue);
        }

        [Test]
        public void TestGetCircumferenceWithDefaultValue()
        {
            //Arrange
            Circle crlObj = new Circle();
            crlObj.GetRadius();
            //Act
            double actualValue = crlObj.GetCircumference();
            //Assert
            Assert.AreEqual(5.53, actualValue);
        }

        [Test]
        public void TestGetCircumferenceWithSomeRadiusValue()
        {
            Circle crlObj = new Circle();

            crlObj.SetRadius(5);
            double actualValue = crlObj.GetCircumference();
            Assert.AreEqual(31.400000000000002d, actualValue);
        }

        [Test]
        public void TestGetCircumferenceWithNegativeRadius()
        {
            Circle crlObj = new Circle();

            crlObj.SetRadius(-6);
            double actualValue = crlObj.GetCircumference();
            Assert.AreEqual(6.28, actualValue);
        }

        //Test Cases for Get Area method
        [Test]
        public void TestGetAreaWithDefaultRadius()
        {
            Circle crlObj = new Circle();
            double actualValue = crlObj.GetArea();
            Assert.AreEqual(3.14, actualValue);
        }

        [Test]
        public void TestGetAreaWithRadius5()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(5);
            double actualValue = crlObj.GetArea();
            Assert.AreEqual(78.5, actualValue);
        }

        [Test]
        public void TestGetAreaWithRadius0()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(0);
            double actualValue = crlObj.GetArea();
            Assert.AreEqual(3.14, actualValue);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Here");
        }
    }
}

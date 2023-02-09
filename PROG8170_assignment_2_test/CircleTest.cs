using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG8170_assignment_2;

namespace PROG8170_assignment_2_test
{
    public class CircleTest
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
            crlObj.SetRadius(3);
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

        //Test Case 1 for Get circumference
        [Test]
        public void TestGetCircumferenceWithDefaultValue()
        {
            Circle crlObj = new Circle();
            crlObj.GetRadius();
            
            double actualValue = crlObj.GetCircumference();
            Assert.AreEqual(6.28, actualValue);
        }

        //Test Case 2 for get circumference with some value
        [Test]
        public void TestGetCircumferenceWithSomeRadiusValue()
        {
            Circle crlObj = new Circle();

            crlObj.SetRadius(3);
            double actualValue = crlObj.GetCircumference();
            Assert.AreEqual(18.84, actualValue);
        }

        //Test Case 3 for get circumference with negative value
        [Test]
        public void TestGetCircumferenceWithNegativeRadius()
        {
            Circle crlObj = new Circle();

            crlObj.SetRadius(-6);
            double actualValue = crlObj.GetCircumference();
            Assert.AreEqual(6.28, actualValue);
        }

        //Test Case 1 for Get area with default value
        [Test]
        public void TestGetAreaWithDefaultRadius()
        {
            Circle crlObj = new Circle();
            double actualValue = crlObj.GetArea();
            Assert.AreEqual(3.14, actualValue);
        }

        //Test Case 2 for Get area with some radius value
        [Test]
        public void TestGetAreaWithSomeRadiusValue()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(3);
            double actualValue = crlObj.GetArea();

            Console.WriteLine(actualValue);
            Assert.AreEqual(28.26, actualValue);
        }

        //Test Case 3 for Get area with zero radius value
        [Test]
        public void TestGetAreaWithZeroRadius()
        {
            Circle crlObj = new Circle();
            crlObj.SetRadius(0);
            double actualValue = crlObj.GetArea();
            Assert.AreEqual(3.14, actualValue);
        }
    }
}

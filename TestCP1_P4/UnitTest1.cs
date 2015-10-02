using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCP1_P4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRunWindow()
        {
            P4_2.P4Form _form = new P4_2.P4Form();
        }
        [TestMethod]
        public void TestCalculatSideC()
        {
            
            Assert.AreEqual(5, P4_2.MyMathFunctions.calculateSideC(3, 4, 90));
            Assert.AreEqual(10, P4_2.MyMathFunctions.calculateSideC(6, 8, 90));
        }

        


        [TestMethod]
        public void Test_fahrenheit_to_celsius()
        {
            Assert.AreEqual(-7, P4_2.MyMathFunctions.fahrenheitToCelsius(20));
            Assert.AreEqual(-12, P4_2.MyMathFunctions.fahrenheitToCelsius(10));
            Assert.AreEqual(-40, P4_2.MyMathFunctions.fahrenheitToCelsius(-40));
        }
        
        [TestMethod]
        public void Test_celsius_to_fahrenheit()
        {
            Assert.AreEqual(68, P4_2.MyMathFunctions.celsiusToFahrenheit(20));
            Assert.AreEqual(50, P4_2.MyMathFunctions.celsiusToFahrenheit(10));
            Assert.AreEqual(-40, P4_2.MyMathFunctions.celsiusToFahrenheit(-40));
        }
        [TestMethod]
        public void Test_calculate_circumference_of_circle()
        {
            Assert.AreEqual(12.57, P4_2.MyMathFunctions.circumferenceOfCircle(2));
            Assert.AreEqual(75.4, P4_2.MyMathFunctions.circumferenceOfCircle(12));
            Assert.AreEqual(34.56, P4_2.MyMathFunctions.circumferenceOfCircle(5.5));
            Assert.AreEqual(43.98, P4_2.MyMathFunctions.circumferenceOfCircle(7));
        }

        [TestMethod]
        public void Test_calculate_area_of_a_circle()
        {

            Assert.AreEqual(12.57, P4_2.MyMathFunctions.areaOfCircle(2));
            Assert.AreEqual(314.16, P4_2.MyMathFunctions.areaOfCircle(10));
            Assert.AreEqual(95.03, P4_2.MyMathFunctions.areaOfCircle(5.5));
            Assert.AreEqual(153.94, P4_2.MyMathFunctions.areaOfCircle(7));
        }
        [TestMethod]
        public void Test_returns_theSameStringDoubled()
        {
            string r_string = this.randomString(25);
            Assert.AreEqual($"{r_string}{r_string}", P4_2.MyMathFunctions.returnSameStringDoubled(r_string));
        }

        

        [TestMethod]
        public void Test_returns_number_squared()
        {
            double number = 25;
            double number_squared = Math.Pow(number,2);
            Assert.AreEqual(number_squared, P4_2.MyMathFunctions.getNumberSquared(number));
        }

        [TestMethod]
        public void Test_returns_remainder_of_two_numbers_divided()
        {

            int number2 = this.random_number(1, 101);
            int number1 = this.random_number(100, 10000);
            int remainder = number1 % number2;
            Assert.AreEqual(remainder, P4_2.MyMathFunctions.getRemainder(number1, number2));
        }
        /**/
        /* Don't worry about anything below this point */
        private Random _randomGenerator;
        private int random_number(int v1, int v2)
        {
            if(_randomGenerator== null)
            {
                _randomGenerator = new Random();
            }
            return _randomGenerator.Next(v1, v2); 
        }
        private string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private string randomString(int v)
        {
            char[] stringChars = new char[8];
            
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random_number(0,chars.Length)];
            }

            return new String(stringChars);
            
        }
        
    }
}

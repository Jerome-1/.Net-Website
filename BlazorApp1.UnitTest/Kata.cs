using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp1.Pages.Kata;

namespace BlazorApp1.UnitTest
{
    public class Kata
    {
        [Fact]
        public void FizzBuzz()
        {
            //ARRANGE
            var fizz = 9;
            var buzz = 10;
            var fizzbuzz = 15;
            var num = new DummyCLass();
            //ACT
            var pinger = num.CaughtIt(fizz);
            var pingee = num.CaughtIt(buzz);
            var pinged = num.CaughtIt(fizzbuzz);
            //ASSERT
            Assert.Equal("fizzbuzz", pinged);
            Assert.Equal("fizz", pinger);
            Assert.Equal("buzz", pingee);
            
        }

        [Fact]

        public void Validator()
        {
            //ARRANGE
            var str = "ThisisCorrectCharacters";
            var c = new DummyCLass();
            //ACT
            var reader = c.Characters(str);
            var reader2 = c.Spaces(str);
            var reader3 = c.Digit(str);
            var reader4 = c.Capitals(str);
            //ASSERT
            var checker = true;
            Assert.True(checker == reader3, "There is a digit in string");
            Assert.True(checker == reader4, "String must contain one capital letter.");
            Assert.True(checker == reader2, "There are spaces");
            Assert.True(reader >= 8, "Incorrect number of characters.");
        }

        [Fact]
        public void StrCalculator()
        {
            //ARRANGE
            var number = "11";
            var c = new DummyCLass();
            //ACT
            var stuff = c.Calculate(number);
            //ASSERT
            var checker = 2;
            Assert.Equal(checker, stuff);
        }
    }
}

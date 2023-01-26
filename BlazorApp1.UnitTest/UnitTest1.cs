using BlazorApp1.Pages.Kata;

namespace BlazorApp1.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //ARRANGE 
            var numbers = new List<int> { 1, 2, 3, 4 };
            //ACT
            var summedList = new Summation();
            var summedListString = summedList.SumOfArray(numbers);

            //ASSERT
            var ExpectedString = 10;
            Assert.Equal(ExpectedString, summedListString);
        }

        [Fact]
        public void Test2()
        {
            //ARRANGE 
            var name1 = new DummyCLass { Name = "jerome"};
            var name2 = name1;

            //ASSERT
            Assert.Equal(name1, name2);
        }

        [Fact]

        public void Test3()
        {
            //ARRANGE
            string? line = "The choice was red or green";
            var input = new DummyCLass();
            //ACT
            var countVowel = input.Counter(line);
            //ASSERT
            var ExpectecdVowel = 9;
            var ExpectedConsonants = 13;
            Assert.Equal(ExpectedConsonants, countVowel[1]);
            Assert.Equal(ExpectecdVowel, countVowel[0]);
        }

        [Fact]

        public void Test4()
        {
            //ARRANGE
            var number = 35231;
            var input = new DummyCLass();
            //ACT
            var inputReversed = input.Reversi(number);
            //ASSERT
            int[] reversedArray = {1, 3, 2, 5, 3};
            Assert.Equal(reversedArray, inputReversed);
        }
        [Fact]
        public void Test5()
        {
            //ARRANGE
            var number = 28374618;
            var input = new DummyCLass();
            //ACT
            var inputReversed = input.Reversi(number);
            //ASSERT
            int[] reversedArray = { 8,1,6,4,7,3,8,2};
            Assert.Equal(reversedArray, inputReversed);
        }
    }
}
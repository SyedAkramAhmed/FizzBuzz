using NUnit.Framework;
namespace FizzBuzzTest
{
    public class Tests
    {
        [TestFixture]
        public class FizzBuzzTests
        {
            [Test]
            public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
            {
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(3), Is.EqualTo("Fizz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(6), Is.EqualTo("Fizz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(9), Is.EqualTo("Fizz"));
            }

            [Test]
            public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
            {
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(5), Is.EqualTo("Buzz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(10), Is.EqualTo("Buzz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(20), Is.EqualTo("Buzz"));
            }

            [Test]
            public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
            {
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(15), Is.EqualTo("FizzBuzz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(30), Is.EqualTo("FizzBuzz"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(45), Is.EqualTo("FizzBuzz"));
            }

            [Test]
            public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
            {
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(7), Is.EqualTo("7"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(17), Is.EqualTo("17"));
                Assert.That(FizzBuzz.FizzBuzz.GetOutput(1), Is.EqualTo("1"));
            }
        }
    }
}
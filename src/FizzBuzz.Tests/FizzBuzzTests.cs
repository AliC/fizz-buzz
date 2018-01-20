using Xunit;
using FizzBuzz.Domain;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact(DisplayName = "Technical exercise Step 3")]
        public void When_Multiples_Of_Three_And_Five_And_Number_Contains_Three_Rules_Are_In_Play_Then_Numbers_Convert_To_Fizz_And_Buzz_And_Lucky()
        {
            var expectedOutput = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz";

            var actualOutput = FizzBuzzer.Run();

            Assert.StartsWith(expectedOutput, actualOutput);
        }

        [Fact(DisplayName = "Technical exercise Step 3")]
        public void When_Program_Runs_Then_A_Report_Is_Included_In_Output()
        {
            var expectedOutputs = new[] { "fizz: 4", "buzz: 3", "fizzbuzz: 1", "lucky: 2", "integer: 10" };

            var actualOutput = FizzBuzzer.Run();

            Assert.Contains(expectedOutputs[0], actualOutput);
            Assert.Contains(expectedOutputs[1], actualOutput);
            Assert.Contains(expectedOutputs[2], actualOutput);
            Assert.Contains(expectedOutputs[3], actualOutput);
            Assert.Contains(expectedOutputs[4], actualOutput);
        }
    }
}

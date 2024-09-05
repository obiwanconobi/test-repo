using NUnit.Framework;
using shearwell_test.Helpers;
using System.Runtime.CompilerServices;

namespace shearwell_test.Tests
{
    [TestFixture]
    public class UnitTests
    {

       
        [TestCase("UK123", false)]
        [TestCase("UK1234567 12345", true)]
        public void TestTagValidation(String input, bool expected)
        {
            //arrange
            FormHelpers formHelper = new FormHelpers();

            //act
            var result = formHelper.ValidateTagInput(input);

            //assert
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}

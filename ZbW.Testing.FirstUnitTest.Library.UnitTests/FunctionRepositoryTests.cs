using NUnit.Framework;

namespace ZbW.Testing.FirstUnitTest.Library.UnitTests
{
    [TestFixture]

    public class FunctionRepositoryTests
    {
        [Test]
        public void TestNumber15()
        {
            var sut = new FunctionRepository();
            var result = sut.GreaterThan10(15);
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestIsValidEMailadress()
        {
            var sut = new FunctionRepository();
            var result = sut.IsValidEMailadress("sadf@das.com");
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestIsStringLongerThan10()
        {
            var sut = new FunctionRepository();
            var result = sut.IsStringLongerThan10("zdhdddkdagod");
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestGetStringLenght()
        {
            var sut = new FunctionRepository();
            var result = sut.GetStringLength("abcdefghiyklmnopqrstuvwxyz");
            Assert.That(result, Is.EqualTo(26));
        }

        [Test]
        public void TestAreNumbersInString()
        {
            var sut = new FunctionRepository();
            var result = sut.AreNumbersInString("asdfadsfasdf0");
            Assert.That(result, Is.True);
        }

        [Test, Category("short")]
        public void IsIntValid()
        {
            var sut = new FunctionRepository();
            var result = sut.IsIntValid("435435");
            Assert.That(result, Is.True);
        }
    }
}

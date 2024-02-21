using System;
using EvaluationSampleCode;

namespace PratiqueWithCode_Groupe2.UnitTest
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void Parse_ValidNumber_ReturnsPhoneNumber()
        {
            // Arrange
            var phoneNumberString = "0123456789";

            // Act
            var phoneNumber = PhoneNumber.Parse(phoneNumberString);

            // Assert
            Assert.IsNotNull(phoneNumber);
            Assert.AreEqual("012", phoneNumber.Area);
            Assert.AreEqual("345", phoneNumber.Major);
            Assert.AreEqual("6789", phoneNumber.Minor);
        }

        [TestMethod]
        public void Parse_EmptyNumber_ThrowsArgumentException()
        {
            // Arrange
            var phoneNumberString = "";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumberString));
        }

        [TestMethod]
        public void Parse_NumberTooShort_ThrowsArgumentException()
        {
            // Arrange
            var phoneNumberString = "012345678";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumberString));
        }

        [TestMethod]
        public void Parse_NumberTooLong_ThrowsArgumentException()
        {
            // Arrange
            var phoneNumberString = "01234567890";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumberString));
        }

    }
}


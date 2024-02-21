﻿using System;
using EvaluationSampleCode;

namespace PratiqueWithCode_Groupe2.UnitTest
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetStrongFormat_ReturnsCorrectFormat()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "Hello World";

            // Act
            var result = helper.GetStrongFormat(content);

            // Assert
            Assert.AreEqual("<strong>Hello World</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ReturnsCorrectFormat()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var content = "Hello World";

            // Act
            var result = helper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual("<i>Hello World</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ReturnsCorrectFormat()
        {
            // Arrange
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item 1", "Item 2", "Item 3" };

            // Act
            var result = helper.GetFormattedListElements(contents);

            // Assert
            Assert.AreEqual("<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", result);
        }
    }
}


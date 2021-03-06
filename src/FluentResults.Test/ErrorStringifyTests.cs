﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentResults.Test
{
    [TestClass]
    public class ErrorStringifyTests
    {
        [TestMethod]
        public void EmptyErrorToString_OnlyType()
        {
            // Act
            var error = new Error();

            // Assert
            error.ToString().Should().Be("Error");
        }
        
        [TestMethod]
        public void ErrorWithMessageToString_TypeWithMessage()
        {
            // Act
            var error = new Error()
                .WithMessage("Error message");

            // Assert
            error.ToString().Should().Be("Error with Message='Error message'");
        }
        
        [TestMethod]
        public void ErrorWithReasonsToString_TypeWithReasons()
        {
            // Act
            var error = new Error()
                .CausedBy("My first cause")
                .CausedBy("My second cause");

            // Assert
            error.ToString().Should().Be("Error with Reasons='Error with Message='My first cause'; Error with Message='My second cause''");
        }
    }
}

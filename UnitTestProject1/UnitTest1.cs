﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevAPP.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(1,1);
            //assert
            Assert.AreEqual(1, result);
        }
    }
}

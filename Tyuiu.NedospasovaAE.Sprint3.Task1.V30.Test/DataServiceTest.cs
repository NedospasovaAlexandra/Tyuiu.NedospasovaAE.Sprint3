﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint3.Task1.V30.Lib;

namespace Tyuiu.NedospasovaAE.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 8.392;
            Assert.AreEqual(wait, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.NasyrovaVR.Sprint5.Task2.V6.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            string path = @"L:\Проги\Tyuiu.NasyrovaVR.Sprint5\Tyuiu.NasyrovaVR.Sprint5.Task2.V6\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.NasyrovaVR.Sprint5.Task1.V15.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            string path = @"L:\Проги\Tyuiu.NasyrovaVR.Sprint5\Tyuiu.NasyrovaVR.Sprint5.Task1.V15\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.NasyrovaVR.Sprint5.Task3.V29.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            string path = @"L:\Проги\Tyuiu.NasyrovaVR.Sprint5\Tyuiu.NasyrovaVR.Sprint5.Task3.V29\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

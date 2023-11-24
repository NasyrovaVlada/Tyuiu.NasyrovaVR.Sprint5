using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.NasyrovaVR.Sprint5.Task6.V25.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string path = @"L:\Проги\DataSprint5\InPutDataFileTask6V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds=new DataService();
            string path = @"L:\Проги\DataSprint5\InPutDataFileTask6V25.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);

        }
    }
}

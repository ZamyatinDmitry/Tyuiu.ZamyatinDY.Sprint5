using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZamyatinDY.Sprint5.Task3.V4.Lib;
namespace Tyuiu.ZamyatinDY.Sprint5.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.ZamyatinDY.Sprint5\Tyuiu.ZamyatinDY.Sprint5.Task0.V6.Test\bin\Debug\OutPutFileTask2.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

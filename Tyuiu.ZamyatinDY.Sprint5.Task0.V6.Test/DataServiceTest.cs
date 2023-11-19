using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint5.Task0.V6.Lib;
using System.IO;
namespace Tyuiu.ZamyatinDY.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.ZamyatinDY.Sprint5\Tyuiu.ZamyatinDY.Sprint5.Task0.V6.Test\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait,fileExists);
        }
    }
}

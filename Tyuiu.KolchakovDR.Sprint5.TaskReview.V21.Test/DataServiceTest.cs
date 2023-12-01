using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint5.TaskReview.V21.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.TaskReview.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.KolchakovDR.Sprint5.Review\Tyuiu.KolchakovDR.Sprint5.TaskReview.V21\bin\Debug\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedExistsFileInPut()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClassesTest;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            var fp = new FileProcess();

            //Act
            var fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            //Assert
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            var fp = new FileProcess();

            //Act
            var fromCall = fp.FileExists(@"C:\test.bak");

            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            Assert.Inconclusive();
        }
    }
}

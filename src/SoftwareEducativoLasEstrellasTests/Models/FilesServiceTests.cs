using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEducativoLasEstrellas.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SoftwareEducativoLasEstrellas.Models.Tests
{
    [TestClass()]
    public class FilesServiceTests
    {
        [TestMethod()]
        public void FilesTest()
        {
            FilesService fs = new FilesService(@"d:\devdoc\others");

            int count = fs.DocumentFiles().Count();

            Assert.AreEqual(2, count);
        }
    }
}

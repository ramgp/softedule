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
            FilesService fs = new FilesService(@"x:\softedule");

            int count = fs.MediaFiles().Count();

            Assert.AreEqual(1, count);
        }
    }
}

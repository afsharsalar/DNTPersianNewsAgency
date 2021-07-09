using System.Linq;
using DNTPersianNewsAgency.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianNewsAgency.Test
{
    [TestClass]
    public class RssReaderTest
    {
        [TestMethod]
        public void TasnimHasData()
        {
            //Arrange
          
            var hasData = true;

            //Act
            var data = RssReader.Read(NewsAgencyType.Tasnim, null);

            //Assert

            Assert.AreEqual(hasData, data.Any());


        }


        [TestMethod]
        public void IsnaHasData()
        {
            //Arrange

            var hasData = true;

            //Act
            var data = RssReader.Read(NewsAgencyType.Isna);

            //Assert

            Assert.AreEqual(hasData, data.Any());


        }

        [TestMethod]
        public void AllAgencyHasData()
        {
            //Arrange

            var hasData = true;

            //Act
            var data = RssReader.Read();

            //Assert

            Assert.AreEqual(hasData, data.Any());


        }
    }
}

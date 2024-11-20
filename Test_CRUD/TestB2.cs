using crudsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CRUD
{
    [TestFixture]
    public class TestB2
    {
        private B2 service;

        [SetUp]
        public void Setup()
        {
            service = new B2();
        }

        [Test]
        public void Additem_ValidName()
        {
            // Arrange
            var newItem = new B2_(1, "ValidName");

            // Act
            service.additem(newItem);

            // Assert
            Assert.AreEqual(1, service.cruds.Count);
            Assert.AreEqual("ValidName", service.cruds[0].Name);
        }

        [Test]
        public void Additem_NameTooLong()
        {
            // Arrange
            var newItem = new B2_(2, "ThisNameIsTooLongAndWillFail");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.additem(newItem));
        }

        [Test]
        public void Additem_NameNotString()
        {
            var newItem = new B2_(3, "123");
            Assert.Throws<ArgumentException>(() => service.additem(newItem));
        }

        [Test]
        public void Updateitem_ValidUpdate()
        {
            var newItem = new B2_(1, "OriginalName");
            service.additem(newItem);
            var newName = "UpdatedName";
            service.Updateitem(1, newName);
            Assert.AreEqual(newName, service.cruds[0].Name);
        }

        [Test]
        public void Updateitem_InvalidId()
        {
            var newName = "UpdatedName";
            Assert.Throws<ArgumentException>(() => service.Updateitem(100, newName));
        }

        [Test]
        public void Delete_ValidDelete()
        {
            var newItem = new B2_(1, "ToDelete");
            service.additem(newItem);
            service.delete(1);
            Assert.AreEqual(0, service.cruds.Count);
        }

        [Test]
        public void Delete_InvalidId()
        {
            Assert.Throws<ArgumentException>(() => service.delete(100));
        }
    }
}

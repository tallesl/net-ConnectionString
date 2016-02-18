namespace ConnectionStringLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Ok()
        {
            var cs = ConnectionStringReader.Read("SomeConnectionStringName");

            Assert.AreEqual("SomeConnectionStringName", cs.Name);
            Assert.AreEqual("System.Data.SqlClient", cs.ProviderName);
            Assert.AreEqual("Data Source=.\\SQLEXPRESS; Initial Catalog=MyDatabase; Integrated Security=SSPI;", cs.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyConnectionStringException))]
        public void Empty()
        {
            var cs = ConnectionStringReader.Read("Empty");
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyProviderNameException))]
        public void EmptyProviderName()
        {
            var cs = ConnectionStringReader.Read("NoProviderName");
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchConnectionStringException))]
        public void Inexisting()
        {
            var cs = ConnectionStringReader.Read("Nope");
        }
    }
}

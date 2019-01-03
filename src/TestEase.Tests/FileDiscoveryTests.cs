// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="FileDiscoveryTests.cs">
//   boom boom
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable ExceptionNotDocumented

using System;
using System.Reflection;
using NUnit.Framework;

namespace TestEase.Tests
{

    public class FileDiscoveryTests
    {
        [Test]
        public void TestJsonDiscovery()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            Assert.IsTrue(tm.Json.Keys.Count > 0);
        }

        [Test]
        public void TestSqlDiscovery()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            Assert.IsTrue(tm.Sql.Keys.Count > 0);
        }

        [Test]
        public void TestTextDiscovery()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            Assert.IsTrue(tm.Text.Keys.Count > 0);
        }

        [Test]
        public void TestXmlDiscovery()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            Assert.IsTrue(tm.Xml.Keys.Count > 0);
        }
    }
}
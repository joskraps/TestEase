using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace TestEase.Tests
{
    public class SqlItemTypeTests
    {
        [Test]
        public void TestQueueWithDefaultReplacements()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            tm.Sql.SetupConnections(new Dictionary<string, string> {{"TEST", "tester"}});

            tm.Sql.QueueLibraryItem("sql.TestDefaultReplacements");

            Assert.IsTrue(tm.Sql.GetQueuedSql.Count == 1);

            Assert.IsTrue(tm.Sql.GetQueuedSql.First().Value.ToString() == "\r\n\r\nselect 69,'TEST'\r\n");
        }

        [Test]
        public void TestQueueWithReplacements()
        {
            var tm = new TestDataManager(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

            tm.Sql.SetupConnections(new Dictionary<string, string> {{"TEST", "tester"}});

            tm.Sql.QueueLibraryItem("sql.TestDefaultReplacements",
                new Dictionary<string, object> {{"TESTVAL1", 96}, {"TESTVAL2", "BOOM"}});

            Assert.IsTrue(tm.Sql.GetQueuedSql.Count == 1);
            Assert.IsTrue(tm.Sql.GetQueuedSql.First().Value.ToString() == "\r\n\r\nselect 96,'BOOM'\r\n");
        }
    }
}
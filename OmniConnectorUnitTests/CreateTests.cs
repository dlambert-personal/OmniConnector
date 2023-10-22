using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OmniConnectLib;
using System.Net.Configuration;

namespace OmniConnectorUnitTests
{
    [TestClass]
    public class CreateTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cxTypes = List<ConnectionType>;
            cxTypes.Add(new ConnectionType(1, "Test link"));
            string A = "A";
            string B = "B";

            var cx = new Connection<string, string>();

        }
    }
}

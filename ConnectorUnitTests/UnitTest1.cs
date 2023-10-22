using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmniConnectLib;

namespace OmniConnectorUnitTests
{
    [TestClass]
    public class CreateTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cxType = new ConnectionType(1, "Test link");
            string A = "A";
            string B = "B";

            var cx = new Connection<string, string>();
            cx.From = A; 
            cx.To = B;
            cx.ConnectionType = cxType;

        }
    }
}

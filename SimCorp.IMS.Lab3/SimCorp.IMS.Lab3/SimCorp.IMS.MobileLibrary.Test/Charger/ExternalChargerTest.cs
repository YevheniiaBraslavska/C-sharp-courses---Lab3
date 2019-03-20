using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;

namespace MobileLibrary.Test {
    [TestClass]
    public class WirelessChargerTest {
        [TestMethod]
        public void ChargeValidOutputText() {
            var output = new FakeOutput();
            var charger = new WirelessCharger(output,1.5f);

            charger.Charge();

            Assert.AreEqual("Charge with WirelessCharger\n", output.OutputResult);
        }
    }
}

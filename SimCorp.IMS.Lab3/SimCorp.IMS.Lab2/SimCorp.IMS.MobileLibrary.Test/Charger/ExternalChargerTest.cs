using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;

namespace MobileLibrary.Test {
    [TestClass]
    public class WirelessChargerTest {
        [TestMethod]
        public void ChargeValidOutputText() {
            FakeOutput output = new FakeOutput();
            WirelessCharger charger = new WirelessCharger(output,1.5f);

            charger.Charge();

            Assert.AreEqual("Charge with WirelessCharger\n", output.OutputResult);
        }
    }
}

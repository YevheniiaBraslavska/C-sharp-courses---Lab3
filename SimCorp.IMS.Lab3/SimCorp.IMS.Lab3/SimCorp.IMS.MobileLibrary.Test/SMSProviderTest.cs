using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;
using SimCorp.IMS.MobileLibrary;

namespace MobileLibrary.Test {
    [TestClass]
    public class SMSProviderTest {
        [TestMethod]
        public void WHEN_PushMessage_THEN_EventRize() {
            var receivedEvents = new List<string>();
            var smsprovider = new SMSProvider();

            smsprovider.SMSRecieved += delegate (object sender, SMSRecieverEventArgs e) {
                receivedEvents.Add(e.Message);
            };

            smsprovider.RaiseSmsRecievedEvent(this, new SMSRecieverEventArgs("message"));

            Assert.AreEqual(1, receivedEvents.Count);
            Assert.AreEqual("message", receivedEvents[0]);
        }
    }
}

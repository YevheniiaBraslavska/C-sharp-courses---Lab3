using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobileLibrary;

namespace MobileLibrary.Test {
    [TestClass]
    public class MessageFormatterTest {
        [TestMethod]
        public void StartWithTimeRightOutput()
        {
            const string message = "Message";

            var act_message = MessageFormatter.StartWithTime(message);

            Assert.AreEqual(act_message,$"[{DateTime.Now}] {message}");
        }

        [TestMethod]
        public void EndWithTimeRightOutput() {
            const string message = "Message";

            var act_message = MessageFormatter.EndWithTime(message);

            Assert.AreEqual(act_message, $"{message} [{DateTime.Now}]");
        }

        [TestMethod]
        public void LowerCaseRightOutput() {
            const string message = "Message";

            var act_message = MessageFormatter.LowerCase(message);

            Assert.AreEqual(act_message, "message");
        }

        [TestMethod]
        public void UpperCaseRightOutput() {
            const string message = "Message";

            var act_message = MessageFormatter.UpperCase(message);

            Assert.AreEqual(act_message, "MESSAGE");
        }

        [TestMethod]
        public void CustomRightOutput() {
            const string message = "Message";

            var act_message = MessageFormatter.Custom(message);

            Assert.AreEqual(act_message, "egasseM");
        }
    }
}

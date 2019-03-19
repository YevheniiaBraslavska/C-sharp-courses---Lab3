using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;

namespace MobileLibrary.Test {
    [TestClass]
    public class IPhoneHeadsetTest {
        [TestMethod]
        public void PlayValidOutputText() {
            var output = new FakeOutput();
            var headset = new IPhoneHeadset(output,"2156:2356");
            var data = new object();

            headset.Play(data);

            Assert.AreEqual("IPhoneHeadset sound\n",output.OutputResult);
        }
    }
}

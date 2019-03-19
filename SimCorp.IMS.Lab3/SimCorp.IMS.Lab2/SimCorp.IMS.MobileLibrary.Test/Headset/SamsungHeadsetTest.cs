using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobileLibrary;

namespace MobileLibrary.Test {
    [TestClass]
    public class SamsungHeadsetTest {
        [TestMethod]
        public void PlayValidOutputText() {
            var output = new FakeOutput();
            var plug = new AudioPlug(200,100,3.5f);
            var headset = new SamsungHeadset(output,plug);
            var data = new object();

            headset.Play(data);

            Assert.AreEqual("SamsungHeadset sound\n", output.OutputResult);
        }
    }
}

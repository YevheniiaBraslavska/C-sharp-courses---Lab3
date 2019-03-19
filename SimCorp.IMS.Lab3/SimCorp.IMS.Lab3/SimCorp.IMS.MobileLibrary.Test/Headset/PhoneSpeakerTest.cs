using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary.Test {
    [TestClass]
    public class PhoneSpeakerTest {
        [TestMethod]
        public void PlayValidOutputText() {
            var output = new FakeOutput();
            var headset = new PhoneSpeaker(output,25.0f);
            var Data = new object();

            headset.Play(Data);

            Assert.AreEqual("PhoneSpeaker sound\n", output.OutputResult);
        }
    }
}

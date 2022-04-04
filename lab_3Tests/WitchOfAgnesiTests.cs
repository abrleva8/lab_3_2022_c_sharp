using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Tests {
    [TestClass()]
    public class WitchOfAgnesiTests {
        [TestMethod()]
        public void SetValuesTest() {
            Interval interval = new Interval(-1, 1);
            WitchOfAgnesi witch = new WitchOfAgnesi(1, interval, 0.2);
            witch.SetValues();

            List < KeyValuePair<double, double> > right = new List<KeyValuePair<double, double>>();
            right.Add(new KeyValuePair<double, double>(-1, 0.5));
            right.Add(new KeyValuePair<double, double>(-0.8, 0.61));
            right.Add(new KeyValuePair<double, double>(-0.6, 0.74));
            right.Add(new KeyValuePair<double, double>(-0.4, 0.86));
            right.Add(new KeyValuePair<double, double>(-0.2, 0.96));
            right.Add(new KeyValuePair<double, double>(0, 1));
            right.Add(new KeyValuePair<double, double>(0.2, 0.96));
            right.Add(new KeyValuePair<double, double>(0.4, 0.86));
            right.Add(new KeyValuePair<double, double>(0.6, 0.74));
            right.Add(new KeyValuePair<double, double>(0.8, 0.61));
            right.Add(new KeyValuePair<double, double>(1.0, 0.5));


            CollectionAssert.AreEqual(right, witch.Pairs);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add add'l libraries
using MyMath;
using NUnit.Framework;

namespace MyMath1.UnitTests
{
    [TestFixture]
    public class MyMath1Tests 
    {
        // must preface each test with [Test]
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.AreEqual(200, MyMath.MyMath1.Add(101, 99));
        }
        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorrectSum()
        {
            Assert.AreEqual(302, MyMath.MyMath1.Add(101, 201));
        }
        // another way to do ^ (test 1)
        // simpler, modern version
        [Test]
        public void Add_SumWithinByteRange_AlternateAssert()
        {
            // that refers to method call
            Assert.That(MyMath.MyMath1.Add(101, 99), Is.EqualTo(200));
        }
        // this allows the test to pass on this level
        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => MyMath.MyMath1.Add(101, 201), Throws.Exception);
        }
    }

}

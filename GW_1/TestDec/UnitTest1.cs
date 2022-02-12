using NUnit.Framework;
using GW_1;
namespace TestDec
{
    public class Tests
    {

        [Test]
        public void TestCreateDec()
        {
            Dec d = new Dec(new int[] {1,2,3,4,5});
            Assert.AreEqual(d.toString(),"1 2 3 4 5");
        }

        [Test]
        public void TestAddLeft()
        {
            Dec d = new Dec(new int[] { 1, 2, 3, 4, 5 });
            d.AddLeft(0);
            Assert.AreEqual(d.toString(),"0 1 2 3 4 5");
        }

        [Test]
        public void TestAddRight()
        {
            Dec d = new Dec(new int[] { 1, 2, 3, 4, 5 });
            d.AddRight(6);
            Assert.AreEqual(d.toString(),"1 2 3 4 5 6");
        }

        [Test]
        public void TestDeletLeft()
        {
            Dec d = new Dec(new int[] { 1, 2, 3, 4, 5 });
            d.DeletLeft();
            Assert.AreEqual(d.toString(), "2 3 4 5");
        }

        [Test]
        public void TestDeletRight()
        {
            Dec d = new Dec(new int[] { 1, 2, 3, 4, 5 });
            d.DeletRight();
            Assert.AreEqual(d.toString(), "1 2 3 4");
        }
    }
}
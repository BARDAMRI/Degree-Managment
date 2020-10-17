using System;
using NUnit.Framework;
using Moq;
using DM.Backend.BL;
using DM.Backend.SL;


namespace DM.Backend.BL.Tests
{
    public class courseTest
    {
        public Course course1;

        [SetUp]
        public void setup()
        {
            course1 = new Course("calculus",6);

        }
        [Test]
        public void setNameTest()
        {
            course1.setName("calculus2");
            Assert.AreEqual(course1.Name(), "calculus2","failed tochange course name");
        }

        [Test]
        public void addBlockerTest()
        {
            Course course2 = new Course("calculus2", 5);
            course1.addBlocker(course2);
            Assert.AreEqual(course1.Blockers()["calculus2"],course2,"fail to add blocker");
        }

        [Test]
        public void removeBlockerTest()
        {
            Course course2 = new Course("calculus2", 5);
            course1.addBlocker(course2);
            course1.removeBlocker(course2);
            bool ans = course1.Blockers().ContainsKey("calculus2");
            Assert.AreEqual(ans, false, "fail to remove blocker");
        }

        [Test]
        public void removeBlockerTest1()
        {
            Course course2 = new Course("calculus2", 5);
            course1.addBlocker(course2);
            course1.removeBlocker("calculus2");
            bool ans = course1.Blockers().ContainsKey("calculus2");
            Assert.AreEqual(ans, false, "fail to remove blocker");
        }

        [Test]
        public void isBlockerTest()
        {
            Course course2 = new Course("calculus2", 5);
            course1.addBlocker(course2);
            bool ans = course1.isBlocker("calculus2");
            Assert.AreEqual(ans, true, "fail to check blocker");
        }

        [Test]
        public void setCreditTest()
        {
            course1.setCredit(7);
            Assert.AreEqual(course1.Credit(), 7, "failed tochange course credit");
        }

        [Test]
        public void setGradeTest()
        {
            Assert.Fail();
        }

        [Test]
        public void EqualsTest()
        {
            Assert.Fail();
        }

        [Test]
        public void hasBlockerTest()
        {
            Assert.Fail();
        }
    }
}
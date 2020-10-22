using DM.Backend.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Castle.Core.Internal;

namespace DM.Backend.BL.Tests
{
    public class CourseTests
    {
        public Course course1;

        [SetUp]
        public void setup()
        {
            course1 = new Course("calculus", 6);

        }
        [Test]
        public void setNameTest()
        {
            course1.setName("calculus2");
            Assert.AreEqual(course1.Name(), "calculus2", "failed tochange course name");
        }

        //[Test]
        //public void addBlockerTest()
        //{
        //    Course course2 = new Course("calculus2", 5);
        //    course1.addBlocker(course2);
        //    Assert.AreEqual(course1.Blockers()["calculus2"], course2, "fail to add blocker");
        //}

        //[Test]
        //public void removeBlockerTest()
        //{
        //    Course course2 = new Course("calculus2", 5);
        //    course1.addBlocker(course2);
        //    course1.removeBlocker(course2);
        //    bool ans = course1.Blockers().ContainsKey("calculus2");
        //    Assert.AreEqual(ans, false, "fail to remove blocker");
        //}

        //[Test]
        //public void removeBlockerTest1()
        //{
        //    Course course2 = new Course("calculus2", 5);
        //    course1.addBlocker(course2);
        //    course1.removeBlocker("calculus2");
        //    bool ans = course1.Blockers().ContainsKey("calculus2");
        //    Assert.AreEqual(ans, false, "fail to remove blocker");
        //}

        //[Test]
        //public void isBlockerTest()
        //{
        //    Course course2 = new Course("calculus2", 5);
        //    course1.addBlocker(course2);
        //    bool ans = course1.isBlocker("calculus2");
        //    Assert.AreEqual(ans, true, "fail to check blocker");
        //}

        [Test]
        public void setCreditTest()
        {
            course1.setCredit(7);
            Assert.AreEqual(course1.Credit(), 7, "failed to change course credit");
        }

        [Test]
        public void setGradeTest()
        {
            course1.setGrade(80);
            Assert.AreEqual(course1.Grade(), 80, "failed to set course grade");
        }

        [Test]
        public void EqualsTest()
        {
            Course course2 = new Course("calculus", 6);
            course1.setGrade(80);
            course2.setGrade(80);
            Assert.IsTrue(course1.Equals(course2), "failed to compare courses");
        }

        //[Test]
        //public void hasBlockerTest()
        //{
        //    Course course2 = new Course("calculus2", 5);
        //    course1.addBlocker(course2);
        //    Assert.IsFalse(course1.Blockers().IsNullOrEmpty(), "fail to check blockers existance");
        //}
    }
}
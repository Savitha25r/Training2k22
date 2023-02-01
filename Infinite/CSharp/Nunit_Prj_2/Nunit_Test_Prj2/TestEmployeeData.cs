using System;
using System.Collections.Generic;
using NUnit.Framework;
using Nunit_Prj_2;

namespace Nunit_Test_Prj2
{
    [TestFixture]
    public class TestEmployeeData
    {
        List<EmployeeData> elist;
        Program p = new Program();
        [Test]
        public void CheckEmployeeData()
        {           
            elist = p.AllEmployees();
            foreach(var v in elist)
            {
                Assert.IsNotNull(v.Id);
                Assert.IsNotNull(v.Name);
                Assert.IsNotNull(v.Salary);
                Assert.IsNotNull(v.Gender);
            }
        }

        [Test]
        public void TestLogin()
        {
            string s = p.Login("Banurekha", "abcd");
            string s1 = p.Login("Admin", "12345");
            string s2 = p.Login("", "");
            Assert.AreEqual("UserId or Password cannot be null or Empty", s2);
            Assert.AreEqual("Welcome Admin", s1);
            Assert.AreEqual("Invalid User Id Or Password", s);
        }

    }
}

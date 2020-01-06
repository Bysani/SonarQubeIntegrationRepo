using Moq;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;


namespace XUnitTestProject
{
    public class AuthorizationTest
    {
        [Fact]
        public void IsAuthorizedToRunTest()
        {
            List<string> permissions = new List<string>();
            permissions.Add("CanRunTest");
            Assert.True(permissions.Contains("CanRunTest"),"permission is avaialble");
        }
    }
}

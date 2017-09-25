using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JinRi.Flight.Redis;

namespace UnitTestProject
{
    [TestClass]
    public class RedisTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            RedisClient redisClient = new RedisClient();
            redisClient.StringSet("guojitest", "test2", TimeSpan.FromMinutes(5));
            

            string value = redisClient.StringGet("guojitest");
        }
    }
}

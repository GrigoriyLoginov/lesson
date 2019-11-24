using NUnit.Framework;
using Task9_3;
using System;

namespace Task9.Tests
{
    class TestsTask9_3
    {
        [TestCase("www.example.com", "key=value", ExpectedResult = "www.example.com?key=value")]
        [TestCase("www.example.com?key=value", "key2=value2", ExpectedResult = "www.example.com?key=value&key2=value2")]
        [TestCase("www.example.com?key=oldValue", "key=newValue",ExpectedResult = "www.example.com?key=newValue")]
        [TestCase("www.example.com?key=OneValue&key2=TwoValue", "key3=ThreeValue", ExpectedResult = "www.example.com?key=OneValue&key2=TwoValue&key3=ThreeValue")]
        [TestCase("www.example.com?key=OneValue&key2=TwoValue", "key=ThreeValue", ExpectedResult = "www.example.com?key=ThreeValue&key2=TwoValue")]
        public string TestUrlParam(string url, string param)
        {
            string result = UrlParametrs.AddOrChangeUrlParameter(url, param);
            return result;
        }
        [Test]
        public void ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => UrlParametrs.AddOrChangeUrlParameter("www.example.com", ""));
            Assert.Throws<ArgumentNullException>(() => UrlParametrs.AddOrChangeUrlParameter("", "2"));
            Assert.Throws<ArgumentNullException>(() => UrlParametrs.AddOrChangeUrlParameter("", ""));
        }
    }
}

using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using TruncatedUnitTest;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<MyClass> list = null;

            list.Should().BeEquivalentTo(new List<MyClass>
            {
                new MyClass
                {
                    MyName = "B"
                }
            });
        }
    }
}
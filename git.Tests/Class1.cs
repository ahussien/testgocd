using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace git.Tests
{
    [NUnit.Framework.TestFixture]
    public class Test
    {
        [NUnit.Framework.Test]
        public void TestMethod()
        {
            NUnit.Framework.Assert.AreEqual(1, 1);
        }
    }
}

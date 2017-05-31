using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traktory
{
    [TestFixture]
    class TraktorTesty
    {
        public TraktorTesty() { }

        [Test]
        public void SprawdzenieSelecta()
        {

            var T = new MySQL();

            Assert.IsNotNull(T.Select());
            Assert.IsNotEmpty(T.Select());

        }
        [Test] public void SprawdzenieSelecta2()
        {

            var T = new MySQL();

            Assert.IsNotNull(T.Select2());
            Assert.IsNotEmpty(T.Select2());

        }
    }
}

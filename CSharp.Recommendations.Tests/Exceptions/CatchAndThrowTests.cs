using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Recommendations.Exceptions;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CSharp.Recommendations.Tests.Exceptions
{
    [TestFixture()]
    public class CatchAndThrowTests
    {
        [Test()]
        public void RunWorker_CatchException_StackTraceIntact()
        {
            var service = new CatchAndThrow();

            try
            {
                service.RunWorker();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                // This will fail because the stacktrace is no longer intact.
                var index = ex.StackTrace.IndexOf("TerribleWorker");
                Assert.True(index > 0, "The TerribleWorker.DoSomeWork() method should appear in the stack trace.");
            }
        }
    }
}

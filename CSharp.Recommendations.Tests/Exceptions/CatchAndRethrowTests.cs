using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Recommendations.Exceptions;
using NUnit.Framework;

namespace CSharp.Recommendations.Tests.Exceptions
{
    [TestFixture()]
    public class CatchAndRethrowTests
    {
        [Test()]
        public void RunWorker_CatchException_StackTraceIntact()
        {
            var service = new CatchAndRethrow();

            try
            {
                service.RunWorker();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                var index = ex.StackTrace.IndexOf("TerribleWorker");
                Assert.True(index > 0, "The TerribleWorker.DoSomeWork() method should appear in the stack trace.");
            }
        }
    }
}

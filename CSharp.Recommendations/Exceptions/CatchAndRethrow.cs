using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Recommendations.Exceptions.Worker;

namespace CSharp.Recommendations.Exceptions
{
    public class CatchAndRethrow
    {
        public void RunWorker()
        {
            TerribleWorker worker = new TerribleWorker();
            try
            {
                worker.DoSomeWork();
            }
            catch (Exception ex)
            {
                // Do some special exception handling goodness.

                // If you declare "throw" without specifying an exception, the framework
                //  will rethrow the caught exception and maintain the stack trace.
                //  I've never seen an example where it would be appropriate to 
                //  overwrite the stack trace by replacing the below with "throw ex".
                throw;
            }
        }
    }
}

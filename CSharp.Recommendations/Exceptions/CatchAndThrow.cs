using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Recommendations.Exceptions.Worker;

namespace CSharp.Recommendations.Exceptions
{
    public class CatchAndThrow
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

                // When we throw an exception, even one that has already been previously thrown
                //  the stack trace is set to this location, which results in loss of valuable
                //  debugging information.
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Recommendations.Exceptions.Worker
{
    public class TerribleWorker
    {
        public void DoSomeWork()
        {
            throw new ApplicationException("Hey, I don't like doing work. Leave me alone!");
        }
    }
}

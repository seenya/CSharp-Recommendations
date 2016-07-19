using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Recommendations.String
{
    public class Builder
    {
        public string CreateNumberSequenceString(int start, int end, string separator)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                builder.Append(i.ToString());
                builder.Append(separator);
            }
            return builder.ToString();
        }
    }
}

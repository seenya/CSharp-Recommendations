using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Recommendations.String
{
    public class Concatenation
    {

        public string CreateNumberSequenceString(int start, int end, string separator)
        {
            string text = "";
            for (int i = start; i < end; i++)
            {
                text = text + i.ToString() + separator;
            }
            return text;
        }
    }
}

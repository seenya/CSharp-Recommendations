using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Recommendations.String;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace CSharp.Recommendations.Tests.String
{
    [TestFixture()]
    public class ConcatenationTests
    {
        [Test()]
        public void Concat5Times_Repeat10000Times_RecordTime()
        {
            int repeatCount = 10000;
            int start = 0;
            int end = 5;
            string separator = ",";
            Stopwatch watch = new Stopwatch();
            Concatenation concatService = new Concatenation();

            watch.Start();
            for (int i = 0; i < repeatCount; i++)
            {
                concatService.CreateNumberSequenceString(start, end, separator);
            }
            watch.Stop();
            var concatenationTime = watch.ElapsedMilliseconds;

            Builder builderService = new Builder();
            watch.Reset();
            watch.Start();
            for (int i = 0; i < repeatCount; i++)
            {
                builderService.CreateNumberSequenceString(start, end, separator);
            }
            watch.Stop();
            var builderTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Concatenation Time: {concatenationTime}ms");
            Console.WriteLine($"Builder Time      : {builderTime}ms");

        }

        [Test()]
        public void Concat1000Times_Repeat1000Times_RecordTime()
        {
            int repeatCount = 1000;
            int start = 0;
            int end = 1000;
            string separator = ",";
            Stopwatch watch = new Stopwatch();
            Concatenation concatService = new Concatenation();

            watch.Start();
            for (int i = 0; i < repeatCount; i++)
            {
                concatService.CreateNumberSequenceString(start, end, separator);
            }
            watch.Stop();
            var concatenationTime = watch.ElapsedMilliseconds;

            Builder builderService = new Builder();
            watch.Reset();
            watch.Start();
            for (int i = 0; i < repeatCount; i++)
            {
                builderService.CreateNumberSequenceString(start, end, separator);
            }
            watch.Stop();
            var builderTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Concatenation Time: {concatenationTime}ms");
            Console.WriteLine($"Builder Time      : {builderTime}ms");

        }

    }
}

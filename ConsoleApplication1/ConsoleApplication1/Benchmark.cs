using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace ConsoleApplication1
{
    public class Benchmark
    {
        // And define a method with the Benchmark attribute
        [Benchmark]
        public void Sleep() => Thread.Sleep(10);

        // You can write a description for your method.
        [Benchmark(Baseline=true), Description("Thread.Sleep(10)")]
        public void SleepWithDescription() => Thread.Sleep(10);
    }
}

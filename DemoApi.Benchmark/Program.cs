using BenchmarkDotNet.Running;
using DemoApi.Benchmark;


BenchmarkRunner.Run<BenchmarkTests>();


Console.ReadKey();

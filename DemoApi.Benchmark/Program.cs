using BenchmarkDotNet.Running;
using DemoApi.Benchmark;


BenchmarkRunner.Run<ObjectCreationBenchMark>();


Console.ReadKey();

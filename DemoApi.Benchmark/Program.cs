using BenchmarkDotNet.Running;
using DemoApi.Benchmark;



//BenchmarkRunner.Run<ObjectCreationBenchMark>();
BenchmarkRunner.Run<MockBenchMark>();


Console.ReadKey();

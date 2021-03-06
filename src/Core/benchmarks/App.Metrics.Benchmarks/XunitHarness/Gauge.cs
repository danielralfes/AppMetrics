﻿// <copyright file="Gauge.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using App.Metrics.Benchmarks.BenchmarkDotNetBenchmarks.Metrics;
using App.Metrics.Benchmarks.Support;
using Xunit;
using Xunit.Abstractions;

namespace App.Metrics.Benchmarks.XunitHarness
{
    [Trait("Benchmark-MetricType", "Gauge")]
    public class Gauge
    {
        private readonly ITestOutputHelper _output;

        public Gauge(ITestOutputHelper output) { _output = output; }

        [Fact]
        public void CostOfMeasuringGauge() { BenchmarkTestRunner.CanCompileAndRun<MeasureGaugeBenchmark>(_output); }
    }
}
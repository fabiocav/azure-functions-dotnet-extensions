﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Tests
{
    public class TestWebJobsBuilder : IWebJobsBuilder
    {
        public TestWebJobsBuilder()
        {
            Services = new ServiceCollection();
        }

        public IServiceCollection Services { get; }
    }
}

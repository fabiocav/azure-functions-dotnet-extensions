// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;

namespace DependencyInjection.Tests
{
    public class FunctionHostBuilderContextTests
    {
        [Fact]
        public void HostBuilderContext_ReturnsExpectedPath()
        {
            IWebJobsBuilder webJobsBuilder = new TestWebJobsBuilder();
            
            var context = webJobsBuilder.GetContext()

            Assert.Collection(webJobsBuilder.Services, t => Assert.Equal(typeof(String), t.ImplementationType));
        }
    }
}

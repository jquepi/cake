// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Packaging;
using Cake.Core.Polyfill;

namespace Cake.NuGet.Tests.Fixtures
{
    internal sealed class NuGetAddinContentResolverFixture : NuGetContentResolverFixture
    {
        public NuGetAddinContentResolverFixture(string framework, Runtime runtime)
            : base(framework, runtime)
        {
        }
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Core
{
    /// <summary>
    /// Implementation of <see cref="ICakeContext"/>.
    /// </summary>
    public sealed class CakeContext : ICakeContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CakeContext"/> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="globber">The globber.</param>
        /// <param name="log">The log.</param>
        /// <param name="arguments">The arguments.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="registry">The registry.</param>
        /// <param name="tools">The tool locator.</param>
        /// <param name="data">The data service.</param>
        /// <param name="configuration">The cake configuration.</param>
        public CakeContext(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IGlobber globber,
            ICakeLog log,
            ICakeArguments arguments,
            IProcessRunner processRunner,
            IRegistry registry,
            IToolLocator tools,
            ICakeDataService data,
            ICakeConfiguration configuration)
        {
            FileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
            Globber = globber ?? throw new ArgumentNullException(nameof(globber));
            Log = log ?? throw new ArgumentNullException(nameof(log));
            Arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));
            ProcessRunner = processRunner ?? throw new ArgumentNullException(nameof(processRunner));
            Registry = registry ?? throw new ArgumentNullException(nameof(registry));
            Tools = tools ?? throw new ArgumentNullException(nameof(tools));
            Data = data ?? throw new ArgumentNullException(nameof(data));
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        /// <summary>
        /// Gets the file system.
        /// </summary>
        /// <value>
        /// The file system.
        /// </value>
        public IFileSystem FileSystem { get; }

        /// <summary>
        /// Gets the environment.
        /// </summary>
        /// <value>
        /// The environment.
        /// </value>
        public ICakeEnvironment Environment { get; }

        /// <summary>
        /// Gets the globber.
        /// </summary>
        /// <value>
        /// The globber.
        /// </value>
        public IGlobber Globber { get; }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        public ICakeLog Log { get; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public ICakeArguments Arguments { get; }

        /// <summary>
        /// Gets the process runner.
        /// </summary>
        /// <value>
        /// The process runner.
        /// </value>
        public IProcessRunner ProcessRunner { get; }

        /// <summary>
        /// Gets the registry.
        /// </summary>
        /// <value>
        /// The registry.
        /// </value>
        public IRegistry Registry { get; }

        /// <summary>
        /// Gets the tool locator.
        /// </summary>
        /// <value>
        /// The tool locator.
        /// </value>
        public IToolLocator Tools { get; }

        /// <summary>
        /// Gets the data context resolver.
        /// </summary>
        public ICakeDataResolver Data { get; }

        /// <summary>
        /// Gets the cake configuration.
        /// </summary>
        public ICakeConfiguration Configuration { get; }
    }
}
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Core;

namespace Cake.Common.Build.Jenkins.Data
{
    /// <summary>
    /// Provides Jenkins repository information for the current build.
    /// </summary>
    public sealed class JenkinsRepositoryInfo : JenkinsInfo
    {
        /// <summary>
        /// Gets the branch name which will be build in a multibranch project.
        /// </summary>
        /// <value>
        /// The branch name.
        /// </value>
        public string BranchName => GetEnvironmentString("BRANCH_NAME");

        /// <summary>
        /// Gets the Git commit sha.
        /// </summary>
        /// <value>
        /// The Git commit sha.
        /// </value>
        public string GitCommitSha => GetEnvironmentString("GIT_COMMIT");

        /// <summary>
        /// Gets the Git branch.
        /// </summary>
        /// <value>
        /// The Git branch.
        /// </value>
        public string GitBranch => GetEnvironmentString("GIT_BRANCH");

        /// <summary>
        /// Gets the SVN revision.
        /// </summary>
        /// <value>
        /// The SVN revision.
        /// </value>
        public string SvnRevision => GetEnvironmentString("SVN_REVISION");

        /// <summary>
        /// Gets the CVS branch.
        /// </summary>
        /// <value>
        /// The CVS branch.
        /// </value>
        public string CvsBranch => GetEnvironmentString("CVS_BRANCH");

        /// <summary>
        /// Gets the SVN URL.
        /// </summary>
        /// <value>
        /// The SVN URL.
        /// </value>
        public string SvnUrl => GetEnvironmentString("SVN_URL");

        /// <summary>
        /// Initializes a new instance of the <see cref="JenkinsRepositoryInfo"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public JenkinsRepositoryInfo(ICakeEnvironment environment) : base(environment)
        {
        }
    }
}
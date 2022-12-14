// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Cake.Core.Packaging
{
    /// <summary>
    /// Represents an URI resource.
    /// </summary>
    public sealed class PackageReference
    {
        /// <summary>
        /// Gets the original string.
        /// </summary>
        /// <value>The original string.</value>
        public string OriginalString { get; }

        /// <summary>
        /// Gets the scheme.
        /// </summary>
        /// <value>The scheme.</value>
        public string Scheme { get; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        public Uri Address { get; }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        public IReadOnlyDictionary<string, IReadOnlyList<string>> Parameters { get; }

        /// <summary>
        /// Gets the package.
        /// </summary>
        /// <value>The package.</value>
        public string Package { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageReference"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public PackageReference(string uri)
            : this(new Uri(uri))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageReference"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="System.ArgumentException">Package query string parameter is missing.;uri</exception>
        public PackageReference(Uri uri)
        {
            OriginalString = uri.OriginalString;
            Scheme = uri.Scheme;
            Parameters = uri.GetQueryString();

            if (Parameters.ContainsKey("package"))
            {
                if (Parameters["package"].Count == 1)
                {
                    Package = Parameters["package"].FirstOrDefault();
                }
                else if (Parameters["package"].Count > 1)
                {
                    throw new ArgumentException(
                        "Query string contains more than one parameter 'package'.",
                        nameof(uri));
                }
            }

            if (Package == null)
            {
                throw new ArgumentException(
                    "Query string parameter 'package' is missing in package reference.",
                    nameof(uri));
            }

            Uri address;
            if (Uri.TryCreate(uri.AbsolutePath, UriKind.Absolute, out address))
            {
                Address = new Uri(address.AbsoluteUri);
            }
        }
    }
}
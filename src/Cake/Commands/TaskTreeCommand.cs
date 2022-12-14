// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Cake.Core.Scripting;
using Cake.Scripting;

namespace Cake.Commands
{
    /// <summary>
    /// A command that displays the script task graph.
    /// </summary>
    internal sealed class TaskTreeCommand : ICommand
    {
        private readonly IScriptRunner _scriptRunner;
        private readonly TaskTreeScriptHost _host;

        // Delegate factory used by Autofac.
        public delegate TaskTreeCommand Factory();

        public TaskTreeCommand(IScriptRunner scriptRunner, TaskTreeScriptHost host)
        {
            _scriptRunner = scriptRunner;
            _host = host;
        }

        public bool Execute(CakeOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            _scriptRunner.Run(_host, options.Script, options.Arguments);
            return true;
        }
    }
}
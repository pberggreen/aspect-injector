﻿using AspectInjector.Core.Models;
using Mono.Cecil;
using System.Collections.Generic;

namespace AspectInjector.Core.Contracts
{
    public interface IAspectReader : IInitializable
    {
        IEnumerable<AspectDefinition> Read(ModuleDefinition module);

        void Cleanup(ModuleDefinition module);
    }
}
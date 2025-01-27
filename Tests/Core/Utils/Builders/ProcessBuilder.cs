// Copyright (c) 2013-2019 Innoactive GmbH
// Licensed under the Apache License, Version 2.0
// Modifications copyright (c) 2021-2023 MindPort GmbH

using VRBuilder.Core;

namespace VRBuilder.Tests.Builder
{
    public abstract class ProcessBuilder<TProcess> : BuilderWithResourcePath<TProcess> where TProcess : IProcess
    {
        public ProcessBuilder(string name) : base(name)
        {
        }
    }
}

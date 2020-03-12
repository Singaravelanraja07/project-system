﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.ComponentModel.Composition;

namespace Microsoft.VisualStudio.ProjectSystem
{
    [Export(typeof(IFileWatchDataSource))]
    [AppliesTo(ProjectCapability.DotNetLanguageService)]
    internal class PotentialEditorConfigFilesDataSource : AbstractItemFileWatchDataSource
    {
        [ImportingConstructor]
        public PotentialEditorConfigFilesDataSource(ConfiguredProject project, IProjectSubscriptionService projectSubscriptionService)
           : base(project, projectSubscriptionService)
        {
        }

        public override string ItemSchemaName => PotentialEditorConfigFiles.SchemaName;

        public override string FullPathProperty => PotentialEditorConfigFiles.FullPathProperty;

        public override FileWatchChangeKinds FileWatchChangeKinds => FileWatchChangeKinds.Added | FileWatchChangeKinds.Removed;
    }
}

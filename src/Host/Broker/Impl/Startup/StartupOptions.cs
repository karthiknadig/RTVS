﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Microsoft.R.Host.Broker.Startup {
    public class StartupOptions {
        public string Name { get; set; }
        public string WriteServerUrlsToPipe { get; set; }
        public bool IsLocal { get; set; }
    }
}

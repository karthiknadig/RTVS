﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Threading.Tasks;
using Microsoft.R.DataInspection;
using Microsoft.R.Debugger;

namespace Microsoft.VisualStudio.R.Package.DataInspect {
    public interface IDataObjectEvaluator {
       Task<IREvaluationInfo> EvaluateAsync(string expression, RValueProperties fields, string repr);
    }
}

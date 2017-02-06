﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Threading;

namespace Microsoft.Common.Core {
    public static class ExceptionExtensions {
        /// <summary>
        /// Returns true if an exception should not be handled by logging code.
        /// </summary>
        public static bool IsCriticalException(this Exception ex) {
            return ex is StackOverflowException ||
                ex is OutOfMemoryException ||
                ex is ThreadAbortException ||
                ex is AccessViolationException;
        }

        public static bool IsProtocolException(this Exception ex) {
            return ex is IndexOutOfRangeException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidCastException ||
                ex is FormatException;
        }
    }
}
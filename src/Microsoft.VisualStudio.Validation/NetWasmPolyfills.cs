// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETWASM

// Types that NetWasm's CoreLib (netwasm0.1) does not define.
namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    internal sealed class LocalizableAttribute : Attribute
    {
        public LocalizableAttribute(bool isLocalizable) => this.IsLocalizable = isLocalizable;

        public bool IsLocalizable { get; }
    }
}

#endif

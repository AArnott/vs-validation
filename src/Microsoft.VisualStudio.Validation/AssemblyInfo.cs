// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if !NETWASM
using System.Resources;
#endif
using System.Security;

#if !NETWASM
[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.MainAssembly)]
#endif
[assembly: AllowPartiallyTrustedCallers]

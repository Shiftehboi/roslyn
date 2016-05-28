﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis
{
    internal partial class SymbolKey
    {
        private class DynamicTypeSymbolKey
        {
            private static readonly object instance = new object();

            public static void Create(Visitor visitor)
            {
            }

            public static int GetHashCode(GetHashCodeReader reader)
            {
                return instance.GetHashCode();
            }

            public static SymbolKeyResolution Resolve(SymbolKeyReader reader)
            {
                return new SymbolKeyResolution(reader.Compilation.DynamicType);
            }
        }
    }
}
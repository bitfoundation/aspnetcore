// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;
using Microsoft.AspNetCore.JsonPatch.SystemTextJson.Operations;

namespace Microsoft.AspNetCore.JsonPatch.SystemTextJson;

public interface IJsonPatchDocument
{
    IJsonTypeInfoResolver TypeInfoResolver { get; set; }

    IList<Operation> GetOperations();
}

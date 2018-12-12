﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Squidex.ClientLibrary;

namespace Squidex.CLI.Commands
{
    public sealed class DummyData : Dictionary<string, Dictionary<string, JToken>>
    {
    }

    public sealed class DummyClient : SquidexEntityBase<DummyData>
    {
    }
}

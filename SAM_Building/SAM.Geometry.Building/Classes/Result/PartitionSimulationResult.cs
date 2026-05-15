// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using SAM.Core;
using SAM.Core.Building;
using System;

namespace SAM.Geometry.Building
{
    public class PartitionSimulationResult : Result, IBuildingObject
    {
        public PartitionSimulationResult(string name, string source, string reference)
            : base(name, source, reference)
        {

        }

        public PartitionSimulationResult(Guid guid, string name, string source, string reference)
            : base(guid, name, source, reference)
        {

        }

        public PartitionSimulationResult(PartitionSimulationResult partitionSimulationResult)
            : base(partitionSimulationResult)
        {

        }

        public PartitionSimulationResult(JsonObject jObject)
            : base(jObject)
        {
        }

        public override bool FromJsonObject(JsonObject jObject)
        {
            if (!base.FromJsonObject(jObject))
                return false;

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject jObject = base.ToJsonObject();
            if (jObject == null)
                return null;

            return jObject;
        }
    }
}
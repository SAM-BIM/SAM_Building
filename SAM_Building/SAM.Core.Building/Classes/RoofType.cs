// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using System.Collections.Generic;

using SAM.Architectural;

namespace SAM.Core.Building
{
    public class RoofType : HostPartitionType
    {
        public RoofType(RoofType roofType)
            : base(roofType)
        {

        }

        public RoofType(JsonObject jObject)
            : base(jObject)
        {

        }

        public RoofType(string name)
            : base(name)
        {

        }

        public RoofType(System.Guid guid, string name)
        : base(guid, name)
        {

        }

        public RoofType(RoofType roofType, string name)
            : base(roofType, name)
        {

        }

        public RoofType(string name, IEnumerable<MaterialLayer> materialLayers)
            : base(name, materialLayers)
        {

        }

        public RoofType(System.Guid guid, string name, IEnumerable<MaterialLayer> materialLayers)
            : base(guid, name, materialLayers)
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
                return jObject;

            return jObject;
        }

    }
}

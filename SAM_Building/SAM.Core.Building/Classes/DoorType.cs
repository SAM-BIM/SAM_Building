// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using SAM.Architectural;
using System.Collections.Generic;

namespace SAM.Core.Building
{
    public class DoorType : OpeningType
    {
        public DoorType(DoorType doorType)
            : base(doorType)
        {

        }

        public DoorType(DoorType doorType, string name)
            : base(doorType, name)
        {

        }

        public DoorType(JsonObject jObject)
            : base(jObject)
        {

        }

        public DoorType(string name)
            : base(name)
        {

        }

        public DoorType(System.Guid guid, string name)
            : base(guid, name)
        {

        }

        public DoorType(string name, IEnumerable<MaterialLayer> paneMaterialLayers, IEnumerable<MaterialLayer> frameMaterialLayers = null)
            : base(name, paneMaterialLayers, frameMaterialLayers)
        {

        }

        public DoorType(System.Guid guid, string name, IEnumerable<MaterialLayer> paneMaterialLayers, IEnumerable<MaterialLayer> frameMaterialLayers = null)
            : base(guid, name, paneMaterialLayers, frameMaterialLayers)
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

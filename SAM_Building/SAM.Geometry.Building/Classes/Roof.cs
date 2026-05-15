// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using SAM.Core.Building;
using SAM.Geometry.Spatial;

namespace SAM.Geometry.Building
{
    public class Roof : HostPartition<RoofType>
    {
        public Roof(Roof roof)
            : base(roof)
        {

        }

        public Roof(JsonObject jObject)
            : base(jObject)
        {

        }
        public Roof(RoofType roofType, Face3D face3D)
            : base(roofType, face3D)
        {

        }
        public Roof(System.Guid guid, RoofType roofType, Face3D face3D)
            : base(guid, roofType, face3D)
        {

        }

        public Roof(System.Guid guid, Roof roof, Face3D face3D, double tolerance = Core.Tolerance.Distance)
            : base(guid, roof, face3D, tolerance)
        {

        }

        public override bool FromJsonObject(JsonObject jObject)
        {
            if (!base.FromJsonObject(jObject))
            {
                return false;
            }

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject jObject = base.ToJsonObject();

            if (jObject == null)
            {
                return jObject;
            }

            return jObject;
        }

    }
}

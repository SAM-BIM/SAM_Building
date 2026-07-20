// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using SAM.Core.Building;
using SAM.Geometry.Spatial;

namespace SAM.Geometry.Building
{
    public class Door : Opening<DoorType>, IOpening
    {
        public Door(Door door)
            : base(door)
        {

        }

        public Door(JsonObject jObject)
            : base(jObject)
        {

        }

        public Door(DoorType doorType, Face3D face3D)
            : base(doorType, face3D)
        {

        }

        public Door(System.Guid guid, DoorType doorType, Face3D face3D)
            : base(guid, doorType, face3D)
        {

        }

        public Door(System.Guid guid, Door door, Face3D face3D)
            : base(guid, door, face3D)
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

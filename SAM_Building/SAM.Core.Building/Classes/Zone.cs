// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using System;

namespace SAM.Core.Building
{
    public class Zone : Group, IBuildingObject
    {
        public Zone(string name)
            : base(name)
        {

        }

        public Zone(Guid guid, string name)
            : base(guid, name)
        {

        }

        public Zone(Zone zone, string name)
            : base(zone, name)
        {

        }

        public Zone(Zone zone)
            : base(zone)
        {

        }

        public Zone(JsonObject jObject)
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
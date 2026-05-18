// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
namespace SAM.Core.Building
{
    public class HeatingSystem : MechanicalSystem
    {
        public HeatingSystem(string id, HeatingSystemType heatingSystemType)
            : base(id, heatingSystemType)
        {

        }

        public HeatingSystem(System.Guid guid, string id, HeatingSystem heatingSystem)
            : base(guid, id, heatingSystem)
        {

        }

        public HeatingSystem(HeatingSystem heatingSystem)
            : base(heatingSystem)
        {

        }

        public HeatingSystem(JsonObject jObject)
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
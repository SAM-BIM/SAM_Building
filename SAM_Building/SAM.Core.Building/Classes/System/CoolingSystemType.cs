// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (c) 2020–2026 Michal Dengusiak & Jakub Ziolkowski and contributors
using System.Text.Json.Nodes;
using System;

namespace SAM.Core.Building
{
    public class CoolingSystemType : MechanicalSystemType
    {
        //private string description;

        public CoolingSystemType(string name, string description)
            : base(name, description)
        {

        }

        public CoolingSystemType(Guid guid, string name, string description)
            : base(guid, name, description)
        {
        }

        public CoolingSystemType(CoolingSystemType coolingSystemType)
            : base(coolingSystemType)
        {

        }

        public CoolingSystemType(JsonObject jObject)
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
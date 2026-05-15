using System.Text.Json.Nodes;
using SAM.Core;
using SAM.Core.Building;
using System;

namespace SAM.Geometry.Building
{
    public class OpeningSimulationResult : Result, IBuildingObject
    {
        public OpeningSimulationResult(string name, string source, string reference)
            : base(name, source, reference)
        {

        }

        public OpeningSimulationResult(Guid guid, string name, string source, string reference)
            : base(guid, name, source, reference)
        {

        }

        public OpeningSimulationResult(OpeningSimulationResult openingSimulationResult)
            : base(openingSimulationResult)
        {

        }

        public OpeningSimulationResult(JsonObject jObject)
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
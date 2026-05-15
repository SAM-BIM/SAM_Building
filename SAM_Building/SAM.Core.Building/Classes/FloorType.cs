using System.Text.Json.Nodes;
using System.Collections.Generic;

using SAM.Architectural;

namespace SAM.Core.Building
{
    public class FloorType : HostPartitionType
    {
        public FloorType(FloorType floorType)
            : base(floorType)
        {

        }

        public FloorType(JsonObject jObject)
            : base(jObject)
        {

        }

        public FloorType(string name)
            : base(name)
        {

        }

        public FloorType(System.Guid guid, string name)
            : base(guid, name)
        {

        }

        public FloorType(FloorType floorType, string name)
            : base(floorType, name)
        {

        }

        public FloorType(string name, IEnumerable<MaterialLayer> materialLayers)
            : base(name, materialLayers)
        {

        }

        public FloorType(System.Guid guid, string name, IEnumerable<MaterialLayer> materialLayers)
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

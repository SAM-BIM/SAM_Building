using System.Text.Json.Nodes;
using System.Collections.Generic;

using SAM.Architectural;

namespace SAM.Core.Building
{
    public class WallType : HostPartitionType
    {
        public WallType(WallType wallType)
            : base(wallType)
        {

        }

        public WallType(WallType wallType, string name)
            : base(wallType, name)
        {

        }

        public WallType(JsonObject jObject)
            : base(jObject)
        {

        }

        public WallType(string name)
            : base(name)
        {

        }

        public WallType(System.Guid guid, string name)
            : base(guid, name)
        {

        }

        public WallType(string name, IEnumerable<MaterialLayer> materialLayers)
            : base(name, materialLayers)
        {

        }

        public WallType(System.Guid guid, string name, IEnumerable<MaterialLayer> materialLayers)
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

using System.Text.Json.Nodes;
using SAM.Core.Building;
using SAM.Geometry.Spatial;
using System;

namespace SAM.Geometry.Building
{
    public class AirPartition : BuildingElement<BuildingElementType>, IPartition
    {

        public AirPartition(AirPartition airPartition)
            : base(airPartition)
        {

        }

        public AirPartition(JsonObject jObject)
            : base(jObject)
        {

        }

        public AirPartition(Face3D face3D)
            : base(null, face3D)
        {

        }

        public AirPartition(Guid guid, Face3D face3D)
            : base(guid, null as BuildingElementType, face3D)
        {

        }

        public AirPartition(Guid guid, AirPartition airPartition, Face3D face3D)
            : base(guid, airPartition, face3D)
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

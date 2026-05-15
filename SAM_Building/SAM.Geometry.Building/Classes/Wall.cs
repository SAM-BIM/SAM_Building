using System.Text.Json.Nodes;
using SAM.Core.Building;
using SAM.Geometry.Spatial;

namespace SAM.Geometry.Building
{
    public class Wall : HostPartition<WallType>
    {
        public Wall(Wall wall)
            : base(wall)
        {

        }

        public Wall(JsonObject jObject)
            : base(jObject)
        {

        }

        public Wall(WallType wallType, Face3D face3D)
            : base(wallType, face3D)
        {

        }

        public Wall(System.Guid guid, WallType wallType, Face3D face3D)
            : base(guid, wallType, face3D)
        {

        }

        public Wall(System.Guid guid, Wall wall, Face3D face3D, double tolerance = Core.Tolerance.Distance)
            : base(guid, wall, face3D, tolerance)
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

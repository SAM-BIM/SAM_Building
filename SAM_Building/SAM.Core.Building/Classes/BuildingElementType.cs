using System.Text.Json.Nodes;
namespace SAM.Core.Building
{
    public abstract class BuildingElementType : SAMType, IBuildingObject
    {
        public BuildingElementType(BuildingElementType buildingElementType)
            : base(buildingElementType)
        {

        }

        public BuildingElementType(BuildingElementType buildingElementType, string name)
            : base(buildingElementType, name)
        {

        }

        public BuildingElementType(JsonObject jObject)
            : base(jObject)
        {

        }

        public BuildingElementType(string name)
            : base(name)
        {

        }

        public BuildingElementType(System.Guid guid, string name)
            : base(guid, name)
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

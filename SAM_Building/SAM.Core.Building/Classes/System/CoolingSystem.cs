using System.Text.Json.Nodes;
namespace SAM.Core.Building
{
    public class CoolingSystem : MechanicalSystem
    {
        public CoolingSystem(string id, CoolingSystemType coolingSystemType)
            : base(id, coolingSystemType)
        {

        }

        public CoolingSystem(System.Guid guid, string id, CoolingSystem coolingSystem)
            : base(guid, id, coolingSystem)
        {

        }

        public CoolingSystem(CoolingSystem coolingSystem)
            : base(coolingSystem)
        {

        }

        public CoolingSystem(JsonObject jObject)
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
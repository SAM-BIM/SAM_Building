using System.Text.Json.Nodes;
namespace SAM.Core.Building
{
    public class VentilationSystem : MechanicalSystem
    {
        public VentilationSystem(string id, VentilationSystemType ventilationSystemType)
            : base(id, ventilationSystemType)
        {

        }

        public VentilationSystem(System.Guid guid, string id, VentilationSystem VentilationSystem)
            : base(guid, id, VentilationSystem)
        {

        }

        public VentilationSystem(VentilationSystem ventilationSystem)
            : base(ventilationSystem)
        {

        }

        public VentilationSystem(JsonObject jObject)
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
using System.Text.Json.Nodes;
using System;

namespace SAM.Core.Building
{
    public class VentilationSystemType : MechanicalSystemType
    {
        //private string description;

        public VentilationSystemType(string name, string description)
            : base(name, description)
        {

        }

        public VentilationSystemType(Guid guid, string name, string description)
            : base(guid, name, description)
        {
        }

        public VentilationSystemType(VentilationSystemType ventilationSystemType)
            : base(ventilationSystemType)
        {

        }

        public VentilationSystemType(JsonObject jObject)
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
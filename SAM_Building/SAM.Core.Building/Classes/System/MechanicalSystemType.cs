using System.Text.Json.Nodes;
using System;

namespace SAM.Core.Building
{
    public abstract class MechanicalSystemType : SAMType, ISystemType, IBuildingObject
    {
        private string description;

        public MechanicalSystemType(string name, string description)
            : base(name)
        {
            this.description = description;
        }

        public MechanicalSystemType(Guid guid, string name, string description)
            : base(guid, name)
        {
            this.description = description;
        }

        public MechanicalSystemType(MechanicalSystemType mechanicalSystemType)
            : base(mechanicalSystemType)
        {
            description = mechanicalSystemType.description;
        }

        public MechanicalSystemType(JsonObject jObject)
            : base(jObject)
        {
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public override bool FromJsonObject(JsonObject jObject)
        {
            if (!base.FromJsonObject(jObject))
                return false;

            if (jObject.ContainsKey("Description"))
                description = jObject["Description"]?.GetValue<string>() ?? null;

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject jObject = base.ToJsonObject();
            if (jObject == null)
                return null;

            if (description != null)
                jObject.Add("Description", description);

            return jObject;
        }
    }
}
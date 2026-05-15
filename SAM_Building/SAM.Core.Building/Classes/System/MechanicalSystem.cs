using System.Text.Json.Nodes;
namespace SAM.Core.Building
{
    public abstract class MechanicalSystem : SAMInstance<MechanicalSystemType>, ISystem, IBuildingObject
    {
        private string id;

        public MechanicalSystem(string id, MechanicalSystemType mechanicalSystemType)
            : base(mechanicalSystemType)
        {
            this.id = id;
        }

        public MechanicalSystem(System.Guid guid, string id, MechanicalSystem mechanicalSystem)
            : base(guid, mechanicalSystem)
        {
            this.id = id;
        }

        public MechanicalSystem(MechanicalSystem mechanicalSystem)
            : base(mechanicalSystem)
        {
            id = mechanicalSystem?.id;
        }

        public MechanicalSystem(JsonObject jObject)
            : base(jObject)
        {
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", name == null ? string.Empty : name, id == null ? string.Empty : id).Trim();
            }
        }

        public override bool FromJsonObject(JsonObject jObject)
        {
            if (!base.FromJsonObject(jObject))
                return false;

            if (jObject.ContainsKey("Id"))
            {
                id = jObject["Id"]?.GetValue<string>() ?? null;
            }

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject jObject = base.ToJsonObject();
            if (jObject == null)
                return null;

            if (id != null)
                jObject.Add("Id", id);

            return jObject;
        }
    }
}
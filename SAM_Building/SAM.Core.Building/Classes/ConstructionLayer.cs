using System.Text.Json.Nodes;
using SAM.Architectural;

namespace SAM.Core.Building
{
    public class ConstructionLayer : MaterialLayer, IBuildingObject
    {
        public ConstructionLayer(string name, double thickness)
            : base(name, thickness)
        {
        }

        public ConstructionLayer(ConstructionLayer constructionLayer)
            : base(constructionLayer)
        {

        }

        public ConstructionLayer(JsonObject jObject)
            : base(jObject)
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
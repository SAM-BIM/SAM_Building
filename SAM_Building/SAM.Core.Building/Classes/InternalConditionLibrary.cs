using System.Text.Json.Nodes;
using System;
using System.Collections.Generic;

namespace SAM.Core.Building
{
    public class InternalConditionLibrary : SAMLibrary<InternalCondition>, IBuildingObject
    {
        public InternalConditionLibrary(string name)
            : base(name)
        {

        }

        public InternalConditionLibrary(Guid guid, string name)
            : base(guid, name)
        {

        }

        public InternalConditionLibrary(JsonObject jObject)
            : base(jObject)
        {

        }

        public InternalConditionLibrary(InternalConditionLibrary internalConditionLibrary)
            : base(internalConditionLibrary)
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

        public override string GetUniqueId(InternalCondition internalCondition)
        {
            if (internalCondition == null)
                return null;

            return internalCondition.Name;
        }

        public override bool IsValid(InternalCondition internalCondition)
        {
            if (!base.IsValid(internalCondition))
                return false;

            return true;
        }

        public List<InternalCondition> GetInternalConditions()
        {
            return GetObjects<InternalCondition>();
        }

        public List<InternalCondition> GetInternalConditions(string text, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            List<InternalCondition> internalConditions = GetInternalConditions();
            if (internalConditions == null || internalConditions.Count == 0)
                return null;

            return internalConditions.FindAll(x => Core.Query.Compare(x.Name, text, textComparisonType, caseSensitive));
        }
    }
}
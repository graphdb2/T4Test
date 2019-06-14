using System;

namespace T4Test
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public class EntityAttribute : System.Attribute
	{
		public EntityAttribute(
			string entityName,
			string entityKey,
			string[] stateKeyFields,
			string targetLabel,
			string targetStateLabel,
			string stateLinkName,
			string timeStampField = "from")
		{
			EntityName = entityName;
			EntityKey = entityKey;
			StateKeyFields = stateKeyFields;
			TargetLabel = targetLabel;
			TargetStateLabel = targetStateLabel;
			StateLinkName = stateLinkName;
			TimeStampField = timeStampField;
		}

		public virtual string EntityName { get; }

		public virtual string EntityKey { get; }

		public virtual string[] StateKeyFields { get; }

		public string TargetLabel { get; }

		public string TargetStateLabel { get; }

		public string StateLinkName { get; }

		public string TimeStampField { get; }
	}
}

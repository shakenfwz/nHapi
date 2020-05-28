using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Message
{
	[Serializable]
	public class QBP_Z01 : AbstractMessage
	{
		public override string Version => "2.4";

		public MSH MSH
		{
			get
			{
				MSH mSH = null;
				try
				{
					return (MSH)GetStructure("MSH");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public QPD QPD
		{
			get
			{
				QPD qPD = null;
				try
				{
					return (QPD)GetStructure("QPD");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public PID PID
		{
			get
			{
				PID pID = null;
				try
				{
					return (PID)GetStructure("PID");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public PV1 PV1
		{
			get
			{
				PV1 pV = null;
				try
				{
					return (PV1)GetStructure("PV1");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public QBP_Z01(IModelClassFactory factory)
			: base(factory)
		{
			init(factory);
		}

		public QBP_Z01()
			: base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}

		private void init(IModelClassFactory factory)
		{
			try
			{
				add(typeof(MSH), required: true, repeating: false);
				add(typeof(QPD), required: true, repeating: false);
				add(typeof(PID), required: true, repeating: false);
				add(typeof(PV1), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating QBP_Q21 - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

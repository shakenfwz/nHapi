using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Message
{
	[Serializable]
	public class MFN_Z2B : AbstractMessage
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

		public MFI MFI
		{
			get
			{
				MFI mFI = null;
				try
				{
					return (MFI)GetStructure("MFI");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public int MFRepetitionsUsed
		{
			get
			{
				int num = -1;
				try
				{
					return GetAll("Nofification").Length;
				}
				catch (HL7Exception t)
				{
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					HapiLogFactory.GetHapiLog(GetType()).Error(message, t);
					throw new Exception(message);
				}
			}
		}

		public MFN_Z2B(IModelClassFactory factory)
			: base(factory)
		{
			init(factory);
		}

		public MFN_Z2B()
			: base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}

		private void init(IModelClassFactory factory)
		{
			try
			{
				add(typeof(MSH), required: true, repeating: false);
				add(typeof(MFI), required: true, repeating: false);
				add(typeof(MFN_Z2B_Nofification), required: true, repeating: true);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFQ_M01 - this is probably a bug in the source code generator.", t);
			}
		}

		public MFN_Z2B_Nofification GetMF()
		{
			MFN_Z2B_Nofification mFN_Z2B_Nofification = null;
			try
			{
				return (MFN_Z2B_Nofification)GetStructure("Nofification");
			}
			catch (HL7Exception ex)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
				throw new Exception("An unexpected error ocurred", ex);
			}
		}

		public MFN_Z2B_Nofification GetMF(int rep)
		{
			return (MFN_Z2B_Nofification)GetStructure("Nofification", rep);
		}
	}
}

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Group
{
	[Serializable]
	public class MFN_Z5M_Nofification : AbstractGroup
	{
		public MFE MFE
		{
			get
			{
				MFE mFE = null;
				try
				{
					return (MFE)GetStructure("MFE");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public Z5M Z5M
		{
			get
			{
				Z5M z5M = null;
				try
				{
					return (Z5M)GetStructure("Z5M");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public MFN_Z5M_Nofification()
			: base(null, null)
		{
		}

		public MFN_Z5M_Nofification(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			try
			{
				add(typeof(MFE), required: true, repeating: false);
				add(typeof(Z5M), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M13_MF_DAIMA - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Group
{
	[Serializable]
	public class MFN_Z6B_Nofification : AbstractGroup
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

		public Z6B Z6B
		{
			get
			{
				Z6B z6B = null;
				try
				{
					return (Z6B)GetStructure("Z6B");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public MFN_Z6B_Nofification()
			: base(null, null)
		{
		}

		public MFN_Z6B_Nofification(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			try
			{
				add(typeof(MFE), required: true, repeating: false);
				add(typeof(Z6B), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M13_MF_DAIMA - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

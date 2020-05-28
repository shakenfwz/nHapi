using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Group
{
	[Serializable]
	public class MFN_Z6G_Nofification : AbstractGroup
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

		public Z6G Z6G
		{
			get
			{
				Z6G z6G = null;
				try
				{
					return (Z6G)GetStructure("Z6G");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public MFN_Z6G_Nofification()
			: base(null, null)
		{
		}

		public MFN_Z6G_Nofification(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			try
			{
				add(typeof(MFE), required: true, repeating: false);
				add(typeof(Z6G), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M13_MF_DAIMA - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

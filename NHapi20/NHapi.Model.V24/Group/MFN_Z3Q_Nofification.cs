using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Group
{
	[Serializable]
	public class MFN_Z3Q_Nofification : AbstractGroup
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

		public Z3Q Z3Q
		{
			get
			{
				Z3Q z3Q = null;
				try
				{
					return (Z3Q)GetStructure("Z3Q");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public MFN_Z3Q_Nofification()
			: base(null, null)
		{
		}

		public MFN_Z3Q_Nofification(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			try
			{
				add(typeof(MFE), required: true, repeating: false);
				add(typeof(Z3Q), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M13_MF_DAIMA - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

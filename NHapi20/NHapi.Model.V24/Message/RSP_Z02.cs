using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Segment;
using System;

namespace NHapi.Model.V24.Message
{
	[Serializable]
	public class RSP_Z02 : AbstractMessage
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

		public MSA MSA
		{
			get
			{
				MSA mSA = null;
				try
				{
					return (MSA)GetStructure("MSA");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public ERR ERR
		{
			get
			{
				ERR eRR = null;
				try
				{
					return (ERR)GetStructure("ERR");
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
			}
		}

		public QAK QAK
		{
			get
			{
				QAK qAK = null;
				try
				{
					return (QAK)GetStructure("QAK");
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

		public RSP_Z02(IModelClassFactory factory)
			: base(factory)
		{
			init(factory);
		}

		public RSP_Z02()
			: base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}

		private void init(IModelClassFactory factory)
		{
			try
			{
				add(typeof(MSH), required: true, repeating: false);
				add(typeof(MSA), required: true, repeating: false);
				add(typeof(ERR), required: false, repeating: false);
				add(typeof(QAK), required: true, repeating: false);
				add(typeof(QPD), required: true, repeating: false);
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RSP_Z90 - this is probably a bug in the source code generator.", t);
			}
		}
	}
}

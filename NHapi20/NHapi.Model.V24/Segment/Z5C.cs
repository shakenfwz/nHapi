using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class Z5C : AbstractSegment
	{
		public ST YiBaoId
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(1, 0);
					return (ST)field;
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
				catch (Exception ex2)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex2);
					throw new Exception("An unexpected error ocurred", ex2);
				}
			}
		}

		public ST YiBaoMc
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(2, 0);
					return (ST)field;
				}
				catch (HL7Exception ex)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new Exception("An unexpected error ocurred", ex);
				}
				catch (Exception ex2)
				{
					HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex2);
					throw new Exception("An unexpected error ocurred", ex2);
				}
			}
		}

		public Z5C()
			: base(null, null)
		{
		}

		public Z5C(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "医保ID");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "医保名称");
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, t);
			}
		}
	}
}

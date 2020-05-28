using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class Z2B : AbstractSegment
	{
		public ST KeShiId
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

		public CE YuanQu
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(2, 0);
					return (CE)field;
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

		public ST KeShiMc
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(3, 0);
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

		public ST KeShiBm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(4, 0);
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

		public ST WeiZhiSm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(5, 0);
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

		public ST YingWenMing
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(6, 0);
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

		public XTN LianXiDh
		{
			get
			{
				XTN xTN = null;
				try
				{
					IType field = GetField(7, 0);
					return (XTN)field;
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

		public CE HeSuanKs
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(8, 0);
					return (CE)field;
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

		public CE ChengBenKs
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(9, 0);
					return (CE)field;
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

		public CE RenShiKs
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(10, 0);
					return (CE)field;
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

		public NM MenZhenSyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(11, 0);
					return (NM)field;
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

		public NM ZhuYuanSyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(12, 0);
					return (NM)field;
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

		public NM JiZhenSyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(13, 0);
					return (NM)field;
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

		public NM ZuoFeiBZ
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(14, 0);
					return (NM)field;
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

		public int ShuRuMaRepetitionsUsed
		{
			get
			{
				try
				{
					return GetTotalFieldRepetitionsUsed(15);
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

		public XCN XiuGaiRen
		{
			get
			{
				XCN xCN = null;
				try
				{
					IType field = GetField(16, 0);
					return (XCN)field;
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

		public TS XiuGaiSJ
		{
			get
			{
				TS tS = null;
				try
				{
					IType field = GetField(17, 0);
					return (TS)field;
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

		public CE ShangJiKs
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(18, 0);
					return (CE)field;
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

		public NM KeShiLB
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(19, 0);
					return (NM)field;
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

		public ST KeShiXz
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(20, 0);
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

		public CE KeShiSx
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(18, 0);
					return (CE)field;
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

		public Z2B()
			: base(null, null)
		{
		}

		public Z2B(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(ST), required: true, 1, 20, new object[1]
				{
					message
				}, "科室ID");
				add(typeof(CE), required: false, 1, 100, new object[1]
				{
					message
				}, "院区");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "科室名称");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "科室别名");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "位置说明");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "英文名");
				add(typeof(XTN), required: false, 1, 250, new object[1]
				{
					message
				}, "联系电话");
				add(typeof(CE), required: false, 1, 250, new object[1]
				{
					message
				}, "核算科室");
				add(typeof(CE), required: false, 1, 250, new object[1]
				{
					message
				}, "成本科室");
				add(typeof(CE), required: false, 1, 250, new object[1]
				{
					message
				}, "人事科室");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "门诊标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "住院标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "急诊标志");
				add(typeof(NM), required: true, 1, 1, new object[1]
				{
					message
				}, "作废标志");
				add(typeof(CE), required: false, 0, 100, new object[1]
				{
					message
				}, "输入码");
				add(typeof(XCN), required: true, 1, 20, new object[1]
				{
					message
				}, "修改人");
				add(typeof(TS), required: true, 1, 26, new object[1]
				{
					message
				}, "修改时间");
				add(typeof(CE), required: true, 1, 250, new object[1]
				{
					message
				}, "上级科室");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "科室类别");
				add(typeof(ST), required: false, 1, 2, new object[1]
				{
					message
				}, "科室性质");
				add(typeof(CE), required: false, 0, 250, new object[1]
				{
					message
				}, "科室属性");
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, t);
			}
		}

		public CE GetShuRuMa(int rep)
		{
			CE cE = null;
			try
			{
				IType field = GetField(15, rep);
				return (CE)field;
			}
			catch (Exception ex)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new Exception("An unexpected error ocurred", ex);
			}
		}

		public CE[] GetShuRuMa()
		{
			CE[] array = null;
			try
			{
				IType[] field = GetField(15);
				array = new CE[field.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (CE)field[i];
				}
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
			return array;
		}
	}
}

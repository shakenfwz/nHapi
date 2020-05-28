using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class Z3G : AbstractSegment
	{
		public ST PinCiId
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

		public ST PinCiMc
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

		public ST XianShiMc
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

		public NM YiRiCs
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(4, 0);
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

		public NM ZhouQi
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(5, 0);
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

		public NM ZhouQiCs
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(6, 0);
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

		public NM JiaGeTs
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(7, 0);
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

		public NM XingQiBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(8, 0);
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

		public NM ZuoFeiBz
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

		public SI ShunXuHao
		{
			get
			{
				SI sI = null;
				try
				{
					IType field = GetField(12, 0);
					return (SI)field;
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

		public NM ZhuYuanSyBz
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

		public int ZhiXingRqRepetitionsUsed
		{
			get
			{
				try
				{
					return GetTotalFieldRepetitionsUsed(9);
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

		public int ZhiXingSjdRepetitionsUsed
		{
			get
			{
				try
				{
					return GetTotalFieldRepetitionsUsed(10);
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

		public NM PinCiLx
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(16, 0);
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

		public XCN XiuGaiRen
		{
			get
			{
				XCN xCN = null;
				try
				{
					IType field = GetField(17, 0);
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

		public TS XiuGaiShiJian
		{
			get
			{
				TS tS = null;
				try
				{
					IType field = GetField(18, 0);
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

		public Z3G()
			: base(null, null)
		{
		}

		public Z3G(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "用药频次ID");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "用药频次名称");
				add(typeof(ST), required: true, 1, 100, new object[1]
				{
					message
				}, "显示名称");
				add(typeof(NM), required: false, 1, 4, new object[1]
				{
					message
				}, "一日次数");
				add(typeof(NM), required: false, 1, 4, new object[1]
				{
					message
				}, "周期");
				add(typeof(NM), required: false, 1, 4, new object[1]
				{
					message
				}, "周期内次数");
				add(typeof(NM), required: false, 1, 4, new object[1]
				{
					message
				}, "间隔天数");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "星期标志");
				add(typeof(NM), required: false, 1, 50, new object[1]
				{
					message
				}, "执行日期");
				add(typeof(TM), required: false, 1, 5, new object[1]
				{
					message
				}, "执行时间点");
				add(typeof(NM), required: true, 1, 1, new object[1]
				{
					message
				}, "作废标志");
				add(typeof(SI), required: false, 1, 6, new object[1]
				{
					message
				}, "顺序号");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "门诊使用标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "住院使用标志");
				add(typeof(CE), required: false, 0, 100, new object[1]
				{
					message
				}, "输入码");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "频次类型");
				add(typeof(XCN), required: false, 1, 20, new object[1]
				{
					message
				}, "修改人");
				add(typeof(TS), required: false, 1, 26, new object[1]
				{
					message
				}, "修改时间");
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, t);
			}
		}

		public NM GetZhiXingRq(int rep)
		{
			NM nM = null;
			try
			{
				IType field = GetField(9, rep);
				return (NM)field;
			}
			catch (Exception ex)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new Exception("An unexpected error ocurred", ex);
			}
		}

		public NM[] GetZhiXingRq()
		{
			NM[] array = null;
			try
			{
				IType[] field = GetField(9);
				array = new NM[field.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (NM)field[i];
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

		public TM GetZhiXingSjd(int rep)
		{
			TM tM = null;
			try
			{
				IType field = GetField(10, rep);
				return (TM)field;
			}
			catch (Exception ex)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new Exception("An unexpected error ocurred", ex);
			}
		}

		public TM[] GetZhiXingSjd()
		{
			TM[] array = null;
			try
			{
				IType[] field = GetField(10);
				array = new TM[field.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (TM)field[i];
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

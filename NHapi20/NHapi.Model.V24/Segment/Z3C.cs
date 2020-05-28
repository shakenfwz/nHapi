using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class Z3C : AbstractSegment
	{
		public ST JiaGeId
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

		public ST YaoPinMc
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

		public ST YaoPinId
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

		public CE ZhangBuLb
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(4, 0);
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

		public CE ChanDi
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(5, 0);
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

		public CE JiXing
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(6, 0);
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

		public CE GeiYaoFs
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(7, 0);
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

		public ST GuiGe
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(8, 0);
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

		public CQ YaoPinBz
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(9, 0);
					return (CQ)field;
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

		public ST YaoPinZxDw
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(10, 0);
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

		public CQ JiLiang
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(11, 0);
					return (CQ)field;
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

		public NM NongDu
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

		public CQ TiJi
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(13, 0);
					return (CQ)field;
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

		public ST PiShiBz
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(14, 0);
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

		public NM PiShiYxTs
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(15, 0);
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

		public NM GMPBZ
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

		public NM FuFangBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(17, 0);
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

		public NM OTCBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(18, 0);
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

		public NM WeiJinBz
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

		public NM HuaLiaoBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(20, 0);
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

		public NM FeiYongLrBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(21, 0);
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

		public NM LingChaJBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(22, 0);
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

		public ST MenZhenSyBz
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(23, 0);
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

		public ST ZhuYuanSyBz
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(24, 0);
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

		public ST ZhuCeSb
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(25, 0);
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

		public ST PiZhunWh
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(26, 0);
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

		public ST JinKouYpZh
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(27, 0);
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

		public ST YaoPinJySm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(28, 0);
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

		public MO DanJia1
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(29, 0);
					return (MO)field;
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

		public MO DanJia2
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(30, 0);
					return (MO)field;
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

		public MO DanJia3
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(31, 0);
					return (MO)field;
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

		public MO DanJia4
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(32, 0);
					return (MO)field;
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

		public MO DanJia5
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(33, 0);
					return (MO)field;
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
					IType field = GetField(34, 0);
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

		public TS XiuGaiSj
		{
			get
			{
				TS tS = null;
				try
				{
					IType field = GetField(35, 0);
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

		public NM ZuoFeiBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(36, 0);
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

		public NM TingYongBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(37, 0);
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
					return GetTotalFieldRepetitionsUsed(38);
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

		public ST GuiGeId
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(39, 0);
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

		public ST DaGuiGeId
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(40, 0);
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

		public ST XiaoGuiGeId
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(41, 0);
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

		public CQ RiChangJl
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(42, 0);
					return (CQ)field;
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

		public CQ DanJiLiang
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(43, 0);
					return (CQ)field;
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

		public ST KangJunYaoXj
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(44, 0);
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

		public ST KangShengSuXj
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(45, 0);
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

		public CE DuliFl
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(46, 0);
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

		public CE JiaZhiFl
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(47, 0);
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

		public CE YaoPinLx
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(48, 0);
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

		public NM DaShuYBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(49, 0);
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

		public NM JiBenYw
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(50, 0);
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

		public NM ShengBuChong
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(51, 0);
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

		public NM GaoWeiYp
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(52, 0);
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

		public NM ZhaoBiaoBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(53, 0);
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

		public MO ZhaoBiaoJj
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(54, 0);
					return (MO)field;
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

		public NM CaiGouBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(55, 0);
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

		public MO PiFaJia
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(56, 0);
					return (MO)field;
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

		public MO ZuiGaoLsj
		{
			get
			{
				MO mO = null;
				try
				{
					IType field = GetField(57, 0);
					return (MO)field;
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

		public ST YaoPinHxm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(58, 0);
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

		public ST YaoLiFlDmAHFS
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(59, 0);
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

		public ST YaoLiFlDmATC7
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(60, 0);
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

		public ST YaoPinTxm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(61, 0);
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

		public ST ZhuSheSm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(62, 0);
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

		public ST PeiZhiSm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(63, 0);
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

		public NM PeiZhiSmDyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(64, 0);
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

		public ST CunChuSm
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(65, 0);
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

		public NM BiGuangBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(66, 0);
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

		public NM CunChuWd
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(67, 0);
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

		public NM ZhuYuanWp
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(68, 0);
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

		public NM ErTongZyyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(69, 0);
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

		public NM HuLiShdBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(70, 0);
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

		public NM YiYuanSpBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(71, 0);
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

		public ST HuaiYunFj
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(72, 0);
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

		public ST TiDaiYp
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(73, 0);
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

		public ST MoRenGyPc
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(74, 0);
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

		public CQ MeiRiZdJl
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(75, 0);
					return (CQ)field;
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

		public CQ MeiCiZdJl
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(76, 0);
					return (CQ)field;
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

		public CQ MeiCiZxJl
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(77, 0);
					return (CQ)field;
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

		public CQ DanCiZlJl
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(78, 0);
					return (CQ)field;
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

		public NM DanCiQzBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(79, 0);
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

		public NM YuSheRs
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(80, 0);
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

		public NM MoRenSyPl
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(81, 0);
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

		public NM ShiFouKyLj
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(82, 0);
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

		public NM YiNianJTzJl
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(83, 0);
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

		public NM YiQiGTzJl
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(84, 0);
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

		public NM ShiYongPlBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(85, 0);
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

		public ST KaiFenghYxSs
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(86, 0);
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

		public ST BeiZhu
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(87, 0);
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

		public NM ShiFouBbKh
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(88, 0);
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

		public NM KeFouMf
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(89, 0);
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

		public NM KeFouBb
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(90, 0);
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

		public CE YiZhuLb
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(91, 0);
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

		public CE JianShiFl
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(92, 0);
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

		public NM GuoJiaZb2013
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(93, 0);
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

		public NM ShengZengBu2013
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(94, 0);
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

		public NM JiBenYwDsy
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(95, 0);
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

		public NM LianJiaYwBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(96, 0);
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

		public NM ChuFangJeTjBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(97, 0);
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

		public CE FuYaoSx
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(98, 0);
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

		public ST ShiYongYuanQu
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(99, 0);
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

		public CE DuiYingPSYP
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(100, 0);
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

		public int DuiYingPSYPRepetitionsUsed
		{
			get
			{
				try
				{
					return GetTotalFieldRepetitionsUsed(100);
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

		public NM JiZhenYyBz
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(101, 0);
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

		public CE YaoPinFL
		{
			get
			{
				CE cE = null;
				try
				{
					IType field = GetField(102, 0);
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

		public ST YaoPinTYMC
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(103, 0);
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

		public Z3C()
			: base(null, null)
		{
		}

		public Z3C(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "价格ID");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "价格名称");
				add(typeof(ST), required: false, 1, 10, new object[1]
				{
					message
				}, "药品ID");
				add(typeof(CE), required: false, 1, 100, new object[1]
				{
					message
				}, "账簿类别");
				add(typeof(CE), required: false, 1, 100, new object[1]
				{
					message
				}, "产地");
				add(typeof(CE), required: false, 1, 100, new object[1]
				{
					message
				}, "剂型");
				add(typeof(CE), required: false, 1, 100, new object[1]
				{
					message
				}, "给药方式");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "规格");
				add(typeof(CQ), required: false, 1, 50, new object[1]
				{
					message
				}, "药品包装");
				add(typeof(ST), required: false, 1, 20, new object[1]
				{
					message
				}, "药品最小单位");
				add(typeof(CQ), required: false, 0, 50, new object[1]
				{
					message
				}, "剂量");
				add(typeof(NM), required: false, 1, 20, new object[1]
				{
					message
				}, "浓度");
				add(typeof(CQ), required: false, 1, 50, new object[1]
				{
					message
				}, "体积");
				add(typeof(ST), required: false, 1, 4, new object[1]
				{
					message
				}, "皮试标志");
				add(typeof(NM), required: false, 1, 6, new object[1]
				{
					message
				}, "皮试有效天数");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "GMP标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "复方标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "OTC标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "违禁标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "化疗标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "费用录入标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "零差价标志");
				add(typeof(ST), required: false, 1, 20, new object[1]
				{
					message
				}, "门药使用");
				add(typeof(ST), required: false, 1, 20, new object[1]
				{
					message
				}, "病药使用");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "注册商标");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "批准文号");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "进口药品证号");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "用药简要说明");
				add(typeof(MO), required: true, 1, 12, new object[1]
				{
					message
				}, "单价1");
				add(typeof(MO), required: false, 1, 12, new object[1]
				{
					message
				}, "单价2");
				add(typeof(MO), required: false, 1, 12, new object[1]
				{
					message
				}, "单价3");
				add(typeof(MO), required: false, 1, 12, new object[1]
				{
					message
				}, "单价4");
				add(typeof(MO), required: false, 1, 12, new object[1]
				{
					message
				}, "单价5");
				add(typeof(XCN), required: true, 1, 20, new object[1]
				{
					message
				}, "修改人");
				add(typeof(TS), required: true, 1, 26, new object[1]
				{
					message
				}, "修改时间");
				add(typeof(NM), required: true, 1, 1, new object[1]
				{
					message
				}, "作废标志");
				add(typeof(NM), required: true, 1, 1, new object[1]
				{
					message
				}, "停用标志");
				add(typeof(CE), required: false, 0, 100, new object[1]
				{
					message
				}, "输入码");
				add(typeof(ST), required: false, 0, 10, new object[1]
				{
					message
				}, "规格ID");
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "大规格ID（分装分类）");
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "小规格ID");
				add(typeof(CQ), required: true, 1, 50, new object[1]
				{
					message
				}, "日常用量");
				add(typeof(CQ), required: true, 1, 50, new object[1]
				{
					message
				}, "单剂量");
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "抗菌药限级");
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "抗生素限级");
				add(typeof(CE), required: true, 1, 100, new object[1]
				{
					message
				}, "药品毒理分类");
				add(typeof(CE), required: true, 1, 100, new object[1]
				{
					message
				}, "药品价值分类");
				add(typeof(CE), required: true, 1, 100, new object[1]
				{
					message
				}, "药品类型");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "大输液标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "基本药物");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "省补充");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "高危药品");
				add(typeof(NM), required: true, 1, 2, new object[1]
				{
					message
				}, "招标标志");
				add(typeof(MO), required: true, 1, 12, new object[1]
				{
					message
				}, "招标进价");
				add(typeof(NM), required: true, 1, 4, new object[1]
				{
					message
				}, "采购标志");
				add(typeof(MO), required: true, 1, 12, new object[1]
				{
					message
				}, "批发价");
				add(typeof(MO), required: true, 1, 12, new object[1]
				{
					message
				}, "最高零售价");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "药品化学名");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "药理分类代码(AHFS)");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "药理分类代码(ATC7)");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "药品条形码");
				add(typeof(ST), required: false, 1, 200, new object[1]
				{
					message
				}, "注射说明");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "配置说明");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "配置说明打印标志");
				add(typeof(ST), required: false, 1, 200, new object[1]
				{
					message
				}, "存储说明");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "避光标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "存储温度");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "住院外配");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "儿童专用药标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "护理双核对标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "医院审批标志");
				add(typeof(ST), required: false, 1, 1, new object[1]
				{
					message
				}, "怀孕分级");
				add(typeof(ST), required: false, 1, 200, new object[1]
				{
					message
				}, "替代药品");
				add(typeof(ST), required: false, 1, 10, new object[1]
				{
					message
				}, "默认给药频次");
				add(typeof(CQ), required: false, 1, 20, new object[1]
				{
					message
				}, "每日最大剂量");
				add(typeof(CQ), required: false, 1, 1, new object[1]
				{
					message
				}, "每次最大剂量");
				add(typeof(CQ), required: false, 1, 20, new object[1]
				{
					message
				}, "每次最小剂量");
				add(typeof(CQ), required: false, 1, 20, new object[1]
				{
					message
				}, "单次治疗剂量");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "单次取整标志");
				add(typeof(NM), required: false, 1, 2, new object[1]
				{
					message
				}, "预设日数");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "默认使用频率");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "是否可以累计");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "依年纪调整剂量");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "依器官调整剂量");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "是否适用Daily频率");
				add(typeof(ST), required: false, 1, 4, new object[1]
				{
					message
				}, "开封后有效时数");
				add(typeof(ST), required: false, 1, 200, new object[1]
				{
					message
				}, "备注");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "是否剥半刻痕");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "可否磨粉");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "可否剥半");
				add(typeof(CE), required: false, 1, 50, new object[1]
				{
					message
				}, "医嘱类别");
				add(typeof(CE), required: false, 1, 50, new object[1]
				{
					message
				}, "检视分类");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "国家增补2013");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "省增补2013");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "基本药物大输液");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "廉价药物标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "处方金额不统计标志");
				add(typeof(CE), required: false, 1, 50, new object[1]
				{
					message
				}, "服药顺序");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "使用院区");
				add(typeof(CE), required: false, 0, 50, new object[1]
				{
					message
				}, "对应皮试药品");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "急诊用药标志");
				add(typeof(CE), required: true, 1, 100, new object[1]
				{
					message
				}, "药品分类");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "药品通用名称");
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
				IType field = GetField(38, rep);
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
				IType[] field = GetField(38);
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

		public CE[] GetDuiYingPSYP()
		{
			CE[] array = null;
			try
			{
				IType[] field = GetField(100);
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

		public CE GetDuiYingPSYP(int rep)
		{
			CE cE = null;
			try
			{
				IType field = GetField(100, rep);
				return (CE)field;
			}
			catch (Exception ex)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new Exception("An unexpected error ocurred", ex);
			}
		}
	}
}

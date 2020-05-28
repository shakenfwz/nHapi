using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class Z3Q : AbstractSegment
	{
		public NM GuoJiaZb2013
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(42, 0);
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
					IType field = GetField(43, 0);
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
					IType field = GetField(44, 0);
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
					IType field = GetField(45, 0);
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
					IType field = GetField(46, 0);
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

		public ST GuiGeId
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

		public CE JiXing
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

		public CE GeiYaoFs
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

		public ST GuiGe
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(7, 0);
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
					IType field = GetField(8, 0);
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
					IType field = GetField(9, 0);
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
					IType field = GetField(10, 0);
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

		public CQ TiJi
		{
			get
			{
				CQ cQ = null;
				try
				{
					IType field = GetField(12, 0);
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
					IType field = GetField(13, 0);
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

		public NM GMPBZ
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

		public NM FuFangBz
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

		public NM OTCBz
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

		public NM WeiJinBz
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

		public NM HuaLiaoBz
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

		public NM FeiYongLrBz
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

		public NM MenZhenSyBz
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

		public NM ZhuYuanSyBz
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

		public ST YaoPinJySm
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

		public XCN XiuGaiRen
		{
			get
			{
				XCN xCN = null;
				try
				{
					IType field = GetField(24, 0);
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
					IType field = GetField(25, 0);
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
					IType field = GetField(26, 0);
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
					return GetTotalFieldRepetitionsUsed(27);
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

		public ST XiaoGuiGeId
		{
			get
			{
				ST sT = null;
				try
				{
					IType field = GetField(29, 0);
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
					IType field = GetField(30, 0);
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
					IType field = GetField(31, 0);
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
					IType field = GetField(32, 0);
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
					IType field = GetField(33, 0);
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
					IType field = GetField(34, 0);
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
					IType field = GetField(35, 0);
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
					IType field = GetField(36, 0);
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

		public NM JiBenYw
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(38, 0);
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
					IType field = GetField(39, 0);
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
					IType field = GetField(40, 0);
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

		public ST YongYaoSm
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

		public Z3Q()
			: base(null, null)
		{
		}

		public Z3Q(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(ST), required: true, 1, 10, new object[1]
				{
					message
				}, "规格ID");
				add(typeof(ST), required: false, 1, 100, new object[1]
				{
					message
				}, "药品名称");
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
				}, "门诊使用标志");
				add(typeof(NM), required: false, 1, 1, new object[1]
				{
					message
				}, "住院使用标志");
				add(typeof(ST), required: false, 1, 50, new object[1]
				{
					message
				}, "用药简要说明");
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
				add(typeof(CE), required: false, 0, 100, new object[1]
				{
					message
				}, "输入码");
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
				add(typeof(ST), required: true, 1, 2000, new object[1]
				{
					message
				}, "用药说明");
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
				IType field = GetField(27, rep);
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
				IType[] field = GetField(27);
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

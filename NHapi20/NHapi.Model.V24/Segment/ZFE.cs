using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace NHapi.Model.V24.Segment
{
	[Serializable]
	public class ZFE : AbstractSegment
	{
		public NM ZYZLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(1, 0);
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

		public NM ZHONGCHENGYF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(2, 0);
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

		public NM ZHONGCAOYF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(3, 0);
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

		public NM ZLYYCXYYCLF
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

		public NM HSJC
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

		public NM CSF
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

		public NM FSF
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

		public NM JHJFZHXSBF
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

		public NM SYF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(9, 0);
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

		public NM YBZLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(10, 0);
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

		public NM HLZLF
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

		public NM GHF
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

		public NM ZCF
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

		public NM CWF
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

		public NM SXF
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

		public NM XBYZLZPF
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

		public NM XYF
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

		public NM JSF
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

		public NM JRZLF
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

		public NM SSYYCXYYCLF
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

		public NM JRYYCXYYCLF
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

		public NM SSF
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

		public NM HYF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(23, 0);
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

		public NM QDBLZPF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(24, 0);
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

		public NM QTFY
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(25, 0);
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

		public NM NXYZLZPF
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

		public NM MZF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(27, 0);
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

		public NM YBJCF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(28, 0);
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

		public NM HSZL
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(29, 0);
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

		public NM LCWLZLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(30, 0);
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

		public NM KJYWF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(31, 0);
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

		public NM KFZLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(32, 0);
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

		public NM JCYYCXYYCLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(33, 0);
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

		public NM HLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(34, 0);
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

		public NM TSZLF
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(35, 0);
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

		public NM JSZLF
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

		public NM BLF
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

		public NM BDBLZPF
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

		public NM ZFY
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

		public NM ZFFY
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

		public NM QT
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(41, 0);
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

		public NM ZHOGNYIZD
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

		public NM ZHONGYIZL
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

		public NM ZHONGYIWZ
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

		public NM ZHENCIYULF
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

		public NM ZHONGYITNZL
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

		public NM ZHONGYITSZL
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(47, 0);
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

		public NM ZHONGYAOTSTPJG
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(48, 0);
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

		public NM BIANZHENGSS
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

		public NM ZHONGYIQT
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

		public NM ZHONGYIGCZL
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

		public NM ZHONGYIGS
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

		public NM ZHONGYIBZLZ
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

		public NM ZHONGYIBZLZHZ
		{
			get
			{
				NM nM = null;
				try
				{
					IType field = GetField(54, 0);
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

		public ZFE(IGroup parent, IModelClassFactory factory)
			: base(parent, factory)
		{
			IMessage message = Message;
			try
			{
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(中医治疗费)中医治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(中成药费)中成药费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(中草药费)中草药费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(治疗用一次性医用材料费)治疗用一次性医用材料费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(影像学诊断费)核素检查");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(影像学诊断费)超声费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(影像学诊断费)放射费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般治疗操作费)监护及辅助呼吸设备费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般治疗操作费)输氧费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般治疗操作费)一般治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般治疗操作费)护理治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般医疗服务费)挂号费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般医疗服务费)诊查费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(一般医疗服务费)床位费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(血费)输血费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(细胞因子类制品费)细胞因子类制品费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(西药费)西药费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(手术治疗费)接生费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(手术治疗费)介入治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(手术用一次性医用材料费)手术用一次性医用材料费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(手术用一次性医用材料费)介入用一次性医用材料费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(手术费)手术费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(实验室诊断费)化验费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(球蛋白类制品费)球蛋白类制品费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(其他费用)其他");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(凝血因子类制品费)凝血因子类制品费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(麻醉费)麻醉费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(临床诊断项目费)一般检查费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(临床物理治疗费)核素治疗");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(临床物理治疗费)临床物理治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(抗菌药物费用)抗菌药物费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(康复费)康复治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(检查用一次性医用材料费)检查用一次性医用材料费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(护理费)护理费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(非手术治疗项目费)特殊治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(非手术治疗项目费)精神治疗费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(病理诊断费)病理费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(白蛋白类制品费)白蛋白类制品费");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "总费用");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "自付费用");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "(其他)其他");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医诊断（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医治疗（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医外治（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "针刺与灸法（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医推拿治疗（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医特殊治疗（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中药特殊调配加工（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "辨证施膳（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医其他（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医肛肠治疗（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医骨伤（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医辨证论治（标准外字段）");
				add(typeof(NM), required: false, 1, 18, new object[1]
				{
					message
				}, "中医辨证论治会诊（标准外字段）");
			}
			catch (HL7Exception t)
			{
				HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, t);
			}
		}
	}
}

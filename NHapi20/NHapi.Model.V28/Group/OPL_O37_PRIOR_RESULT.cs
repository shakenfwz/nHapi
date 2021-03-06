using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the OPL_O37_PRIOR_RESULT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: NK1 (Next of Kin / Associated Parties) repeating</li>
///<li>1: OPL_O37_PATIENT_PRIOR (a Group object) optional </li>
///<li>2: OPL_O37_PATIENT_VISIT_PRIOR (a Group object) optional </li>
///<li>3: AL1 (Patient Allergy Information) optional </li>
///<li>4: OPL_O37_ORDER_PRIOR (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class OPL_O37_PRIOR_RESULT : AbstractGroup {

	///<summary> 
	/// Creates a new OPL_O37_PRIOR_RESULT Group.
	///</summary>
	public OPL_O37_PRIOR_RESULT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NK1), true, true);
	      this.add(typeof(OPL_O37_PATIENT_PRIOR), false, false);
	      this.add(typeof(OPL_O37_PATIENT_VISIT_PRIOR), false, false);
	      this.add(typeof(AL1), false, false);
	      this.add(typeof(OPL_O37_ORDER_PRIOR), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OPL_O37_PRIOR_RESULT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of NK1 (Next of Kin / Associated Parties) - creates it if necessary
	///</summary>
	public NK1 GetNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NK1
	/// * (Next of Kin / Associated Parties) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NK1 GetNK1(int rep) { 
	   return (NK1)this.GetStructure("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NK1 results 
	 */ 
	public IEnumerable<NK1> NK1s 
	{ 
		get
		{
			for (int rep = 0; rep < NK1RepetitionsUsed; rep++)
			{
				yield return (NK1)this.GetStructure("NK1", rep);
			}
		}
	}

	///<summary>
	///Adds a new NK1
	///</summary>
	public NK1 AddNK1()
	{
		return this.AddStructure("NK1") as NK1;
	}

	///<summary>
	///Removes the given NK1
	///</summary>
	public void RemoveNK1(NK1 toRemove)
	{
		this.RemoveStructure("NK1", toRemove);
	}

	///<summary>
	///Removes the NK1 at the given index
	///</summary>
	public void RemoveNK1At(int index)
	{
		this.RemoveRepetition("NK1", index);
	}

	///<summary>
	/// Returns OPL_O37_PATIENT_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OPL_O37_PATIENT_PRIOR PATIENT_PRIOR { 
get{
	   OPL_O37_PATIENT_PRIOR ret = null;
	   try {
	      ret = (OPL_O37_PATIENT_PRIOR)this.GetStructure("PATIENT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OPL_O37_PATIENT_VISIT_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OPL_O37_PATIENT_VISIT_PRIOR PATIENT_VISIT_PRIOR { 
get{
	   OPL_O37_PATIENT_VISIT_PRIOR ret = null;
	   try {
	      ret = (OPL_O37_PATIENT_VISIT_PRIOR)this.GetStructure("PATIENT_VISIT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns AL1 (Patient Allergy Information) - creates it if necessary
	///</summary>
	public AL1 AL1 { 
get{
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.GetStructure("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OPL_O37_ORDER_PRIOR (a Group object) - creates it if necessary
	///</summary>
	public OPL_O37_ORDER_PRIOR GetORDER_PRIOR() {
	   OPL_O37_ORDER_PRIOR ret = null;
	   try {
	      ret = (OPL_O37_ORDER_PRIOR)this.GetStructure("ORDER_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OPL_O37_ORDER_PRIOR
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OPL_O37_ORDER_PRIOR GetORDER_PRIOR(int rep) { 
	   return (OPL_O37_ORDER_PRIOR)this.GetStructure("ORDER_PRIOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OPL_O37_ORDER_PRIOR 
	 */ 
	public int ORDER_PRIORRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER_PRIOR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the OPL_O37_ORDER_PRIOR results 
	 */ 
	public IEnumerable<OPL_O37_ORDER_PRIOR> ORDER_PRIORs 
	{ 
		get
		{
			for (int rep = 0; rep < ORDER_PRIORRepetitionsUsed; rep++)
			{
				yield return (OPL_O37_ORDER_PRIOR)this.GetStructure("ORDER_PRIOR", rep);
			}
		}
	}

	///<summary>
	///Adds a new OPL_O37_ORDER_PRIOR
	///</summary>
	public OPL_O37_ORDER_PRIOR AddORDER_PRIOR()
	{
		return this.AddStructure("ORDER_PRIOR") as OPL_O37_ORDER_PRIOR;
	}

	///<summary>
	///Removes the given OPL_O37_ORDER_PRIOR
	///</summary>
	public void RemoveORDER_PRIOR(OPL_O37_ORDER_PRIOR toRemove)
	{
		this.RemoveStructure("ORDER_PRIOR", toRemove);
	}

	///<summary>
	///Removes the OPL_O37_ORDER_PRIOR at the given index
	///</summary>
	public void RemoveORDER_PRIORAt(int index)
	{
		this.RemoveRepetition("ORDER_PRIOR", index);
	}

}
}

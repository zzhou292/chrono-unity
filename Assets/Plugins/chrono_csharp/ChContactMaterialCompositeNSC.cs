//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChContactMaterialCompositeNSC : ChContactMaterialComposite {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChContactMaterialCompositeNSC(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChContactMaterialCompositeNSC_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChContactMaterialCompositeNSC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChContactMaterialCompositeNSC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public float static_friction {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_static_friction_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_static_friction_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float sliding_friction {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_sliding_friction_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_sliding_friction_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float rolling_friction {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_rolling_friction_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_rolling_friction_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float spinning_friction {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_spinning_friction_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_spinning_friction_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float restitution {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_restitution_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_restitution_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float cohesion {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_cohesion_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_cohesion_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float dampingf {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_dampingf_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_dampingf_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float compliance {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_compliance_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_compliance_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceT {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_complianceT_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_complianceT_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceRoll {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_complianceRoll_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_complianceRoll_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float complianceSpin {
    set {
      chronoPINVOKE.ChContactMaterialCompositeNSC_complianceSpin_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChContactMaterialCompositeNSC_complianceSpin_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChContactMaterialCompositeNSC() : this(chronoPINVOKE.new_ChContactMaterialCompositeNSC__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChContactMaterialCompositeNSC(ChContactMaterialCompositionStrategy strategy, ChContactMaterialNSC mat1, ChContactMaterialNSC mat2) : this(chronoPINVOKE.new_ChContactMaterialCompositeNSC__SWIG_1(ChContactMaterialCompositionStrategy.getCPtr(strategy), ChContactMaterialNSC.getCPtr(mat1), ChContactMaterialNSC.getCPtr(mat2)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChContactMaterialCompositeNSC_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChContactMaterialCompositeNSC_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

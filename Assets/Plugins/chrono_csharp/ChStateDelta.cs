//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChStateDelta : ChVectorDynamicd {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChStateDelta(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChStateDelta_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChStateDelta obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          chronoPINVOKE.delete_ChStateDelta(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChStateDelta(ChIntegrable intgr) : this(chronoPINVOKE.new_ChStateDelta__SWIG_0(ChIntegrable.getCPtr(intgr)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChStateDelta() : this(chronoPINVOKE.new_ChStateDelta__SWIG_1(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChStateDelta(SWIGTYPE_p_Eigen__Index size, ChIntegrable intgr) : this(chronoPINVOKE.new_ChStateDelta__SWIG_2(SWIGTYPE_p_Eigen__Index.getCPtr(size), ChIntegrable.getCPtr(intgr)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChStateDelta(SWIGTYPE_p_Eigen__RefT_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_t_const_t vec, ChIntegrable intgr) : this(chronoPINVOKE.new_ChStateDelta__SWIG_3(SWIGTYPE_p_Eigen__RefT_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_t_const_t.getCPtr(vec), ChIntegrable.getCPtr(intgr)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChStateDelta(ChStateDelta other) : this(chronoPINVOKE.new_ChStateDelta__SWIG_4(ChStateDelta.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setZero(SWIGTYPE_p_Eigen__Index size, ChIntegrable intgr) {
    chronoPINVOKE.ChStateDelta_setZero(swigCPtr, SWIGTYPE_p_Eigen__Index.getCPtr(size), ChIntegrable.getCPtr(intgr));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChIntegrable GetIntegrable() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChStateDelta_GetIntegrable(swigCPtr);
    ChIntegrable ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChIntegrable(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

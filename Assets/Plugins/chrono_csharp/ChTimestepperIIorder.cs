//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTimestepperIIorder : ChTimestepper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTimestepperIIorder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChTimestepperIIorder_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTimestepperIIorder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChTimestepperIIorder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual ChState GetStatePos() {
    ChState ret = new ChState(chronoPINVOKE.ChTimestepperIIorder_GetStatePos(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChStateDelta GetStateVel() {
    ChStateDelta ret = new ChStateDelta(chronoPINVOKE.ChTimestepperIIorder_GetStateVel(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChStateDelta GetStateAcc() {
    ChStateDelta ret = new ChStateDelta(chronoPINVOKE.ChTimestepperIIorder_GetStateAcc(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetIntegrable(ChIntegrableIIorder intgr) {
    chronoPINVOKE.ChTimestepperIIorder_SetIntegrable(swigCPtr, ChIntegrableIIorder.getCPtr(intgr));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

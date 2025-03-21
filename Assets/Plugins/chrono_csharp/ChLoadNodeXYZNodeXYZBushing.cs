//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadNodeXYZNodeXYZBushing : ChLoadNodeXYZNodeXYZ {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadNodeXYZNodeXYZBushing(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadNodeXYZNodeXYZBushing obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLoadNodeXYZNodeXYZBushing(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadNodeXYZNodeXYZBushing(ChNodeXYZ nodeA, ChNodeXYZ nodeB) : this(chronoPINVOKE.new_ChLoadNodeXYZNodeXYZBushing(ChNodeXYZ.getCPtr(nodeA), ChNodeXYZ.getCPtr(nodeB)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeForce(ChVector3d rel_pos, ChVector3d rel_vel, ChVector3d abs_force) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_ComputeForce(swigCPtr, ChVector3d.getCPtr(rel_pos), ChVector3d.getCPtr(rel_vel), ChVector3d.getCPtr(abs_force));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceX(ChFunction fx) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SetFunctionForceX(swigCPtr, ChFunction.getCPtr(fx));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceY(ChFunction fy) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SetFunctionForceY(swigCPtr, ChFunction.getCPtr(fy));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceZ(ChFunction fz) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SetFunctionForceZ(swigCPtr, ChFunction.getCPtr(fz));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDamping(ChVector3d damping) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SetDamping(swigCPtr, ChVector3d.getCPtr(damping));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3d GetDamping() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_GetDamping(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiff(bool ms) {
    chronoPINVOKE.ChLoadNodeXYZNodeXYZBushing_SetStiff(swigCPtr, ms);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

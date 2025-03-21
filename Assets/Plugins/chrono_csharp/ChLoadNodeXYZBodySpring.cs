//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadNodeXYZBodySpring : ChLoadNodeXYZBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadNodeXYZBodySpring(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLoadNodeXYZBodySpring_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadNodeXYZBodySpring obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLoadNodeXYZBodySpring(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadNodeXYZBodySpring(ChNodeXYZ mnodeA, ChBody mbodyB, double stiffness, double damping, double rest_length) : this(chronoPINVOKE.new_ChLoadNodeXYZBodySpring__SWIG_0(ChNodeXYZ.getCPtr(mnodeA), ChBody.getCPtr(mbodyB), stiffness, damping, rest_length), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLoadNodeXYZBodySpring(ChNodeXYZ mnodeA, ChBody mbodyB, double stiffness, double damping) : this(chronoPINVOKE.new_ChLoadNodeXYZBodySpring__SWIG_1(ChNodeXYZ.getCPtr(mnodeA), ChBody.getCPtr(mbodyB), stiffness, damping), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeForce(ChFrameMovingd rel_AB, ChVector3d loc_force) {
    chronoPINVOKE.ChLoadNodeXYZBodySpring_ComputeForce(swigCPtr, ChFrameMovingd.getCPtr(rel_AB), ChVector3d.getCPtr(loc_force));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStiffness(double stiffness) {
    chronoPINVOKE.ChLoadNodeXYZBodySpring_SetStiffness(swigCPtr, stiffness);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetStiffness() {
    double ret = chronoPINVOKE.ChLoadNodeXYZBodySpring_GetStiffness(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDamping(double damping) {
    chronoPINVOKE.ChLoadNodeXYZBodySpring_SetDamping(swigCPtr, damping);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetDamping() {
    double ret = chronoPINVOKE.ChLoadNodeXYZBodySpring_GetDamping(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestLength(double mrest) {
    chronoPINVOKE.ChLoadNodeXYZBodySpring_SetRestLength(swigCPtr, mrest);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetRestLength() {
    double ret = chronoPINVOKE.ChLoadNodeXYZBodySpring_GetRestLength(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiff(bool ms) {
    chronoPINVOKE.ChLoadNodeXYZBodySpring_SetStiff(swigCPtr, ms);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

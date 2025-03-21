//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMateRackPinion : ChLinkMateGeneric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMateRackPinion(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLinkMateRackPinion_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMateRackPinion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLinkMateRackPinion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkMateRackPinion() : this(chronoPINVOKE.new_ChLinkMateRackPinion__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateRackPinion(ChLinkMateRackPinion other) : this(chronoPINVOKE.new_ChLinkMateRackPinion__SWIG_1(ChLinkMateRackPinion.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void UpdateTime(double mytime) {
    chronoPINVOKE.ChLinkMateRackPinion_UpdateTime(swigCPtr, mytime);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPinionRadius() {
    double ret = chronoPINVOKE.ChLinkMateRackPinion_GetPinionRadius(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPinionRadius(double mR) {
    chronoPINVOKE.ChLinkMateRackPinion_SetPinionRadius(swigCPtr, mR);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPressureAngle() {
    double ret = chronoPINVOKE.ChLinkMateRackPinion_GetPressureAngle(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPressureAngle(double mset) {
    chronoPINVOKE.ChLinkMateRackPinion_SetPressureAngle(swigCPtr, mset);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPitchAngle() {
    double ret = chronoPINVOKE.ChLinkMateRackPinion_GetPitchAngle(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPitchAngle(double mset) {
    chronoPINVOKE.ChLinkMateRackPinion_SetPitchAngle(swigCPtr, mset);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPhase() {
    double ret = chronoPINVOKE.ChLinkMateRackPinion_GetPhase(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPhase(double mset) {
    chronoPINVOKE.ChLinkMateRackPinion_SetPhase(swigCPtr, mset);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetEnforcePhase(bool mset) {
    chronoPINVOKE.ChLinkMateRackPinion_SetEnforcePhase(swigCPtr, mset);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetEnforcePhase() {
    bool ret = chronoPINVOKE.ChLinkMateRackPinion_GetEnforcePhase(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRotation1() {
    double ret = chronoPINVOKE.ChLinkMateRackPinion_GetRotation1(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ResetRotation1() {
    chronoPINVOKE.ChLinkMateRackPinion_ResetRotation1(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPinionFrame(ChFramed mf) {
    chronoPINVOKE.ChLinkMateRackPinion_SetPinionFrame(swigCPtr, ChFramed.getCPtr(mf));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFramed GetPinionFrame() {
    ChFramed ret = new ChFramed(chronoPINVOKE.ChLinkMateRackPinion_GetPinionFrame(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRackFrame(ChFramed mf) {
    chronoPINVOKE.ChLinkMateRackPinion_SetRackFrame(swigCPtr, ChFramed.getCPtr(mf));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFramed GetRackFrame() {
    ChFramed ret = new ChFramed(chronoPINVOKE.ChLinkMateRackPinion_GetRackFrame(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetAbsPinionDir() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLinkMateRackPinion_GetAbsPinionDir(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetAbsPinionPos() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLinkMateRackPinion_GetAbsPinionPos(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetAbsRackDir() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLinkMateRackPinion_GetAbsRackDir(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetAbsRackPos() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLinkMateRackPinion_GetAbsRackPos(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChLinkMateRackPinion_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChLinkMateRackPinion_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

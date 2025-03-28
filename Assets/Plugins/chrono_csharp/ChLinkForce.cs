//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkForce : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChLinkForce(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChLinkForce() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          chronoPINVOKE.delete_ChLinkForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChLinkForce() : this(chronoPINVOKE.new_ChLinkForce__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkForce(ChLinkForce other) : this(chronoPINVOKE.new_ChLinkForce__SWIG_1(ChLinkForce.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkForce Clone() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChLinkForce_Clone(swigCPtr);
    ChLinkForce ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkForce(cPtr, false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsActive() {
    bool ret = chronoPINVOKE.ChLinkForce_IsActive(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActive(bool val) {
    chronoPINVOKE.ChLinkForce_SetActive(swigCPtr, val);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetActuatorForceTorque() {
    double ret = chronoPINVOKE.ChLinkForce_GetActuatorForceTorque(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActuatorForceTorque(double F) {
    chronoPINVOKE.ChLinkForce_SetActuatorForceTorque(swigCPtr, F);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSpringCoefficient() {
    double ret = chronoPINVOKE.ChLinkForce_GetSpringCoefficient(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpringCoefficient(double K) {
    chronoPINVOKE.ChLinkForce_SetSpringCoefficient(swigCPtr, K);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetDampingCoefficient() {
    double ret = chronoPINVOKE.ChLinkForce_GetDampingCoefficient(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDampingCoefficient(double R) {
    chronoPINVOKE.ChLinkForce_SetDampingCoefficient(swigCPtr, R);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetActuatorModulation() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChLinkForce_GetActuatorModulation(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction GetSpringModulation() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChLinkForce_GetSpringModulation(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction GetDamperModulation() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChLinkForce_GetDamperModulation(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActuatorModulation(ChFunction funct) {
    chronoPINVOKE.ChLinkForce_SetActuatorModulation(swigCPtr, ChFunction.getCPtr(funct));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSpringModulation(ChFunction funct) {
    chronoPINVOKE.ChLinkForce_SetSpringModulation(swigCPtr, ChFunction.getCPtr(funct));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDamperModulation(ChFunction funct) {
    chronoPINVOKE.ChLinkForce_SetDamperModulation(swigCPtr, ChFunction.getCPtr(funct));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetCurrentActuatorForceTorque(double x, double x_dt, double t) {
    double ret = chronoPINVOKE.ChLinkForce_GetCurrentActuatorForceTorque(swigCPtr, x, x_dt, t);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCurrentSpringCoefficient(double x, double x_dt, double t) {
    double ret = chronoPINVOKE.ChLinkForce_GetCurrentSpringCoefficient(swigCPtr, x, x_dt, t);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCurrentDampingCoefficient(double x, double x_dt, double t) {
    double ret = chronoPINVOKE.ChLinkForce_GetCurrentDampingCoefficient(swigCPtr, x, x_dt, t);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetForceTorque(double x, double x_dt, double t) {
    double ret = chronoPINVOKE.ChLinkForce_GetForceTorque(swigCPtr, x, x_dt, t);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChLinkForce_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChLinkForce_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaftsElasticGear : ChLoadCustomMultiple {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaftsElasticGear(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChShaftsElasticGear_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaftsElasticGear obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChShaftsElasticGear(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChShaftsElasticGear(ChShaft shaft1, ChShaft shaft2, double stiffness, double damping, double Ra, double ratio) : this(chronoPINVOKE.new_ChShaftsElasticGear__SWIG_0(ChShaft.getCPtr(shaft1), ChShaft.getCPtr(shaft2), stiffness, damping, Ra, ratio), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaftsElasticGear(ChShaft shaft1, ChShaft shaft2, double stiffness, double damping, double Ra) : this(chronoPINVOKE.new_ChShaftsElasticGear__SWIG_1(ChShaft.getCPtr(shaft1), ChShaft.getCPtr(shaft2), stiffness, damping, Ra), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTeethStiffness(double stiffness) {
    chronoPINVOKE.ChShaftsElasticGear_SetTeethStiffness(swigCPtr, stiffness);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTeethStiffness() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetTeethStiffness(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTeethDamping(double damping) {
    chronoPINVOKE.ChShaftsElasticGear_SetTeethDamping(swigCPtr, damping);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTeethDamping() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetTeethDamping(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestPhase(double phase) {
    chronoPINVOKE.ChShaftsElasticGear_SetRestPhase(swigCPtr, phase);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetRestPhase() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetRestPhase(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTransmissionRatioAndRadiusA(double ratio, double Ra) {
    chronoPINVOKE.ChShaftsElasticGear_SetTransmissionRatioAndRadiusA(swigCPtr, ratio, Ra);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTransmissionRatioFromRadii(double Ra, double Rb, bool internal_) {
    chronoPINVOKE.ChShaftsElasticGear_SetTransmissionRatioFromRadii__SWIG_0(swigCPtr, Ra, Rb, internal_);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTransmissionRatioFromRadii(double Ra, double Rb) {
    chronoPINVOKE.ChShaftsElasticGear_SetTransmissionRatioFromRadii__SWIG_1(swigCPtr, Ra, Rb);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTransmissionRatio() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetTransmissionRatio(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetGearRadius1() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetGearRadius1(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetGearRadius2() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetGearRadius2(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetContactForce() {
    double ret = chronoPINVOKE.ChShaftsElasticGear_GetContactForce(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

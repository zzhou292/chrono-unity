//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class HMMWV_FialaTire : ChFialaTire {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal HMMWV_FialaTire(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.HMMWV_FialaTire_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HMMWV_FialaTire obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_HMMWV_FialaTire(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public HMMWV_FialaTire(string name) : this(chrono_vehiclePINVOKE.new_HMMWV_FialaTire(name), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetNormalStiffnessForce(double depth) {
    double ret = chrono_vehiclePINVOKE.HMMWV_FialaTire_GetNormalStiffnessForce(swigCPtr, depth);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetNormalDampingForce(double depth, double velocity) {
    double ret = chrono_vehiclePINVOKE.HMMWV_FialaTire_GetNormalDampingForce(swigCPtr, depth, velocity);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetVisualizationWidth() {
    double ret = chrono_vehiclePINVOKE.HMMWV_FialaTire_GetVisualizationWidth(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetFialaParams() {
    chrono_vehiclePINVOKE.HMMWV_FialaTire_SetFialaParams(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTireMass() {
    double ret = chrono_vehiclePINVOKE.HMMWV_FialaTire_GetTireMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d GetTireInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.HMMWV_FialaTire_GetTireInertia(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    chrono_vehiclePINVOKE.HMMWV_FialaTire_AddVisualizationAssets(swigCPtr, (int)vis);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    chrono_vehiclePINVOKE.HMMWV_FialaTire_RemoveVisualizationAssets(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

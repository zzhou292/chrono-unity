//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class M113_Suspension : ChTranslationalDamperSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal M113_Suspension(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.M113_Suspension_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(M113_Suspension obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_M113_Suspension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public M113_Suspension(string name, VehicleSide side, int index, bool use_bushings, bool has_shock) : this(chrono_vehiclePINVOKE.new_M113_Suspension(name, (int)side, index, use_bushings, has_shock), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetArmMass() {
    double ret = chrono_vehiclePINVOKE.M113_Suspension_GetArmMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d GetArmInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.M113_Suspension_GetArmInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetArmVisRadius() {
    double ret = chrono_vehiclePINVOKE.M113_Suspension_GetArmVisRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChVehicleBushingData_t getArmBushingData() {
    SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChVehicleBushingData_t ret = new SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChVehicleBushingData_t(chrono_vehiclePINVOKE.M113_Suspension_getArmBushingData(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetSpringRestAngle() {
    double ret = chrono_vehiclePINVOKE.M113_Suspension_GetSpringRestAngle(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TorqueFunctor GetSpringTorqueFunctor() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.M113_Suspension_GetSpringTorqueFunctor(swigCPtr);
    TorqueFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new TorqueFunctor(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor GetShockForceFunctor() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.M113_Suspension_GetShockForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

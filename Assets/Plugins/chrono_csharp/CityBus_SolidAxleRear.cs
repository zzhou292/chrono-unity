//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CityBus_SolidAxleRear : ChSolidAxle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal CityBus_SolidAxleRear(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CityBus_SolidAxleRear obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_CityBus_SolidAxleRear(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual double getAxleTubeMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpindleMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getULMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getULMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLLMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getLLMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getKnuckleMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getTierodMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getDraglinkMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getBellCrankMass() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleTubeRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleWidth() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleWidth(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getULRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getULRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLLRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getLLRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getKnuckleRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getTierodRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getDraglinkRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getBellCrankRadius() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getAxleTubeInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getSpindleInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getULInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getULInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getLLInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getLLInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getKnuckleInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getTierodInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getTierodInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getDraglinkInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getBellCrankInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleInertia() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getAxleInertia(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpringRestLength() {
    double ret = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpringRestLength(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getSpringForceFunctor() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getSpringForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getShockForceFunctor() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getShockForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d getAxleTubeCOM() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeCOM(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

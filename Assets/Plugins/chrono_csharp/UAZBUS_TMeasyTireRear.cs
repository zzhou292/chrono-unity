//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class UAZBUS_TMeasyTireRear : ChTMeasyTire {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal UAZBUS_TMeasyTireRear(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UAZBUS_TMeasyTireRear obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_UAZBUS_TMeasyTireRear(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public UAZBUS_TMeasyTireRear(string name) : this(chrono_vehiclePINVOKE.new_UAZBUS_TMeasyTireRear(name), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetVisualizationWidth() {
    double ret = chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_GetVisualizationWidth(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetTMeasyParams() {
    chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_SetTMeasyParams(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTireMass() {
    double ret = chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_GetTireMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d GetTireInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_GetTireInertia(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_AddVisualizationAssets(swigCPtr, (int)vis);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_RemoveVisualizationAssets(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GenerateCharacteristicPlots(string dirname) {
    chrono_vehiclePINVOKE.UAZBUS_TMeasyTireRear_GenerateCharacteristicPlots(swigCPtr, dirname);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

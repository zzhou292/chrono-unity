//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class BMW_E90_TMsimpleTireFront : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal BMW_E90_TMsimpleTireFront(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BMW_E90_TMsimpleTireFront obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BMW_E90_TMsimpleTireFront() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          chrono_vehiclePINVOKE.delete_BMW_E90_TMsimpleTireFront(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public BMW_E90_TMsimpleTireFront(string name) : this(chrono_vehiclePINVOKE.new_BMW_E90_TMsimpleTireFront(name), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetVisualizationWidth() {
    double ret = chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_GetVisualizationWidth(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetTMsimpleParams() {
    chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_SetTMsimpleParams(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetTireMass() {
    double ret = chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_GetTireMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d GetTireInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_GetTireInertia(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void AddVisualizationAssets(VisualizationType vis) {
    chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_AddVisualizationAssets(swigCPtr, (int)vis);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RemoveVisualizationAssets() {
    chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_RemoveVisualizationAssets(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GenerateCharacteristicPlots(string dirname) {
    chrono_vehiclePINVOKE.BMW_E90_TMsimpleTireFront_GenerateCharacteristicPlots(swigCPtr, dirname);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

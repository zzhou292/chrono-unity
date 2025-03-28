//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChPart : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChPart(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChPart obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChPart() {
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
          chrono_vehiclePINVOKE.delete_ChPart(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string GetName() {
    string ret = chrono_vehiclePINVOKE.ChPart_GetName(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    chrono_vehiclePINVOKE.ChPart_SetName(swigCPtr, name);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetTemplateName() {
    string ret = chrono_vehiclePINVOKE.ChPart_GetTemplateName(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInitialized() {
    bool ret = chrono_vehiclePINVOKE.ChPart_IsInitialized(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMass() {
    double ret = chrono_vehiclePINVOKE.ChPart_GetMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFramed GetCOMFrame() {
    ChFramed ret = new ChFramed(chrono_vehiclePINVOKE.ChPart_GetCOMFrame(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMatrix33d GetInertia() {
    ChMatrix33d ret = new ChMatrix33d(chrono_vehiclePINVOKE.ChPart_GetInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFramed GetTransform() {
    ChFramed ret = new ChFramed(chrono_vehiclePINVOKE.ChPart_GetTransform(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetVisualizationType(VisualizationType vis) {
    chrono_vehiclePINVOKE.ChPart_SetVisualizationType(swigCPtr, (int)vis);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddVisualizationAssets(VisualizationType vis) {
    chrono_vehiclePINVOKE.ChPart_AddVisualizationAssets(swigCPtr, (int)vis);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RemoveVisualizationAssets() {
    chrono_vehiclePINVOKE.ChPart_RemoveVisualizationAssets(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetOutput(bool state) {
    chrono_vehiclePINVOKE.ChPart_SetOutput(swigCPtr, state);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool OutputEnabled() {
    bool ret = chrono_vehiclePINVOKE.ChPart_OutputEnabled(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ExportComponentList(SWIGTYPE_p_rapidjson__Document jsonDocument) {
    chrono_vehiclePINVOKE.ChPart_ExportComponentList(swigCPtr, SWIGTYPE_p_rapidjson__Document.getCPtr(jsonDocument));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Output(ChVehicleOutput database) {
    chrono_vehiclePINVOKE.ChPart_Output(swigCPtr, ChVehicleOutput.getCPtr(database));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ChMatrix33d TransformInertiaMatrix(ChVector3d moments, ChVector3d products, ChMatrix33d vehicle_rot, ChMatrix33d body_rot) {
    ChMatrix33d ret = new ChMatrix33d(chrono_vehiclePINVOKE.ChPart_TransformInertiaMatrix(ChVector3d.getCPtr(moments), ChVector3d.getCPtr(products), ChMatrix33d.getCPtr(vehicle_rot), ChMatrix33d.getCPtr(body_rot)), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

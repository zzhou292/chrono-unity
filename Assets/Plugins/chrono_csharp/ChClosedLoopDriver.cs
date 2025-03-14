//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChClosedLoopDriver : ChDriver {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChClosedLoopDriver(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.ChClosedLoopDriver_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChClosedLoopDriver obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_ChClosedLoopDriver(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public void SetDesiredSpeed(double val) {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_SetDesiredSpeed(swigCPtr, val);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetThresholdThrottle(double val) {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_SetThresholdThrottle(swigCPtr, val);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSpeedController GetSpeedController() {
    ChSpeedController ret = new ChSpeedController(chrono_vehiclePINVOKE.ChClosedLoopDriver_GetSpeedController(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_Reset(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize() {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_Initialize(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Advance(double step) {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_Advance(swigCPtr, step);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColor(ChColor color) {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_SetColor(swigCPtr, ChColor.getCPtr(color));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void ExportPathPovray(string out_dir) {
    chrono_vehiclePINVOKE.ChClosedLoopDriver_ExportPathPovray(swigCPtr, out_dir);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChChassisConnector : ChPart {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChChassisConnector(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.ChChassisConnector_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChChassisConnector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_ChChassisConnector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void Initialize(ChChassis front, ChChassisRear rear) {
    chrono_vehiclePINVOKE.ChChassisConnector_Initialize(swigCPtr, ChChassis.getCPtr(front), ChChassisRear.getCPtr(rear));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Synchronize(double time, DriverInputs driver_inputs) {
    chrono_vehiclePINVOKE.ChChassisConnector_Synchronize(swigCPtr, time, DriverInputs.getCPtr(driver_inputs));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

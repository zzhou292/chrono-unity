//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class HMMWV_Wheel : ChWheel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal HMMWV_Wheel(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.HMMWV_Wheel_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HMMWV_Wheel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_HMMWV_Wheel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public HMMWV_Wheel(string name) : this(chrono_vehiclePINVOKE.new_HMMWV_Wheel(name), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetWheelMass() {
    double ret = chrono_vehiclePINVOKE.HMMWV_Wheel_GetWheelMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d GetWheelInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.HMMWV_Wheel_GetWheelInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetRadius() {
    double ret = chrono_vehiclePINVOKE.HMMWV_Wheel_GetRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetWidth() {
    double ret = chrono_vehiclePINVOKE.HMMWV_Wheel_GetWidth(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, ChBody spindle, VehicleSide side, double offset) {
    chrono_vehiclePINVOKE.HMMWV_Wheel_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), ChBody.getCPtr(spindle), (int)side, offset);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChBody spindle, VehicleSide side) {
    chrono_vehiclePINVOKE.HMMWV_Wheel_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), ChBody.getCPtr(spindle), (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Kraz_trailer : ChWheeledTrailer {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Kraz_trailer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.Kraz_trailer_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Kraz_trailer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_Kraz_trailer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Kraz_trailer(ChSystem system, CollisionType chassis_collision_type) : this(chrono_vehiclePINVOKE.new_Kraz_trailer__SWIG_0(ChSystem.getCPtr(system), (int)chassis_collision_type), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public Kraz_trailer(ChSystem system) : this(chrono_vehiclePINVOKE.new_Kraz_trailer__SWIG_1(ChSystem.getCPtr(system)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint GetNumberAxles() {
    uint ret = chrono_vehiclePINVOKE.Kraz_trailer_GetNumberAxles(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringForce(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetSpringForce(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringLength(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetSpringLength(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringDeformation(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetSpringDeformation(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockForce(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetShockForce(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLength(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetShockLength(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockVelocity(int axle, VehicleSide side) {
    double ret = chrono_vehiclePINVOKE.Kraz_trailer_GetShockVelocity(swigCPtr, axle, (int)side);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis frontChassis) {
    chrono_vehiclePINVOKE.Kraz_trailer_Initialize(swigCPtr, ChChassis.getCPtr(frontChassis));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

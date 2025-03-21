//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class M113_Vehicle_DoublePin : M113_Vehicle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal M113_Vehicle_DoublePin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.M113_Vehicle_DoublePin_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(M113_Vehicle_DoublePin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_M113_Vehicle_DoublePin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public M113_Vehicle_DoublePin(bool fixed_, DoublePinTrackShoeType shoe_topology, DrivelineTypeTV driveline_type, BrakeType brake_type, bool use_track_bushings, bool use_suspension_bushings, bool use_track_RSDA, ChContactMethod contact_method, CollisionType chassis_collision_type) : this(chrono_vehiclePINVOKE.new_M113_Vehicle_DoublePin__SWIG_0(fixed_, (int)shoe_topology, (int)driveline_type, (int)brake_type, use_track_bushings, use_suspension_bushings, use_track_RSDA, (int)contact_method, (int)chassis_collision_type), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public M113_Vehicle_DoublePin(bool fixed_, DoublePinTrackShoeType shoe_topology, DrivelineTypeTV driveline_type, BrakeType brake_type, bool use_track_bushings, bool use_suspension_bushings, bool use_track_RSDA, ChContactMethod contact_method) : this(chrono_vehiclePINVOKE.new_M113_Vehicle_DoublePin__SWIG_1(fixed_, (int)shoe_topology, (int)driveline_type, (int)brake_type, use_track_bushings, use_suspension_bushings, use_track_RSDA, (int)contact_method), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public M113_Vehicle_DoublePin(bool fixed_, DoublePinTrackShoeType shoe_topology, DrivelineTypeTV driveline_type, BrakeType brake_type, bool use_track_bushings, bool use_suspension_bushings, bool use_track_RSDA) : this(chrono_vehiclePINVOKE.new_M113_Vehicle_DoublePin__SWIG_2(fixed_, (int)shoe_topology, (int)driveline_type, (int)brake_type, use_track_bushings, use_suspension_bushings, use_track_RSDA), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public M113_Vehicle_DoublePin(bool fixed_, DoublePinTrackShoeType shoe_topology, DrivelineTypeTV driveline_type, BrakeType brake_type, bool use_track_bushings, bool use_suspension_bushings, bool use_track_RSDA, ChSystem system, CollisionType chassis_collision_type) : this(chrono_vehiclePINVOKE.new_M113_Vehicle_DoublePin__SWIG_3(fixed_, (int)shoe_topology, (int)driveline_type, (int)brake_type, use_track_bushings, use_suspension_bushings, use_track_RSDA, ChSystem.getCPtr(system), (int)chassis_collision_type), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public M113_Vehicle_DoublePin(bool fixed_, DoublePinTrackShoeType shoe_topology, DrivelineTypeTV driveline_type, BrakeType brake_type, bool use_track_bushings, bool use_suspension_bushings, bool use_track_RSDA, ChSystem system) : this(chrono_vehiclePINVOKE.new_M113_Vehicle_DoublePin__SWIG_4(fixed_, (int)shoe_topology, (int)driveline_type, (int)brake_type, use_track_bushings, use_suspension_bushings, use_track_RSDA, ChSystem.getCPtr(system)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

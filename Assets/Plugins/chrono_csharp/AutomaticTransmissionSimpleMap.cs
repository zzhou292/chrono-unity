//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AutomaticTransmissionSimpleMap : ChAutomaticTransmissionSimpleMap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal AutomaticTransmissionSimpleMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.AutomaticTransmissionSimpleMap_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AutomaticTransmissionSimpleMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_AutomaticTransmissionSimpleMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public AutomaticTransmissionSimpleMap(string filename) : this(chrono_vehiclePINVOKE.new_AutomaticTransmissionSimpleMap__SWIG_0(filename), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public AutomaticTransmissionSimpleMap(SWIGTYPE_p_rapidjson__Document d) : this(chrono_vehiclePINVOKE.new_AutomaticTransmissionSimpleMap__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetGearRatios(vector_double fwd, SWIGTYPE_p_double rev) {
    chrono_vehiclePINVOKE.AutomaticTransmissionSimpleMap_SetGearRatios(swigCPtr, vector_double.getCPtr(fwd), SWIGTYPE_p_double.getCPtr(rev));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetShiftPoints(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t shift_bands) {
    chrono_vehiclePINVOKE.AutomaticTransmissionSimpleMap_SetShiftPoints(swigCPtr, SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(shift_bands));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}

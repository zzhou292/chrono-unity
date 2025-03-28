//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TranslationalIdler : ChTranslationalIdler {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TranslationalIdler(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.TranslationalIdler_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TranslationalIdler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_TranslationalIdler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TranslationalIdler(string filename) : this(chrono_vehiclePINVOKE.new_TranslationalIdler__SWIG_0(filename), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TranslationalIdler(SWIGTYPE_p_rapidjson__Document d) : this(chrono_vehiclePINVOKE.new_TranslationalIdler__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetCarrierMass() {
    double ret = chrono_vehiclePINVOKE.TranslationalIdler_GetCarrierMass(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVector3d GetCarrierInertia() {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.TranslationalIdler_GetCarrierInertia(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCarrierVisRadius() {
    double ret = chrono_vehiclePINVOKE.TranslationalIdler_GetCarrierVisRadius(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetPrismaticPitchAngle() {
    double ret = chrono_vehiclePINVOKE.TranslationalIdler_GetPrismaticPitchAngle(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor GetTensionerForceCallback() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.TranslationalIdler_GetTensionerForceCallback(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTensionerFreeLength() {
    double ret = chrono_vehiclePINVOKE.TranslationalIdler_GetTensionerFreeLength(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

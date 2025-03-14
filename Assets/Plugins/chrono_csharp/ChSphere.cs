//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSphere : ChVolume {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSphere(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChSphere_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSphere obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChSphere(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChSphere() : this(chronoPINVOKE.new_ChSphere__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSphere(double radius) : this(chronoPINVOKE.new_ChSphere__SWIG_1(radius), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSphere(ChSphere source) : this(chronoPINVOKE.new_ChSphere__SWIG_2(ChSphere.getCPtr(source)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChSphere_Clone(swigCPtr);
    ChSphere ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChSphere(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new ChGeometry.Type GetType() {
    ChGeometry.Type ret = (ChGeometry.Type)chronoPINVOKE.ChSphere_GetType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRadius() {
    double ret = chronoPINVOKE.ChSphere_GetRadius(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetVolume() {
    double ret = chronoPINVOKE.ChSphere_GetVolume__SWIG_0(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChMatrix33d GetGyration() {
    ChMatrix33d ret = new ChMatrix33d(chronoPINVOKE.ChSphere_GetGyration__SWIG_0(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChAABB GetBoundingBox() {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChSphere_GetBoundingBox__SWIG_0(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetBoundingSphereRadius() {
    double ret = chronoPINVOKE.ChSphere_GetBoundingSphereRadius__SWIG_0(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d Baricenter() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChSphere_Baricenter(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d Evaluate(double parU, double parV, double parW) {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChSphere_Evaluate(swigCPtr, parU, parV, parW), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChSphere_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChSphere_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double GetVolume(double radius) {
    double ret = chronoPINVOKE.ChSphere_GetVolume__SWIG_1(radius);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChMatrix33d GetGyration(double radius) {
    ChMatrix33d ret = new ChMatrix33d(chronoPINVOKE.ChSphere_GetGyration__SWIG_1(radius), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChAABB GetBoundingBox(double radius) {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChSphere_GetBoundingBox__SWIG_1(radius), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double GetBoundingSphereRadius(double radius) {
    double ret = chronoPINVOKE.ChSphere_GetBoundingSphereRadius__SWIG_1(radius);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double rad {
    set {
      chronoPINVOKE.ChSphere_rad_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = chronoPINVOKE.ChSphere_rad_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

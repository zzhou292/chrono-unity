//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRoundedBox : ChVolume {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRoundedBox(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChRoundedBox_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRoundedBox obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChRoundedBox(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChRoundedBox() : this(chronoPINVOKE.new_ChRoundedBox__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChRoundedBox(ChVector3d lengths, double sphere_radius) : this(chronoPINVOKE.new_ChRoundedBox__SWIG_1(ChVector3d.getCPtr(lengths), sphere_radius), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChRoundedBox(double length_x, double length_y, double length_z, double sphere_radius) : this(chronoPINVOKE.new_ChRoundedBox__SWIG_2(length_x, length_y, length_z, sphere_radius), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChRoundedBox(ChRoundedBox source) : this(chronoPINVOKE.new_ChRoundedBox__SWIG_3(ChRoundedBox.getCPtr(source)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChRoundedBox_Clone(swigCPtr);
    ChRoundedBox ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChRoundedBox(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new ChGeometry.Type GetType() {
    ChGeometry.Type ret = (ChGeometry.Type)chronoPINVOKE.ChRoundedBox_GetType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetVolume() {
    double ret = chronoPINVOKE.ChRoundedBox_GetVolume__SWIG_0(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChMatrix33d GetGyration() {
    ChMatrix33d ret = new ChMatrix33d(chronoPINVOKE.ChRoundedBox_GetGyration__SWIG_0(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChAABB GetBoundingBox() {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChRoundedBox_GetBoundingBox__SWIG_0(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetBoundingSphereRadius() {
    double ret = chronoPINVOKE.ChRoundedBox_GetBoundingSphereRadius__SWIG_0(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d Baricenter() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChRoundedBox_Baricenter(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d Evaluate(double parU, double parV, double parW) {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChRoundedBox_Evaluate(swigCPtr, parU, parV, parW), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetHalflengths() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChRoundedBox_GetHalflengths(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetLengths() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChRoundedBox_GetLengths(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSphereRadius() {
    double ret = chronoPINVOKE.ChRoundedBox_GetSphereRadius(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLengths(ChVector3d mlen) {
    chronoPINVOKE.ChRoundedBox_SetLengths(swigCPtr, ChVector3d.getCPtr(mlen));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSphereRadius(double radius) {
    chronoPINVOKE.ChRoundedBox_SetSphereRadius(swigCPtr, radius);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChRoundedBox_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChRoundedBox_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double GetVolume(ChVector3d lengths, double srad) {
    double ret = chronoPINVOKE.ChRoundedBox_GetVolume__SWIG_1(ChVector3d.getCPtr(lengths), srad);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChMatrix33d GetGyration(ChVector3d lengths, double srad) {
    ChMatrix33d ret = new ChMatrix33d(chronoPINVOKE.ChRoundedBox_GetGyration__SWIG_1(ChVector3d.getCPtr(lengths), srad), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ChAABB GetBoundingBox(ChVector3d lengths, double srad) {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChRoundedBox_GetBoundingBox__SWIG_1(ChVector3d.getCPtr(lengths), srad), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double GetBoundingSphereRadius(ChVector3d lengths, double srad) {
    double ret = chronoPINVOKE.ChRoundedBox_GetBoundingSphereRadius__SWIG_1(ChVector3d.getCPtr(lengths), srad);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d hlen {
    set {
      chronoPINVOKE.ChRoundedBox_hlen_set(swigCPtr, ChVector3d.getCPtr(value));
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = chronoPINVOKE.ChRoundedBox_hlen_get(swigCPtr);
      ChVector3d ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVector3d(cPtr, false);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double srad {
    set {
      chronoPINVOKE.ChRoundedBox_srad_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = chronoPINVOKE.ChRoundedBox_srad_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

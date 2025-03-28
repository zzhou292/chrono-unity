//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLineArc : ChLine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLineArc(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLineArc_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLineArc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLineArc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChCoordsysd origin {
    set {
      chronoPINVOKE.ChLineArc_origin_set(swigCPtr, ChCoordsysd.getCPtr(value));
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = chronoPINVOKE.ChLineArc_origin_get(swigCPtr);
      ChCoordsysd ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChCoordsysd(cPtr, false);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double radius {
    set {
      chronoPINVOKE.ChLineArc_radius_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = chronoPINVOKE.ChLineArc_radius_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double angle1 {
    set {
      chronoPINVOKE.ChLineArc_angle1_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = chronoPINVOKE.ChLineArc_angle1_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double angle2 {
    set {
      chronoPINVOKE.ChLineArc_angle2_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = chronoPINVOKE.ChLineArc_angle2_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool counterclockwise {
    set {
      chronoPINVOKE.ChLineArc_counterclockwise_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = chronoPINVOKE.ChLineArc_counterclockwise_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChLineArc(ChCoordsysd morigin, double mradius, double mangle1, double mangle2, bool mcounterclockwise) : this(chronoPINVOKE.new_ChLineArc__SWIG_0(ChCoordsysd.getCPtr(morigin), mradius, mangle1, mangle2, mcounterclockwise), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc(ChCoordsysd morigin, double mradius, double mangle1, double mangle2) : this(chronoPINVOKE.new_ChLineArc__SWIG_1(ChCoordsysd.getCPtr(morigin), mradius, mangle1, mangle2), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc(ChCoordsysd morigin, double mradius, double mangle1) : this(chronoPINVOKE.new_ChLineArc__SWIG_2(ChCoordsysd.getCPtr(morigin), mradius, mangle1), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc(ChCoordsysd morigin, double mradius) : this(chronoPINVOKE.new_ChLineArc__SWIG_3(ChCoordsysd.getCPtr(morigin), mradius), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc(ChCoordsysd morigin) : this(chronoPINVOKE.new_ChLineArc__SWIG_4(ChCoordsysd.getCPtr(morigin)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc() : this(chronoPINVOKE.new_ChLineArc__SWIG_5(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineArc(ChLineArc source) : this(chronoPINVOKE.new_ChLineArc__SWIG_6(ChLineArc.getCPtr(source)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChLineArc_Clone(swigCPtr);
    ChLineArc ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLineArc(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new ChGeometry.Type GetType() {
    ChGeometry.Type ret = (ChGeometry.Type)chronoPINVOKE.ChLineArc_GetType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetComplexity() {
    int ret = chronoPINVOKE.ChLineArc_GetComplexity(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d Evaluate(double U) {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLineArc_Evaluate(swigCPtr, U), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Length(int sampling) {
    double ret = chronoPINVOKE.ChLineArc_Length(swigCPtr, sampling);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCounterclockwise(bool mcc) {
    chronoPINVOKE.ChLineArc_SetCounterclockwise(swigCPtr, mcc);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAngle1deg(double a1) {
    chronoPINVOKE.ChLineArc_SetAngle1deg(swigCPtr, a1);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAngle2deg(double a2) {
    chronoPINVOKE.ChLineArc_SetAngle2deg(swigCPtr, a2);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChLineArc_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChLineArc_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

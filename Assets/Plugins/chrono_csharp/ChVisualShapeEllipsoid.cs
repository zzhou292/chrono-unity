//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVisualShapeEllipsoid : ChVisualShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChVisualShapeEllipsoid(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChVisualShapeEllipsoid_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVisualShapeEllipsoid obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChVisualShapeEllipsoid(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChVisualShapeEllipsoid() : this(chronoPINVOKE.new_ChVisualShapeEllipsoid__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeEllipsoid(double axis_x, double axis_y, double axis_z) : this(chronoPINVOKE.new_ChVisualShapeEllipsoid__SWIG_1(axis_x, axis_y, axis_z), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeEllipsoid(ChVector3d axes) : this(chronoPINVOKE.new_ChVisualShapeEllipsoid__SWIG_2(ChVector3d.getCPtr(axes)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeEllipsoid(ChEllipsoid ellipsoid) : this(chronoPINVOKE.new_ChVisualShapeEllipsoid__SWIG_3(ChEllipsoid.getCPtr(ellipsoid)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChEllipsoid GetGeometry() {
    ChEllipsoid ret = new ChEllipsoid(chronoPINVOKE.ChVisualShapeEllipsoid_GetGeometry(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetSemiaxes() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChVisualShapeEllipsoid_GetSemiaxes(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetAxes() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChVisualShapeEllipsoid_GetAxes(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChAABB GetBoundingBox() {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChVisualShapeEllipsoid_GetBoundingBox(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChVisualShapeEllipsoid_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChVisualShapeEllipsoid_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

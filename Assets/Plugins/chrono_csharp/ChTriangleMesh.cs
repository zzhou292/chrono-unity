//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTriangleMesh : ChGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTriangleMesh(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChTriangleMesh_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTriangleMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChTriangleMesh(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void AddTriangle(ChVector3d vertex0, ChVector3d vertex1, ChVector3d vertex2) {
    chronoPINVOKE.ChTriangleMesh_AddTriangle__SWIG_0(swigCPtr, ChVector3d.getCPtr(vertex0), ChVector3d.getCPtr(vertex1), ChVector3d.getCPtr(vertex2));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddTriangle(ChTriangle atriangle) {
    chronoPINVOKE.ChTriangleMesh_AddTriangle__SWIG_1(swigCPtr, ChTriangle.getCPtr(atriangle));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint GetNumTriangles() {
    uint ret = chronoPINVOKE.ChTriangleMesh_GetNumTriangles(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChTriangle GetTriangle(uint index) {
    ChTriangle ret = new ChTriangle(chronoPINVOKE.ChTriangleMesh_GetTriangle(swigCPtr, index), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Clear() {
    chronoPINVOKE.ChTriangleMesh_Clear(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Transform(ChVector3d displ, ChMatrix33d rotscale) {
    chronoPINVOKE.ChTriangleMesh_Transform__SWIG_0(swigCPtr, ChVector3d.getCPtr(displ), ChMatrix33d.getCPtr(rotscale));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Transform(ChVector3d displ, ChQuaterniond mquat) {
    chronoPINVOKE.ChTriangleMesh_Transform__SWIG_1(swigCPtr, ChVector3d.getCPtr(displ), ChQuaterniond.getCPtr(mquat));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Transform(ChVector3d displ) {
    chronoPINVOKE.ChTriangleMesh_Transform__SWIG_2(swigCPtr, ChVector3d.getCPtr(displ));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual new ChGeometry.Type GetType() {
    ChGeometry.Type ret = (ChGeometry.Type)chronoPINVOKE.ChTriangleMesh_GetType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChAABB GetBoundingBox() {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChTriangleMesh_GetBoundingBox(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetManifoldDimension() {
    int ret = chronoPINVOKE.ChTriangleMesh_GetManifoldDimension(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChTriangleMesh_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChTriangleMesh_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

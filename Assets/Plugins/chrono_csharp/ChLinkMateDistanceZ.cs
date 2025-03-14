//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMateDistanceZ : ChLinkMateGeneric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMateDistanceZ(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLinkMateDistanceZ_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMateDistanceZ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLinkMateDistanceZ(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkMateDistanceZ() : this(chronoPINVOKE.new_ChLinkMateDistanceZ__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateDistanceZ(ChLinkMateDistanceZ other) : this(chronoPINVOKE.new_ChLinkMateDistanceZ__SWIG_1(ChLinkMateDistanceZ.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDistance(double distance) {
    chronoPINVOKE.ChLinkMateDistanceZ_SetDistance(swigCPtr, distance);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetDistance() {
    double ret = chronoPINVOKE.ChLinkMateDistanceZ_GetDistance(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChBodyFrame body1, ChBodyFrame body2, ChFramed absframe) {
    chronoPINVOKE.ChLinkMateDistanceZ_Initialize__SWIG_0_0(swigCPtr, ChBodyFrame.getCPtr(body1), ChBodyFrame.getCPtr(body2), ChFramed.getCPtr(absframe));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChBodyFrame body1, ChBodyFrame body2, bool pos_are_relative, ChFramed frame1, ChFramed frame2) {
    chronoPINVOKE.ChLinkMateDistanceZ_Initialize__SWIG_0_1(swigCPtr, ChBodyFrame.getCPtr(body1), ChBodyFrame.getCPtr(body2), pos_are_relative, ChFramed.getCPtr(frame1), ChFramed.getCPtr(frame2));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChBodyFrame body1, ChBodyFrame body2, bool pos_are_relative, ChVector3d point1, ChVector3d point2, ChVector3d dir1, ChVector3d dir2) {
    chronoPINVOKE.ChLinkMateDistanceZ_Initialize__SWIG_0_2(swigCPtr, ChBodyFrame.getCPtr(body1), ChBodyFrame.getCPtr(body2), pos_are_relative, ChVector3d.getCPtr(point1), ChVector3d.getCPtr(point2), ChVector3d.getCPtr(dir1), ChVector3d.getCPtr(dir2));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBodyFrame body1, ChBodyFrame body2, bool pos_are_relative, ChVector3d point1, ChVector3d point2, ChVector3d dir2) {
    chronoPINVOKE.ChLinkMateDistanceZ_Initialize__SWIG_1(swigCPtr, ChBodyFrame.getCPtr(body1), ChBodyFrame.getCPtr(body2), pos_are_relative, ChVector3d.getCPtr(point1), ChVector3d.getCPtr(point2), ChVector3d.getCPtr(dir2));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChLinkMateDistanceZ_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChLinkMateDistanceZ_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

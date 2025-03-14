//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaftsCouple : ChPhysicsItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaftsCouple(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChShaftsCouple_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaftsCouple obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChShaftsCouple(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChShaftsCouple() : this(chronoPINVOKE.new_ChShaftsCouple__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaftsCouple(ChShaftsCouple other) : this(chronoPINVOKE.new_ChShaftsCouple__SWIG_1(ChShaftsCouple.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint GetNumAffectedCoords() {
    uint ret = chronoPINVOKE.ChShaftsCouple_GetNumAffectedCoords(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Initialize(ChShaft shaft_1, ChShaft shaft_2) {
    bool ret = chronoPINVOKE.ChShaftsCouple_Initialize(swigCPtr, ChShaft.getCPtr(shaft_1), ChShaft.getCPtr(shaft_2));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetShaft1() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChShaftsCouple_GetShaft1(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetShaft2() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChShaftsCouple_GetShaft2(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetReaction1() {
    double ret = chronoPINVOKE.ChShaftsCouple_GetReaction1(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetReaction2() {
    double ret = chronoPINVOKE.ChShaftsCouple_GetReaction2(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRelativePos() {
    double ret = chronoPINVOKE.ChShaftsCouple_GetRelativePos(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRelativePosDt() {
    double ret = chronoPINVOKE.ChShaftsCouple_GetRelativePosDt(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRelativePosDt2() {
    double ret = chronoPINVOKE.ChShaftsCouple_GetRelativePosDt2(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChShaftsCouple_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChShaftsCouple_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}

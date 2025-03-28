//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionOperator : ChFunction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionOperator(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChFunctionOperator_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionOperator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChFunctionOperator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionOperator() : this(chronoPINVOKE.new_ChFunctionOperator__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionOperator(ChFunctionOperator other) : this(chronoPINVOKE.new_ChFunctionOperator__SWIG_1(ChFunctionOperator.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunction.Type GetFunctionType() {
    ChFunction.Type ret = (ChFunction.Type)chronoPINVOKE.ChFunctionOperator_GetFunctionType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetVal(double x) {
    double ret = chronoPINVOKE.ChFunctionOperator_GetVal(swigCPtr, x);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetOperationType(ChFunctionOperator.eChOperation m_op) {
    chronoPINVOKE.ChFunctionOperator_SetOperationType(swigCPtr, (int)m_op);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionOperator.eChOperation GetOperationType() {
    ChFunctionOperator.eChOperation ret = (ChFunctionOperator.eChOperation)chronoPINVOKE.ChFunctionOperator_GetOperationType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFirstOperandFunction(ChFunction m_m_first_fun) {
    chronoPINVOKE.ChFunctionOperator_SetFirstOperandFunction(swigCPtr, ChFunction.getCPtr(m_m_first_fun));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetFirstOperandFunction() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChFunctionOperator_GetFirstOperandFunction(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSecondOperandFunction(ChFunction m_m_second_fun) {
    chronoPINVOKE.ChFunctionOperator_SetSecondOperandFunction(swigCPtr, ChFunction.getCPtr(m_m_second_fun));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetSecondOperandFunction() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChFunctionOperator_GetSecondOperandFunction(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChFunctionOperator_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChFunctionOperator_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum eChOperation {
    ADD = 0,
    SUB,
    MUL,
    DIV,
    POW,
    MAX,
    MIN,
    MODULO,
    FABS,
    FUNCT
  }

}

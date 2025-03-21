//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSolverAPGD : ChIterativeSolverVI {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSolverAPGD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChSolverAPGD_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSolverAPGD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChSolverAPGD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChSolverAPGD() : this(chronoPINVOKE.new_ChSolverAPGD(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual new ChSolver.Type GetType() {
    ChSolver.Type ret = (ChSolver.Type)chronoPINVOKE.ChSolverAPGD_GetType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Solve(SWIGTYPE_p_ChSystemDescriptor sysd) {
    double ret = chronoPINVOKE.ChSolverAPGD_Solve(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(sysd));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetError() {
    double ret = chronoPINVOKE.ChSolverAPGD_GetError(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Dump_Rhs(SWIGTYPE_p_std__vectorT_double_t temp) {
    chronoPINVOKE.ChSolverAPGD_Dump_Rhs(swigCPtr, SWIGTYPE_p_std__vectorT_double_t.getCPtr(temp));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Dump_Lambda(SWIGTYPE_p_std__vectorT_double_t temp) {
    chronoPINVOKE.ChSolverAPGD_Dump_Lambda(swigCPtr, SWIGTYPE_p_std__vectorT_double_t.getCPtr(temp));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}
